namespace Prims_Algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddVertex = new System.Windows.Forms.Button();
            this.tbVertexName = new System.Windows.Forms.TextBox();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.cbFromVertex = new System.Windows.Forms.ComboBox();
            this.cbToVertex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculatePrims = new System.Windows.Forms.Button();
            this.lbEdges = new System.Windows.Forms.ListBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.btnDeleteEdge = new System.Windows.Forms.Button();
            this.lbVertex = new System.Windows.Forms.ListBox();
            this.btnDeleteVertex = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxVertexNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbRootVertex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveVertexAndEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddVertex
            // 
            this.btnAddVertex.Location = new System.Drawing.Point(11, 70);
            this.btnAddVertex.Name = "btnAddVertex";
            this.btnAddVertex.Size = new System.Drawing.Size(76, 23);
            this.btnAddVertex.TabIndex = 0;
            this.btnAddVertex.Text = "Add Vertex";
            this.btnAddVertex.UseVisualStyleBackColor = true;
            this.btnAddVertex.Click += new System.EventHandler(this.btnAddVertex_Click);
            // 
            // tbVertexName
            // 
            this.tbVertexName.Location = new System.Drawing.Point(52, 44);
            this.tbVertexName.Name = "tbVertexName";
            this.tbVertexName.Size = new System.Drawing.Size(35, 20);
            this.tbVertexName.TabIndex = 1;
            this.tbVertexName.Text = "A";
            // 
            // panelDrawing
            // 
            this.panelDrawing.AutoScroll = true;
            this.panelDrawing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDrawing.Location = new System.Drawing.Point(259, 41);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(425, 424);
            this.panelDrawing.TabIndex = 2;
            this.panelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawing_Paint);
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(198, 41);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(46, 20);
            this.tbDistance.TabIndex = 3;
            this.tbDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDistance_KeyPress);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(146, 121);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(98, 23);
            this.btnAddEdge.TabIndex = 4;
            this.btnAddEdge.Text = "Add Edge";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // cbFromVertex
            // 
            this.cbFromVertex.FormattingEnabled = true;
            this.cbFromVertex.Location = new System.Drawing.Point(198, 67);
            this.cbFromVertex.Name = "cbFromVertex";
            this.cbFromVertex.Size = new System.Drawing.Size(46, 21);
            this.cbFromVertex.TabIndex = 5;
            this.cbFromVertex.SelectedValueChanged += new System.EventHandler(this.cbFromVertex_SelectedValueChanged);
            // 
            // cbToVertex
            // 
            this.cbToVertex.FormattingEnabled = true;
            this.cbToVertex.Location = new System.Drawing.Point(198, 94);
            this.cbToVertex.Name = "cbToVertex";
            this.cbToVertex.Size = new System.Drawing.Size(46, 21);
            this.cbToVertex.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "To";
            // 
            // btnCalculatePrims
            // 
            this.btnCalculatePrims.Location = new System.Drawing.Point(14, 407);
            this.btnCalculatePrims.Name = "btnCalculatePrims";
            this.btnCalculatePrims.Size = new System.Drawing.Size(233, 58);
            this.btnCalculatePrims.TabIndex = 11;
            this.btnCalculatePrims.Text = "Calculate Prim\'s";
            this.btnCalculatePrims.UseVisualStyleBackColor = true;
            this.btnCalculatePrims.Click += new System.EventHandler(this.btnCalculatePrims_Click);
            // 
            // lbEdges
            // 
            this.lbEdges.FormattingEnabled = true;
            this.lbEdges.Location = new System.Drawing.Point(146, 150);
            this.lbEdges.Name = "lbEdges";
            this.lbEdges.Size = new System.Drawing.Size(98, 173);
            this.lbEdges.TabIndex = 12;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelResult.Location = new System.Drawing.Point(690, 41);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(425, 424);
            this.panelResult.TabIndex = 13;
            this.panelResult.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResult_Paint);
            // 
            // btnDeleteEdge
            // 
            this.btnDeleteEdge.Location = new System.Drawing.Point(146, 329);
            this.btnDeleteEdge.Name = "btnDeleteEdge";
            this.btnDeleteEdge.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteEdge.TabIndex = 15;
            this.btnDeleteEdge.Text = "Delete";
            this.btnDeleteEdge.UseVisualStyleBackColor = true;
            this.btnDeleteEdge.Click += new System.EventHandler(this.btnDeleteEdge_Click);
            // 
            // lbVertex
            // 
            this.lbVertex.FormattingEnabled = true;
            this.lbVertex.Location = new System.Drawing.Point(14, 151);
            this.lbVertex.Name = "lbVertex";
            this.lbVertex.Size = new System.Drawing.Size(98, 173);
            this.lbVertex.TabIndex = 16;
            // 
            // btnDeleteVertex
            // 
            this.btnDeleteVertex.Location = new System.Drawing.Point(14, 330);
            this.btnDeleteVertex.Name = "btnDeleteVertex";
            this.btnDeleteVertex.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteVertex.TabIndex = 18;
            this.btnDeleteVertex.Text = "Delete";
            this.btnDeleteVertex.UseVisualStyleBackColor = true;
            this.btnDeleteVertex.Click += new System.EventHandler(this.btnDeleteVertex_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1125, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFileToolStripMenuItem,
            this.saveVertexAndEdgesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadFromFileToolStripMenuItem.Text = "Load From File";
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxVertexNumberToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // maxVertexNumberToolStripMenuItem
            // 
            this.maxVertexNumberToolStripMenuItem.Name = "maxVertexNumberToolStripMenuItem";
            this.maxVertexNumberToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.maxVertexNumberToolStripMenuItem.Text = "Max Vertex Number";
            this.maxVertexNumberToolStripMenuItem.Click += new System.EventHandler(this.maxVertexNumberToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.supportToolStripMenuItem.Text = "Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.supportToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbRootVertex
            // 
            this.cbRootVertex.FormattingEnabled = true;
            this.cbRootVertex.Location = new System.Drawing.Point(81, 380);
            this.cbRootVertex.Name = "cbRootVertex";
            this.cbRootVertex.Size = new System.Drawing.Size(46, 21);
            this.cbRootVertex.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Root Vertex";
            // 
            // saveVertexAndEdgesToolStripMenuItem
            // 
            this.saveVertexAndEdgesToolStripMenuItem.Name = "saveVertexAndEdgesToolStripMenuItem";
            this.saveVertexAndEdgesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveVertexAndEdgesToolStripMenuItem.Text = "Save Into File";
            this.saveVertexAndEdgesToolStripMenuItem.Click += new System.EventHandler(this.saveVertexAndEdgesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 505);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRootVertex);
            this.Controls.Add(this.btnDeleteVertex);
            this.Controls.Add(this.lbVertex);
            this.Controls.Add(this.btnDeleteEdge);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.lbEdges);
            this.Controls.Add(this.btnCalculatePrims);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbToVertex);
            this.Controls.Add(this.cbFromVertex);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.tbVertexName);
            this.Controls.Add(this.btnAddVertex);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Prim\'s Algorithm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddVertex;
        private System.Windows.Forms.TextBox tbVertexName;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.ComboBox cbFromVertex;
        private System.Windows.Forms.ComboBox cbToVertex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculatePrims;
        private System.Windows.Forms.ListBox lbEdges;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Button btnDeleteEdge;
        private System.Windows.Forms.ListBox lbVertex;
        private System.Windows.Forms.Button btnDeleteVertex;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbRootVertex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxVertexNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveVertexAndEdgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}

