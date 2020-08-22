using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3_division
{
    public partial class divandmod : Form
    {
        public divandmod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int data1 = int.Parse(textBox1.Text);
                int data2 = int.Parse(textBox2.Text);
                int div = data1 / data2;
                int mod = data1 % data2;

                label1.Text = data1.ToString() + " 나누기 " + data2.ToString() + "의 몫은 "
                    + div.ToString() + "이고, 나머지는 " + mod.ToString() + "입니다.";
            }

            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "결과가 표시되는 곳입니다!";
        }
    }
}
