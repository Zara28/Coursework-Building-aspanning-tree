using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostovnoe_derevo
{
    public class Graph
    {
        public List<Edge> edges;
        public List<Vertex> vertices;

        public void AddVertex(Vertex vertex)
        {
            vertices.Add(vertex);
        }
        public void AddEdge(Vertex vertexFirst, Vertex vertexSecond, int w)
        {
            edges.Add(new Edge(vertexFirst, vertexSecond, w));
        }
        
    }
}
