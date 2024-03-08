	sb.Append(string.Format("v {0} {1} {2}\n", -v.x, v.y, v.z));
			}
			sb.Append("\n");
			foreach(Vector3 nn in m.normals) 
			{
				Vector3 v = nn;
				sb.Append(string.Format("vn {0} {1} {2}\n", -v.x,v.y,v.z));
			}
			sb.Append("\n");
			foreach(Vector3 v in m.uv) 
			{
				sb.Append(string.Format("vt {0} {1}\n",v.x,v.y));
			}
			for (int material=0; material < m.subMeshCount; material ++) 
			{
				sb.Append("\n");
				sb.Append("usemtl ").Append(mats[material].name).Append("\n");
				sb.Append("usemap ").Append(mats[material].name).Append("\n");

        
			if (gameObjects == null || gameObjects.Length == 0)
			{
				Debug.LogWarning("ObjExport: no game objects defined, nothing to export");
				return null;
			}
			
			string meshName = gameObjects[0].name;
			string fileName = EditorUtility.SaveFilePanel("Export .obj file", Application.dataPath, meshName, "obj");
			if ( string.IsNullOrEmpty( fileName ) ) {
				Debug.LogWarning("ObjExport: no path specified");
				return null;
			}
			
