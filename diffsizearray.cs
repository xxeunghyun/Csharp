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
    public partial class array : Form
    {
        int cnt = 0;
        int[] arr; //global로 둬야 작동됨...!
        int size;

        public array()
        {
            InitializeComponent();
        }

        //넣기 버튼-textbox1
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int data = int.Parse(textBox1.Text);
                int i;
                size = int.Parse(textBox2.Text);

                if (cnt >= size)
                    label1.Text = "데이터는 "+size.ToString()+"개만 입력 가능합니다.\n추가적으로 데이터를 넣을 수 없습니다.\n데이터 입력이 0개인 경우, 크기를 세팅해주세요.";

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
        
        //배열 사이즈 정하기
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                size = int.Parse(textBox2.Text);
                arr = new int[size];
            }

           catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
