﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //미만
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                int data02 = int.Parse(textBox2.Text);
                bool result = data01 > data02;

                label1.Text = ">";
                label2.Text = "결과는 " + result + "입니다";
            }

            catch
            {
                label1.Text = "???";
                label2.Text = "잘못 입력하셨습니다.";
            }
            
        }

        //이하
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                int data02 = int.Parse(textBox2.Text);
                bool result = data01>=data02;

                label1.Text = ">=";
                label2.Text = "결과는 " + result + "입니다";
            }

            catch
            {
                label1.Text = "???";
                label2.Text = "잘못 입력하셨습니다.";
            }

        }

        //같다
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                int data02 = int.Parse(textBox2.Text);
                bool result = data01 == data02;

                label1.Text = "=";
                label2.Text = "결과는 " + result + "입니다";
            }

            catch
            {
                label1.Text = "???";
                label2.Text = "잘못 입력하셨습니다.";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                int data02 = int.Parse(textBox2.Text);
                bool result = data01 != data02;

                label1.Text = "!=";
                label2.Text = "결과는 " + result + "입니다";
            }

            catch
            {
                label1.Text = "???";
                label2.Text = "잘못 입력하셨습니다.";
            }

        }

        //이상
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                int data02 = int.Parse(textBox2.Text);
                bool result = data01 <= data02;

                label1.Text = "<=";
                label2.Text = "결과는 " + result + "입니다";
            }

            catch
            {
                label1.Text = "???";
                label2.Text = "잘못 입력하셨습니다.";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                int data02 = int.Parse(textBox2.Text);
                bool result = data01 < data02;

                label1.Text = "<";
                label2.Text = "결과는 " + result + "입니다";
            }

            catch
            {
                label1.Text = "???";
                label2.Text = "잘못 입력하셨습니다.";
            }

        }
    }
}
