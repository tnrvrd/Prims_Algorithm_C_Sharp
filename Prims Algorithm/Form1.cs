using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prims_Algorithm
{
    public partial class Form1 : Form
    {
        #region Parameters
        /// <summary>
        /// List of vertex
        /// </summary>
        List<Vertex> listVertex;

        /// <summary>
        /// List edge
        /// </summary>
        List<Edge> listEdge;


        /// <summary>
        /// In tree list of vertex
        /// </summary>
        List<Vertex> listInTreeVertex;

        // Copy list vertex
        List<Vertex> copiedListVertex;

        List<Edge> copiedListEdge;

        List<LocationVertex> listLocationVertex;

        /// <summary>
        /// Edge combobox object
        /// </summary>
        public class ComboboxItem
        {
            public string Text { get; set; }
            public Vertex Vertex { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        #endregion

        #region Form Methods

        /// <summary>
        /// Main form
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            StaticDatas.MaxVertexNumber = 12;

            listVertex = new List<Vertex>();
            listEdge = new List<Edge>();
            // Create in tree list
            listInTreeVertex = new List<Vertex>();

            CreateLocationOfVertex();
        }

        private void CreateLocationOfVertex()
        {
            listLocationVertex = new List<LocationVertex>();

            for (int i = 0; i < StaticDatas.MaxVertexNumber; i++)
            {
                LocationVertex location = new LocationVertex();

                location.Height = 30;
                location.Width = 30;

                // Draw 4 vertex in each row
                int tempX = i % 4;
                int tempY = i / 4;

                location.X = 50 + tempX * 100;
                location.Y = 50 + tempY * 100;

                location.IsEmpty = true;

                listLocationVertex.Add(location);
            }
        }

        #endregion

        #region Functional Methods

        private void Calculate()
        {
            listInTreeVertex = new List<Vertex>();
            // Copy list vertex
            copiedListVertex = listVertex.ToList();
            copiedListEdge = listEdge.ToList();

            foreach (Vertex vertex in listVertex)
            {
                // set key to infinite
                vertex.Key = 999999;
                // set parent to null
                vertex.Parent = null;
            }

            // Add root vertex to intree vertex list
            Vertex rootVertex = new Vertex();
            if (cbRootVertex.SelectedIndex != -1)
            {
                rootVertex = listVertex[cbRootVertex.SelectedIndex];
            }

            // Set root vertex
            rootVertex.Key = 0;
            rootVertex.Parent = rootVertex;

            // 
            while (listInTreeVertex.Count < listVertex.Count)
            {
                // get the smallest vertex from copiedlistvertex
                Vertex currentVertex = GetTheSmallestVertex();

                // If key is infinite, it means this vertex is not connected
                // so we add the other remaining vertex and finishes the algorithm
                if (currentVertex.Key == 999999)
                {
                    copiedListVertex.Remove(currentVertex);
                    listInTreeVertex.Add(currentVertex);

                    continue;
                }

                //// Copy edge olustur
                List<Edge> temp2edge = new List<Edge>();
                foreach (Edge edge in copiedListEdge.ToList())
                {
                    if (edge.FromVertex.Name == currentVertex.Name)
                    {
                        edge.IsFrom = true;
                        temp2edge.Add(edge);
                        copiedListEdge.Remove(edge);
                    }
                    else if (edge.ToVertex.Name == currentVertex.Name)
                    {
                        edge.IsFrom = false;
                        temp2edge.Add(edge);
                        copiedListEdge.Remove(edge);
                    }
                }

                // find the smallest distance near this vertex
                temp2edge = SelectionSort(temp2edge);
                foreach (Edge edge2 in temp2edge)
                {
                    Vertex tempvertex = new Vertex();
                    if (edge2.IsFrom)
                    {
                        tempvertex = edge2.ToVertex;

                        if (tempvertex.Key > edge2.Distance)
                        {
                            tempvertex.Key = edge2.Distance;
                            tempvertex.Parent = edge2.FromVertex;
                        }
                    }
                    else
                    {
                        tempvertex = edge2.FromVertex;

                        if (tempvertex.Key > edge2.Distance)
                        {
                            tempvertex.Key = edge2.Distance;
                            tempvertex.Parent = edge2.ToVertex;
                        }
                    }


                }

                copiedListVertex.Remove(currentVertex);
                listInTreeVertex.Add(currentVertex);
            }


            //// draw result
            panelResult.Invalidate();
        }
        /// <summary>
        /// Returns small integer from 2 integers
        /// </summary>
        /// <param name="a">First integer</param>
        /// <param name="b">Second integer</param>
        /// <returns></returns>
        private int getSmallInteger(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        private void UpdateListBoxEdges()
        {
            lbEdges.Items.Clear();
            foreach (Edge _edge in listEdge)
            {
                lbEdges.Items.Add(_edge.FromVertex.Name + " - " + _edge.ToVertex.Name + "  " + _edge.Distance.ToString());
            }

            DrawPanelInput();
        }

        private void UpdateListBoxVertex()
        {
            lbVertex.Items.Clear();
            cbFromVertex.Items.Clear();
            cbRootVertex.Items.Clear();
            foreach (Vertex _vertex in listVertex)
            {
                lbVertex.Items.Add(_vertex.Name);

                ComboboxItem item = new ComboboxItem();
                item.Text = _vertex.Name;
                item.Vertex = _vertex;
                cbFromVertex.Items.Add(item);
                cbRootVertex.Items.Add(item);
            }

            DrawPanelInput();
        }

        private Vertex GetVertexForName(string _name)
        {
            foreach (Vertex _vertex in listVertex)
            {
                if (_vertex.Name == _name)
                {
                    return _vertex;
                }
            }

            return null;
        }

        private void DrawPanelInput()
        {
            panelDrawing.Invalidate();
        }

        private void AddEdge(int distance, Vertex fromVertex, Vertex toVertex)
        {
            // Control is a vertex same
            bool isOk = true;

            foreach (Edge _edge in listEdge)
            {
                if ((_edge.FromVertex.Name == fromVertex.Name && _edge.ToVertex.Name == toVertex.Name)
                    || (_edge.FromVertex.Name == toVertex.Name && _edge.ToVertex.Name == fromVertex.Name))
                {
                    isOk = false;
                    break;
                }
            }

            if (isOk)
            {
                // distance of vertex



                // Add edge to the list
                Edge edge = new Edge();
                edge.FromVertex = fromVertex;
                edge.ToVertex = toVertex;
                edge.Distance = distance;
                listEdge.Add(edge);

                // Draw edge
                DrawPanelInput();

                UpdateListBoxEdges();
            }
            else
            {
                MessageBox.Show("! There is an edge has same properties");
            }
        }

        private void AddVertex(string vertexName)
        {
            bool isOk = true;
            foreach (Vertex _vertex in listVertex)
            {
                if (_vertex.Name == vertexName)
                {
                    isOk = false;
                    break;
                }
            }

            if (isOk)
            {
                int countVertex = listVertex.Count;

                Vertex vertex = new Vertex();
                vertex.Name = vertexName;

                foreach (LocationVertex location in listLocationVertex)
                {
                    if (location.IsEmpty)
                    {
                        vertex.LocationVertex = location;
                        location.IsEmpty = false;
                        break;
                    }
                }


                listVertex.Add(vertex);
                DrawPanelInput();

                UpdateListBoxVertex();

                if (listVertex.Count == StaticDatas.MaxVertexNumber)
                {
                    btnAddVertex.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("! There is a vertex has same name");
            }
        }

        private Vertex GetTheSmallestVertex()
        {
            Vertex smallest = copiedListVertex[0];
            foreach (Vertex vertex in copiedListVertex)
            {
                if (smallest.Key > vertex.Key)
                {
                    smallest = vertex;
                }
            }

            return smallest;
        }

        private List<Edge> SelectionSort(List<Edge> _listEdges)
        {
            int biggest;
            Edge tempEdge;

            for (int i = 0; i < _listEdges.Count - 1; i++)
            {
                biggest = i;
                for (int j = i + 1; j < _listEdges.Count; j++)
                {
                    if (_listEdges[j].Distance < _listEdges[biggest].Distance)
                    {
                        biggest = j;
                    }
                }
                if (biggest != i)
                {
                    tempEdge = _listEdges[i];
                    _listEdges[i] = _listEdges[biggest];
                    _listEdges[biggest] = tempEdge;
                }
            }
            return _listEdges;
        }

        #endregion

        #region Event Functions
        /// <summary>
        /// Add Vertex button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddVertex_Click(object sender, EventArgs e)
        {
            string vertexName = tbVertexName.Text;
            AddVertex(vertexName); 
        }

        /// <summary>
        /// Add Edge Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEdge_Click(object sender, EventArgs e)
        {
           if (tbDistance.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the distance");
            }
            else
            {
                int distance = Convert.ToInt16(tbDistance.Text);


               
                // Get items of combobox
                ComboboxItem selectedFromItem = (ComboboxItem)cbFromVertex.SelectedItem;
                ComboboxItem selectedToItem = (ComboboxItem)cbToVertex.SelectedItem;

                if (selectedFromItem != null && selectedToItem != null)
                {
                    // start vertex
                    Vertex fromVertex = selectedFromItem.Vertex;
                    // finish vertex
                    Vertex toVertex = selectedToItem.Vertex;

                    AddEdge(distance, fromVertex, toVertex);  
                }
                             
            }

               
        }

        private void btnCalculatePrims_Click(object sender, EventArgs e)
        {


            Calculate();
        }

        /// <summary>
        /// Let only numbers for distance textfield
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void cbFromVertex_SelectedValueChanged(object sender, EventArgs e)
        {
            cbToVertex.Items.Clear();
            int i = 0;
            foreach (Vertex vertex in listVertex)
            {
                if (cbFromVertex.SelectedIndex != i)
                {
                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = vertex.Name;
                    item2.Vertex = vertex;
                    cbToVertex.Items.Add(item2);
                }
                i++;
            }

            if (cbToVertex.Items.Count > 0)
            {
                cbToVertex.SelectedIndex = 0;
            }
            
        }

        private void panelResult_Paint(object sender, PaintEventArgs e)
        {
            int totalCost = 0;

            //DrawPanelInput();
            int i = 0;
            foreach (Vertex _vertex in listInTreeVertex)
            {
                // Create graphichs object
                System.Drawing.Graphics graphicsObj;
                graphicsObj = panelResult.CreateGraphics();
                Pen myPen = new Pen(System.Drawing.Color.Red, 5);



                if (i == 0 && cbRootVertex.SelectedIndex == -1)
                {
                    myPen = new Pen(System.Drawing.Color.Black, 5);
                }
                else if (cbRootVertex.SelectedIndex != -1)
                {
                    ComboboxItem item2 = new ComboboxItem();
                    item2 = (ComboboxItem)cbRootVertex.SelectedItem;

                    if (item2.Vertex.Name == _vertex.Name)
                    {
                        myPen = new Pen(System.Drawing.Color.Black, 5);
                    }
                }
                // Draw vertex
                graphicsObj.DrawEllipse(myPen, _vertex.LocationVertex.X, _vertex.LocationVertex.Y, _vertex.LocationVertex.Width, _vertex.LocationVertex.Height);
                // Write vertex name
                graphicsObj.DrawString(_vertex.Name, new Font("Tahoma", 8), Brushes.Black, new PointF(_vertex.LocationVertex.X + 10, _vertex.LocationVertex.Y + 10));


                if (i != 0 && _vertex.Key != 999999)
                {
                    // EDGE

                    // Get start and finish points of edge
                    int startX = Convert.ToInt16(_vertex.LocationVertex.X + 15);
                    int startY = Convert.ToInt16(_vertex.LocationVertex.Y + 15);
                    int finishX = Convert.ToInt16(_vertex.Parent.LocationVertex.X + 15);
                    int finishY = Convert.ToInt16(_vertex.Parent.LocationVertex.Y + 15);

                    // Get middle point of edge
                    int middleX = getSmallInteger(finishX, startX) + Math.Abs(finishX - startX) / 2;
                    int middleY = getSmallInteger(finishY, startY) + Math.Abs(finishY - startY) / 2;

                    // Create point array for edge
                    Point[] points = new Point[3];
                    // Start point
                    points[0] = new Point(startX, startY);
                    // Calculate middle point
                    int tempHeight = Math.Abs(finishX - startX) / 50;
                    middleY -= tempHeight * 8;
                    // Middle Point
                    points[1] = new Point(middleX, middleY);
                    // Finish point
                    points[2] = new Point(finishX, finishY);

                    // Create graphics object
                    System.Drawing.Graphics graphicsObj2;
                    graphicsObj2 = panelResult.CreateGraphics();

                    Pen myPen2 = new Pen(System.Drawing.Color.Black, 2);

                    // Draw edge
                    graphicsObj2.DrawCurve(myPen2, points);

                    // Write distance of edge
                    graphicsObj.DrawString(_vertex.Key.ToString(), new Font("Tahoma", 8), Brushes.Black, new PointF(middleX - 5, middleY + 2));

                    totalCost += _vertex.Key;
                }

                i++;

            }


            // Create graphichs object
            System.Drawing.Graphics graphicsObj3;
            graphicsObj3 = panelResult.CreateGraphics();

            // Write distance of edge
            graphicsObj3.DrawString("Total Cost = " + totalCost.ToString(), new Font("Tahoma", 8), Brushes.Black, new PointF(5, 5));

        }

        private void btnDeleteEdge_Click(object sender, EventArgs e)
        {
            if (lbEdges.SelectedIndex != -1)
            {
                listEdge.RemoveAt(lbEdges.SelectedIndex);
                UpdateListBoxEdges();
            }
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            //DrawPanelInput();
            foreach (Vertex _vertex in listVertex)
            {
                // Create graphichs object
                System.Drawing.Graphics graphicsObj;
                graphicsObj = panelDrawing.CreateGraphics();
                Pen myPen = new Pen(System.Drawing.Color.Red, 5);

                // Draw vertex
                graphicsObj.DrawEllipse(myPen, _vertex.LocationVertex.X, _vertex.LocationVertex.Y, _vertex.LocationVertex.Width, _vertex.LocationVertex.Height);
                // Write vertex name
                graphicsObj.DrawString(_vertex.Name, new Font("Tahoma", 12), Brushes.Black, new PointF(_vertex.LocationVertex.X + 5, _vertex.LocationVertex.Y + 5));
            }

            foreach (Edge _edge in listEdge)
            {
                // Get start and finish points of edge
                int startX = Convert.ToInt16(_edge.FromVertex.LocationVertex.X + 15);
                int startY = Convert.ToInt16(_edge.FromVertex.LocationVertex.Y + 15);
                int finishX = Convert.ToInt16(_edge.ToVertex.LocationVertex.X + 15);
                int finishY = Convert.ToInt16(_edge.ToVertex.LocationVertex.Y + 15);

                // Get middle point of edge
                int middleX = getSmallInteger(finishX, startX) + Math.Abs(finishX - startX) / 2;
                int middleY = getSmallInteger(finishY, startY) + Math.Abs(finishY - startY) / 2;

                // Create point array for edge
                Point[] points = new Point[3];
                // Start point
                points[0] = new Point(startX, startY);
                // Calculate middle point
                int tempHeight = Math.Abs(finishX - startX) / 50;
                middleY -= tempHeight * 8;
                // Middle Point
                points[1] = new Point(middleX, middleY);
                // Finish point
                points[2] = new Point(finishX, finishY);

                // Create graphics object
                System.Drawing.Graphics graphicsObj;
                graphicsObj = panelDrawing.CreateGraphics();

                Pen myPen = new Pen(System.Drawing.Color.Black, 2);

                // Draw edge
                graphicsObj.DrawCurve(myPen, points);

                // Write distance of edge
                graphicsObj.DrawString(_edge.Distance.ToString(), new Font("Tahoma", 8), Brushes.Black, new PointF(middleX - 5, middleY + 2));

            }
        }

        private void btnDeleteVertex_Click(object sender, EventArgs e)
        {
            if (lbVertex.SelectedIndex != -1)
            {
                Vertex _vertex = listVertex[lbVertex.SelectedIndex];

                bool isOk = true;
                foreach (Edge _edge in listEdge)
                {
                    if ((_edge.FromVertex.Name == _vertex.Name) || (_edge.ToVertex.Name == _vertex.Name))
                    {
                        isOk = false;
                        break;
                    }
                }

                if (isOk)
                {
                    _vertex.LocationVertex.IsEmpty = true;
                    listVertex.Remove(_vertex);
                    UpdateListBoxVertex();

                    if (listVertex.Count <= StaticDatas.MaxVertexNumber)
                    {
                        btnAddVertex.Enabled = true;
                    }
                    else
                    {
                        btnAddVertex.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("! There is an edge related to this vertex");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text|*.txt|All|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbEdges.Items.Clear();
                lbVertex.Items.Clear();
                listVertex.Clear();
                listEdge.Clear();
                foreach (LocationVertex lv in listLocationVertex)
                {
                    lv.IsEmpty = true;
                }

                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                string line;
                int counter = 1;
                while ((line = file.ReadLine()) != null)
                {

                    if (line[0] != '-')
                    {
                        Vertex vertex = new Vertex();
                        AddVertex(line);
                    }
                    else if (line[0] == '-')
                    {
                        IList<string> splittedString = line.Split('-').ToList<string>();

                        Vertex fromVertex = GetVertexForName(splittedString[1]);
                        Vertex toVertex = GetVertexForName(splittedString[2]);

                        if (fromVertex == null || toVertex == null)
                        {
                            MessageBox.Show("There is an error in text files in line " + counter);
                        }
                        else
                        {
                            int distance = -1;
                            try
                            {
                                distance = Convert.ToInt16(splittedString[3]);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("There is an error in distance in text files in line " + counter);
                                throw;
                            }
                            finally
                            {
                                AddEdge(distance, fromVertex, toVertex);
                            }
                        }
                    }

                    counter++;
                }

                file.Close();
            }
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("muhammedtanriverdi@gmail.com" + Environment.NewLine + "www.kodyazma.com");
        }

        private void maxVertexNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaxVertexNumber frmMaxVertexNumber = new FrmMaxVertexNumber();
            frmMaxVertexNumber.ShowDialog();

            CreateLocationOfVertex();
        }

        private void saveVertexAndEdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text|*.txt|All|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                // Read the file and display it line by line.
                System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName);

                foreach (Vertex _vertex in listVertex)
                {
                    file.WriteLine(_vertex.Name);
                }

                foreach (Edge _edge in listEdge)
                {
                    file.WriteLine("-" + _edge.FromVertex.Name + "-" + _edge.ToVertex.Name + "-" + _edge.Distance.ToString());
                }


                file.Close();
            }
        }

        #endregion

    }
}
