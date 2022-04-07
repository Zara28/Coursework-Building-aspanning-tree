using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ostovnoe_derevo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Graph graph = new Graph();
        List<Edge> PrimMST = new List<Edge>();
        List<Edge> KruskalMST = new List<Edge>();
        List<Edge> BoruvkaMST = new List<Edge>();
        List<Edge> DeleteMST = new List<Edge>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //graph.AddEdge(graph.vertices[0], graph.vertices[6], 2);
            //graph.AddEdge(graph.vertices[2], graph.vertices[6], 15);
            //graph.AddEdge(graph.vertices[1], graph.vertices[3], 10);
            //graph.AddEdge(graph.vertices[3], graph.vertices[0], 3);
            //graph.AddEdge(graph.vertices[4], graph.vertices[5], 5);
            //graph.AddEdge(graph.vertices[5], graph.vertices[6], 6);
            //graph.AddEdge(graph.vertices[1], graph.vertices[6], 18);
            //pictureBox1.Image = Draw(graph.edges);
           
           
            
        }
       
        public void DesDelete()
        {
            DeleteMST = new List<Edge>();
            List<Edge> edges =new List<Edge>();
            foreach (Edge e in graph.edges)
            {
                DeleteMST.Add(e);
                edges.Add(e);
            }
            edges = graph.Sort(edges, false);
            foreach (Edge e in edges)
            {
                List<Edge> temp = new List<Edge>();
                foreach(Edge e2 in DeleteMST)
                {
                    temp.Add(e2);
                }
                temp.Remove(e);
                if(graph.Svyznost(temp) == true)
                {
                    DeleteMST.Remove(e);
                    pictureBox1.Image = Draw(DeleteMST);
                    pictureBox1.Refresh();
                    Thread.Sleep(1000);
                }
                else
                {
                    continue;
                }
               

            }

        }
        public int FindRoot(int node, int[]parent)
        {
            var root = node;
            while(root!=parent[root])
            {
                root = parent[root];
            }
            while(node!=root)
            {
                var oldParent = parent[node];
                parent[node] = root;
                node = oldParent;
            }
            return root;
        }
        public void Boruvka()
        {
            BoruvkaMST = new List<Edge>();
            List<Edge> List_edges = new List<Edge>();
            foreach(Vertex v in graph.vertices)
            {
                List_edges = graph.edges.Where(e=>e.FirstPoint == v).Select(e=>e).ToList();
                int min = 1000;
                Edge min_e = null;
                foreach(Edge e in List_edges)
                {
                    if(e.Weight<min)
                    {
                        min = e.Weight;
                        min_e = e;
                    }
                }
                if(min_e!=null)
                {
                    min_e.FirstPoint.color = Color.Red;
                    min_e.SecondPoint.color = Color.Red;
                    BoruvkaMST.Add(min_e);
                    pictureBox1.Image = Draw(BoruvkaMST);
                    pictureBox1.Refresh();
                    Thread.Sleep(1000);
                }
               
            }

        }
        
        public void Kruskal()
        {
            KruskalMST = new List<Edge>();
            List<Edge> edgesNew = new List<Edge>();
            foreach (Edge e in graph.edges)
            {
                edgesNew.Add(e);
            }
            edgesNew = graph.Sort(edgesNew, true);
            var parent = Enumerable.Range(0, graph.vertices.Count).ToArray();
            foreach(Edge e in edgesNew)
            {
                var startNodeRoot = FindRoot(e.FirstPoint.Name, parent);
                var endNodeRoot = FindRoot(e.SecondPoint.Name, parent);
                if(startNodeRoot != endNodeRoot)
                {
                    e.FirstPoint.color = Color.Red;
                    e.SecondPoint.color = Color.Red;
                    KruskalMST.Add(e);
                    parent[endNodeRoot] = startNodeRoot;
                    pictureBox1.Image = Draw(KruskalMST);
                    pictureBox1.Refresh();
                    Thread.Sleep(1000);
                }
            }
        }
        

        Bitmap Draw(List<Edge>edges)
        {
            pictureBox1.Image = null;
            Bitmap bitmap = new Bitmap(793, 432);
            Graphics line = Graphics.FromImage(bitmap);
            foreach(Label label in pictureBox1.Controls)
            {
                pictureBox1.Controls.Remove(label);
            }
            SolidBrush _Srush = (SolidBrush)Brushes.Violet;
            foreach (Vertex ver in graph.vertices)
            {
                ToolTip tip = new ToolTip();
                _Srush.Color = ver.color;
                line.FillEllipse(_Srush, ver.X - 25, ver.Y - 25, 50, 50);
                tip.Tag = ver;
            }
            foreach (Edge edge in edges)
            {
               
                _Srush.Color = edge.FirstPoint.color;
                line.FillEllipse(_Srush, edge.FirstPoint.X - 25, edge.FirstPoint.Y - 25, 50, 50);

                _Srush.Color = edge.SecondPoint.color;
                line.FillEllipse(_Srush, edge.SecondPoint.X - 25, edge.SecondPoint.Y - 25, 50, 50);

                Pen pen = new Pen(Color.Black);
                line.DrawLine(pen, new Point(edge.FirstPoint.X, edge.FirstPoint.Y), new Point(edge.SecondPoint.X, edge.SecondPoint.Y));
              
                Label label = new Label();
                label.BackColor = Color.White;
                label.Size = new Size(20, 15);
                label.Text = edge.Weight.ToString();
                label.Location = new Point((edge.FirstPoint.X + edge.SecondPoint.X) / 2, (edge.FirstPoint.Y + edge.SecondPoint.Y) / 2);
                pictureBox1.Controls.Add(label);
                
            }
            return bitmap;
        }
        void Prim(int begin)
        {
            PrimMST = new List<Edge>();
            List<Edge> notUsedE = new List<Edge>(graph.edges.Count);
            foreach (Edge e in graph.edges)
            {
                notUsedE.Add(e);
            }
            
            List<Vertex> usedV = new List<Vertex>();
            List<Vertex> notUsedV = new List<Vertex>();
            for (int i = 0; i < graph.vertices.Count; i++)
                notUsedV.Add(graph.vertices[i]);
            Random rand = new Random();
            usedV.Add(graph.vertices[begin]);
            notUsedV.Remove(graph.vertices[begin]);
            while (notUsedV.Count > 0)
            {
                
                int minE = -1; 
                for (int i = 0; i < notUsedE.Count; i++)
                {
                    if ((usedV.IndexOf(notUsedE[i].FirstPoint) != -1) && (notUsedV.IndexOf(notUsedE[i].SecondPoint) != -1) ||
                        (usedV.IndexOf(notUsedE[i].SecondPoint) != -1) && (notUsedV.IndexOf(notUsedE[i].FirstPoint) != -1))
                    {
                        if (minE != -1)
                        {
                            if (notUsedE[i].Weight < notUsedE[minE].Weight)
                                minE = i;
                        }
                        else
                            minE = i;
                    }
                }
                if (usedV.IndexOf(notUsedE[minE].FirstPoint) != -1)
                {
                  
                    usedV.Add(notUsedE[minE].SecondPoint);
                    notUsedV.Remove(notUsedE[minE].SecondPoint);
                }
                else
                {
                    usedV.Add(notUsedE[minE].FirstPoint);
                    notUsedV.Remove(notUsedE[minE].FirstPoint);
                }
                
                notUsedE[minE].FirstPoint.color = Color.Red;
                notUsedE[minE].SecondPoint.color = Color.Red;
                PrimMST.Add(notUsedE[minE]);
                pictureBox1.Image = Draw(PrimMST);
                pictureBox1.Refresh();
                Thread.Sleep(1000);
                notUsedE.RemoveAt(minE);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            pictureBox1.Image = null;
            switch (comboBox1.Text)
            {
                case "Граф":
                    graph.Update();
                    pictureBox1.Image = Draw(graph.edges);
                    pictureBox1.Refresh();
                    labelMST.Text = null;
                    labelWeight.Text = null;
                    break;
                case "Алгоритм Прима":
                    graph.Update();
                    pictureBox1.Refresh();
                    Prim(0);
                    labelMST.Text = null;
                    labelMST.Text = "Остов состоит из " + graph.GetVertex(PrimMST);
                    labelWeight.Text = "Вес остова равен: "+graph.GetWeight(PrimMST).ToString();
                    break;
                case "Алгоритм Краскала":
                    graph.Update();
                    pictureBox1.Refresh();
                    Kruskal();
                    labelMST.Text = "Остов состоит из " + graph.GetVertex(KruskalMST);
                    labelWeight.Text = "Вес остова равен: " + graph.GetWeight(KruskalMST).ToString();
                    break;
                case "Алгоритм Борувки":
                    graph.Update();
                    pictureBox1.Refresh();
                    Boruvka();
                    labelMST.Text = "Остов состоит из " + graph.GetVertex(PrimMST);
                    labelWeight.Text = "Вес остова равен: " + graph.GetWeight(BoruvkaMST).ToString();
                    break;
                case "Алгоритм обратного удаления":
                    graph.Update();
                    pictureBox1.Refresh();
                    DesDelete();
                    labelMST.Text = "Остов состоит из " + graph.GetVertex(DeleteMST);
                    labelWeight.Text = "Вес остова равен: " + graph.GetWeight(DeleteMST).ToString();
                    break;
            }
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
          //  Draw(PrimMST);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            graph.Create(Convert.ToInt32(textBox_Count.Text));
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            
            if(textBox_Count.Text!=null)
            {
                int count = Convert.ToInt32(textBox_Count.Text);
                graph.Create(count);
                for (int i = 0; i < count; i++)
                {
                    TextBox ver1 = new TextBox();
                    ver1.Name = "ver1" + i;
                    ver1.Location = new Point(50, 100 + i * 30);
                    ver1.Size = new Size(50, 10);
                    TextBox ver2 = new TextBox();
                    ver2.Name = "ver2" + i;
                    ver2.Location = new Point(105, 100 + i * 30);
                    ver2.Size = new Size(50, 10);
                    Label label = new Label();
                    label.Text = "Ребро " + (i + 1);
                    label.Location = new Point(160, 100 + i * 30);
                    panel2.Controls.Add(label);
                    panel2.Controls.Add(ver1);
                    panel2.Controls.Add(ver2);
                }
            }
            
        }
    }
}
