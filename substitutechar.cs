using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //입력하기
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data1 = textBox1.Text;
                string data2 = textBox2.Text;
                string data3 = textBox3.Text;

                if (data1 == "")
                    label4.Text = "대상 문자열이 비어있습니다.";

                else if(data2 == "")
                    label4.Text = "찾을 문자열이 비어있습니다.";

                else if(data3 == "")
                     label4.Text = "바꿀 문자열이 비어있습니다.";

                else
                {
                    label4.Text = data1.Substring(0, data1.IndexOf(data2));
                    label4.Text += data3;
                    label4.Text += data1.Substring((data1.IndexOf(data2))+1);
                }
            }

            catch(Exception ex)
            {
                label4.Text = ex.Message;
            }
        }
    }
}
