using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        double result=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //더하기
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double data = double.Parse(textBox1.Text);
                
                
                result += data;
                label1.Text = result.ToString();
            }
            
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        //빼기
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double data = double.Parse(textBox1.Text);


                result -= data;
                label1.Text = result.ToString();
            }

            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        //곱하기
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double data = double.Parse(textBox1.Text);


                result *= data;
                label1.Text = result.ToString();
            }

            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        //나누기
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double data = double.Parse(textBox1.Text);


                result /= data;
                label1.Text = result.ToString();
            }

            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        //초기화
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            textBox1.Text = " ";
            result = 0;
        }
    }
}
