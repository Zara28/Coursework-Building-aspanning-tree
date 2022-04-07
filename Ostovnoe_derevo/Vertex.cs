using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostovnoe_derevo
{
    public class Vertex
    {
        public string Name { get; private set; }
        public bool IsChecked { get; set; }
        public Vertex(string name, bool check)
        {
            Name = name;
            IsChecked = check;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
