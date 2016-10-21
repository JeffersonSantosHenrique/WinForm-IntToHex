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

        // Six decimal places
        private const int C_FIX = 6;  

        private void onClickConvert(object sender, EventArgs e)
        {

            label1.Text = "";
            listBox1.BackColor = Color.White;

            if (!string.IsNullOrEmpty(txtDecimal.Text))
            {
                string a = string.Format("#{0}", IntToHexString(int.Parse(txtDecimal.Text), C_FIX));
                label1.Text = a;
                listBox1.BackColor = ColorTranslator.FromHtml(a);
            }
            else
            {
                MessageBox.Show("Field can not be blank");                
            }
            
        }

        private static String IntToHexString(int n, int len)
        {
            char[] ch = new char[len--];
            for (int i = len; i >= 0; i--)
            {
                ch[len - i] = ByteToHexChar((byte)((uint)(n >> 4 * i) & 15));
            }
            return new String(ch);
        }

        private static char ByteToHexChar(byte b)
        {
            if (b < 0 || b > 15)
                throw new Exception("IntToHexChar: input out of range for Hex value");
            return b < 10 ? (char)(b + 48) : (char)(b + 55);
        }

    }
}
