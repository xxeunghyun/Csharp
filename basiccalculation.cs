﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise1
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //plus
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                int data02 = int.Parse(textBox2.Text);
                int result = data01 + data02;

                label1.Text = "+";
                label2.Text = "결과는 " + result.ToString() + "입니다";

            }

            catch
            {
                label1.Text = "???";
                label2.Text = "잘못 입력하셨습니다.";
            }
         }

        //minus
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                int data02 = int.Parse(textBox2.Text);
                int result = data01 - data02;

                label1.Text = "-";
                label2.Text = "결과는 " + result.ToString() + "입니다";

            }

            catch
            {
                label1.Text = "???";
                label2.Text = "잘못 입력하셨습니다.";
            }

        }

        //multiply
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                int data02 = int.Parse(textBox2.Text);
                int result = data01 * data02;

                label1.Text = "*";
                label2.Text = "결과는 " + result.ToString() + "입니다";

            }

            catch
            {
                label1.Text = "???";
                label2.Text = "잘못 입력하셨습니다.";
            }
        }

        //divide
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                int data02 = int.Parse(textBox2.Text);
                int result = data01 / data02;

                label1.Text = "/";
                label2.Text = "결과는 " + result.ToString() + "입니다";

            }

            catch
            {
                label1.Text = "???";
                label2.Text = "잘못 입력하셨습니다.";
            }
        }
    }
}
