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
    public partial class FrmMaxVertexNumber : Form
    {
        public FrmMaxVertexNumber()
        {
            InitializeComponent();

            tbMaxVertexNumber.Text = StaticDatas.MaxVertexNumber.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                StaticDatas.MaxVertexNumber = Convert.ToInt16(tbMaxVertexNumber.Text);
            }
            catch (Exception)
            {
                
            }
        }

        private void tbMaxVertexNumber_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
