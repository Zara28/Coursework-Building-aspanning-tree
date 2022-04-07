using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostovnoe_derevo
{
    public class Set
    {
        public List<Graph> SetGraph;
        public List<Vertex> Vertices;

        public Set(Edge edge)
        {
            SetGraph = new List<Graph>();

            Vertices = new List<Vertex>();
            Vertices.Add(edge.FirstPoint);
            Vertices.Add(edge.SecondPoint);
        }
        
    }
}
