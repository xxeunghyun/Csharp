using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "";
                string data = textBox1.Text;
                string spl = ";, ";
                string[] data2;

                int i;
                int len;

                data2 = data.Split(spl.ToCharArray());

                len = data2.Length;

                for (i = 0; i < len; i++)
                {
                    label1.Text += data2[i]+"\n";
                }
            }

            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
