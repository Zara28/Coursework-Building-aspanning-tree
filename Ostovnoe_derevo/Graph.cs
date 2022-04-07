using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Threading.Tasks;

namespace Ostovnoe_derevo
{
    public class Graph
    {
        public List<Edge> edges = new List<Edge>();
        public List<Vertex> vertices = new List<Vertex>();

        public void Create(int count)
        {
            Random r = new Random();
            int x = 50;
            int y = 150;

            int deltaX = 100;
            int deltaY = 60;
            for (int i = 0; i < count; i++)
            {
                if (x > 400)
                {
                    deltaX = -deltaX;
                }
                if (y > 300)
                {
                    deltaY = -deltaY;
                }
                x += deltaX;
                y += deltaY;

                SolidBrush _Srush = (SolidBrush)Brushes.Violet;
                _Srush.Color = Color.FromArgb(255 - i * 15, 255, 1 + i * 20);
                AddVertex(new Vertex(i, false, x, y, _Srush.Color));
            }
        }
        public void AddVertex(Vertex vertex)
        {
            vertices.Add(vertex);
        }
        public void AddEdge(Vertex vertexFirst, Vertex vertexSecond, int w)
        {
            edges.Add(new Edge(vertexFirst, vertexSecond, w));
        }
        public void Update()
        {
            Color color = new Color();
            foreach (Vertex v in vertices)
            {
                v.color = Color.FromArgb(255 - vertices.IndexOf(v) * 15, 255, 1 + vertices.IndexOf(v) * 20);
                v.IsChecked = false;
            }
        }
        public bool Svyznost(List<Edge> edge)
        {
            Update();
            DFD(vertices[6], edge);
            foreach(Vertex v in vertices)
            {
                if(v.IsChecked==false)
                {
                    return false;
                }
            }
            return true;
        }
        public void DFD(Vertex i, List<Edge> e)
        {
            vertices[vertices.IndexOf(i)].IsChecked = true;
            
            foreach(Edge u in e)
            {
                if(u.FirstPoint == i && u.SecondPoint.IsChecked == false)
                {
                    DFD(u.SecondPoint, e);
                }
                else if (u.SecondPoint == i && u.FirstPoint.IsChecked == false)
                {
                    DFD(u.FirstPoint, e);
                }
            }
        }
        public List<Edge> Sort(List<Edge> edges, bool des)
        {
            if (des)
            {
                for (int i = 0; i < edges.Count; i++)
                {
                    bool good = true;
                    for (int j = 0; j < edges.Count - 1; j++)
                    {
                        if (edges[j].Weight > edges[j + 1].Weight)
                        {
                            Edge temp = edges[j];
                            edges[j] = edges[j + 1];
                            edges[j + 1] = temp;
                            good = false;
                        }
                    }
                    if (good)
                    {
                        break;
                    }

                }
            }
            else
            {
                for (int i = 0; i < edges.Count; i++)
                {
                    bool good = true;
                    for (int j = 0; j < edges.Count - 1; j++)
                    {
                        if (edges[j].Weight < edges[j + 1].Weight)
                        {
                            Edge temp = edges[j];
                            edges[j] = edges[j + 1];
                            edges[j + 1] = temp;
                            good = false;
                        }
                    }
                    if (good)
                    {
                        break;
                    }

                }
            }
            return edges;
        }
        public int GetWeight(List<Edge> edges)
        {
            int sum = 0;
            foreach (Edge e in edges)
            {
                sum += e.Weight;
            }
            return sum;
        }
        public String GetVertex(List<Edge> edges)
        {
            String ver = "";

            foreach (Edge e in edges)
            {
                if (!ver.Contains(e.FirstPoint.Name.ToString()))
                {
                    ver+=e.FirstPoint.Name.ToString()+Environment.NewLine;
                }
                if (!ver.Contains(e.SecondPoint.Name.ToString()))
                {
                    ver += e.SecondPoint.Name.ToString() + Environment.NewLine;
                }
            }
            return ver;
        }

    }
}
