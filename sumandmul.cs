﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3_sumandmult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //결과
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                uint start = uint.Parse(textBox1.Text);
                uint end = uint.Parse(textBox2.Text);
                uint mul = 1;
                uint sum = 0;


                if (start > end)
                    label3.Text = "시작값은 마지막값보다 작은 값이어야 합니다!";

                else if (end > 20)
                    label3.Text = "마지막 값은 20이하여야 합니다.";

                else
                {
                    label3.Text = start.ToString() + "부터 " + end.ToString() + "까지의 ";

                    for (uint i = start; i <= end; i++)
                    {
                        sum += i;
                        mul *= i;
                    }
                    
                    label3.Text += "합은 " + sum.ToString() + "이고\n곱은 " + mul.ToString() + "입니다.";

                    /*for(int j = start; j <= end; j++)
                    {
                        mul *= j;
                    }
                    label3.Text += "곱은 " + mul.ToString() + "입니다.";*/
                }
                
            }
            
            catch(Exception ex)
            {
                label3.Text = ex.Message;
            }
        }

        //종료
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
