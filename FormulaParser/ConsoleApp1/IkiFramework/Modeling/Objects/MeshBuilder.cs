using System.Collections.Generic;
using IkiCore.Mathematics;
namespace IkiCore.Modeling
{
	public partial class MeshBuilder
    {
        public List<float3> Vertices { get { return vertices; } }
        public List<float2> Uvs { get { return uvs; } }
        public List<float3> Normals { get { return normals; } }
        public List<float4> Colors { get { return colors; } }
        List<float3> vertices = new List<float3>();
        List<float2> uvs = new List<float2>();
        List<float3> normals = new List<float3>();
        List<float4> colors = new List<float4>();
        List<int> triangles = new List<int>();
        public void AddTriangle(int index0, int index1, int index2)
        {
            triangles.Add(index0);
            triangles.Add(index1);
            triangles.Add(index2);
        }
        public void PointWriter(float3 vertex, float2 uv, bool buildTriangles, int vertexPerRow)
        {
            vertices.Add(vertex);
            uvs.Add(uv);
            if (buildTriangles)
            {
                int baseIndex = vertices.Count - 1;
                int index0 = baseIndex;
                int index1 = baseIndex - 1;
                int index2 = baseIndex - vertexPerRow;
                int index3 = baseIndex - vertexPerRow - 1;
                AddTriangle(index0, index2, index1);
                AddTriangle(index2, index3, index1);
            }
        }
    }
}
