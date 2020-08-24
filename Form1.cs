using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        uint sum = 0;
        uint cnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                uint data = uint.Parse(textBox1.Text);
                sum = 0;

                for(uint i=1;i<=data;i++)
                {
                    sum += i;
                   
                }
                cnt++;

                label1.Text = "합: " + sum.ToString() + "\n프로그램 실행 후 현재까지 이용횟수: " + cnt.ToString() + "회";
            }

            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
