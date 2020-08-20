using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            1과 자기자신 외의 나누어떨어지면 X  
            */

            try
            {
                int data = int.Parse(textBox1.Text);
                bool prime = true;

                if (data < 2)
                {
                    label1.Text = "2 이상의 숫자만 입력가능";
                }
                else
                {
                    for (int i = 2; i < data; i++) // 1, 자기자신이 X 구간
                    {
                        if (data % i == 0)
                            prime = false;
                    }
                

                    if (prime == true)
                        label1.Text = data.ToString() + "은 소수입니다.";
                    else label1.Text = data.ToString() + "은 소수가 아닙니다";

                }
                
            }

            catch(Exception ex)
            {
                label1.Text = ex.Message + "\n다시 입력해주세요";
                
            }

        }

        //종료
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
