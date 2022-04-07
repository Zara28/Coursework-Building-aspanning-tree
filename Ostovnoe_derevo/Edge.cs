using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostovnoe_derevo
{
    public class Edge
    {
        public Vertex FirstPoint { get; private set; }
        public Vertex SecondPoint { get; private set; }
        public float Weight { get; private set; }

        public Edge(Vertex first, Vertex second, float valueOfWeight)
        {
            FirstPoint = first;
            SecondPoint = second;
            Weight = valueOfWeight;
        }
        public override string ToString()
        {
            return FirstPoint.Name+" "+SecondPoint.Name;
        }
    }
}
