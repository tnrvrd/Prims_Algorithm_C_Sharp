namespace Prims_Algorithm
{
    partial class FrmMaxVertexNumber
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbMaxVertexNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(273, 58);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Maximum vertex number is 12 by default. You can \nchange this number, but there ma" +
    "y occurs some design\nproblem. For more information you can contact with \nmuhamme" +
    "dtanriverdi@gmail.com";
            // 
            // tbMaxVertexNumber
            // 
            this.tbMaxVertexNumber.Location = new System.Drawing.Point(119, 76);
            this.tbMaxVertexNumber.MaxLength = 2;
            this.tbMaxVertexNumber.Name = "tbMaxVertexNumber";
            this.tbMaxVertexNumber.Size = new System.Drawing.Size(35, 20);
            this.tbMaxVertexNumber.TabIndex = 1;
            this.tbMaxVertexNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMaxVertexNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxVertexNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Vertex Number";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(160, 74);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmMaxVertexNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 118);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaxVertexNumber);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmMaxVertexNumber";
            this.Text = "Max Vertex Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tbMaxVertexNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
    }
}