using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1_array
{
    public partial class Form1 : Form
    {
        int size;
        int cnt = 0;
        int[] array;

        public Form1()
        {
            InitializeComponent();
        }

        //넣기 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                int i;
                
                int data = int.Parse(textBox2.Text);
                label2.Text = "";

                if (cnt >= size)
                {
                    label1.Text = "데이터는 " + size.ToString() + "개만 입력할 수 있습니다!\n추가적으로 데이터를 넣을 수 없습니다. \n데이터 입력이 0개인 경우 크기를 세팅해주세요.";

                }


                else
                {
                    array[cnt] = data;

                    for (i = 0; i <= cnt; i++)
                    {
                        label1.Text = "";
                        label2.Text += " iarray[" + i.ToString() + "] = " + array[i].ToString() + "\t";

                        if (i % 2 != 0)
                        {
                            label2.Text += "\n";
                        }

                    }
                    cnt += 1;

                }
                


            }
            
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        //크기할당
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                size = int.Parse(textBox1.Text);
                array = new int[size];
                cnt = 0;

                if(cnt>size)
                {
                    label1.Text = "데이터는 " + size.ToString() + "개만 입력할 수 있습니다!\n추가적으로 데이터를 넣을 수 없습니다. \n데이터 입력이 0개인 경우 크기를 세팅해주세요.";
                }

                
            }

            catch(Exception ex)
            {
                label3.Text = ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
