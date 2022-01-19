using System;
namespace IkiCore.Modeling
{
    [Serializable]
    public partial struct Mesh
    {
        public string Name;
        public Vertice[] Vertices;
        public int[] Triangles;
        public Mesh(string name)
        {
            Name = name;
            Vertices = null;
            Triangles = null;
        }
        public Mesh(int vertices, int triangles)
        {
            Name = "";
            Vertices = new Vertice[vertices];
            Triangles = new int[triangles];
        }
        public Mesh(string name, int vertices, int triangles)
        {
            Name = name;
            Vertices = new Vertice[vertices];
            Triangles = new int[triangles];
        }
    }
}
