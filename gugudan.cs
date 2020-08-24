using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //실행
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int start = int.Parse(textBox1.Text);
                int end = int.Parse(textBox2.Text);
                int i, j;


                if (start > end)
                    label3.Text = "시작 단수가 마지막 단수보다 작거나 같아야 합니다!";

                else if (start < 2 || end > 9)
                    label3.Text = "구구단은 2단~9단만 출력 가능";

                else
                {
                    label3.Text = "구구단 " + start.ToString() + "단부터 " + end.ToString() + "단까지 입니다!\n";


                    for (i = start; i < end + 1; i++)
                    {
                        for (j = 2; j < 10; j++)
                        {
                            int mul = i * j;
                            label3.Text += i.ToString() + " * " + j.ToString() + " = " + mul.ToString() + "\n";

                            if (j == 9)
                                label3.Text += "\n";
                        }
                    }
                }
            }


            catch(Exception ex)
            {
                label3.Text = ex.Message + "\n잘못 입력하셨습니다.";
            }
        }
        
        //종료
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
