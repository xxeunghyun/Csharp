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
        int cnt = 0;
        int[] arr = new int[10]; //global로 둬야 작동됨...!

        public Form1()
        {
            InitializeComponent();
        }

        //넣기 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int data = int.Parse(textBox1.Text);
                int i;
                

                if (cnt >= 10)
                    label1.Text = "데이터는 10개만 입력 가능합니다.";

                else
                {
                    label1.Text = "";
                    arr[cnt] = data;

                    for (i = 0; i <= cnt; i++)  //넣기 버튼을 10번 누를때까지
                    {
                        
                        label1.Text += " iarray[" + i.ToString() + "] = " + arr[i].ToString() + "      ";

                        if (i % 2 != 0)
                            label1.Text += "\n";

                    }
                    cnt++;
                }
            }

            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
