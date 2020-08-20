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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int data = int.Parse(textBox1.Text);
                int i;

                if (data > 20 || data<0)
                {
                    label1.Text = "1과 20 사이의 수를 입력 하세요!";
                }

                else
                {
                    label1.Text = "수행된 i 값: ";

                    for (i=1;i<=data;i++)
                    {


                        label1.Text += i.ToString()+",";

                        if (i % 7 == 0)
                            label1.Text += "\n";

                    }
                    label1.Text = label1.Text.TrimEnd(',', ' ');
                }
            }
            /*
             * 1, 2, 3, 4, 5, 6, 7,
             * 8, 9, 10, 11, 12, 13, 14,
             * 15, 16, 17, 18, 19, 20 \n
             */
            catch
            {
                label1.Text = "입력 문자열의 형식이 잘못되었습니다.\n1과20 사이의 정수를 입력 하세요!";
            }
        }
    }
}
