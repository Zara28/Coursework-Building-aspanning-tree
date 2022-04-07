using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Ostovnoe_derevo
{
    public class Vertex
    {
        public int Name { get; private set; }
        public bool IsChecked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Color color;
        public Vertex(int name, bool check, int x, int y, Color c)
        {
            Name = name;
            IsChecked = check;
            X = x; Y = y;
            color = c;
        }
        public override string ToString()
        {
            return Name.ToString();
        }
        int[] Points()
        {
            return new int[] { X, Y };
        }
    }
}
