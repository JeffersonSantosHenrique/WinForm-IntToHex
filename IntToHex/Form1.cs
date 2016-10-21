using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntToHex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onClickConvert(object sender, EventArgs e)
        {

            label1.Text = "";
            listBox1.BackColor = Color.White;

            if (!string.IsNullOrEmpty(txtDecimal.Text))
            {                
                int c = int.Parse(txtDecimal.Text);
                var color = Color.FromArgb(0xFF, c & 0xFF, (c >> 8) & 0xFF, (c >> 16) & 0xFF);
                label1.Text = string.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);                
                listBox1.BackColor = color;
            }
            else
            {
                MessageBox.Show("Field can not be blank");                
            }
            
        }

    }
}
