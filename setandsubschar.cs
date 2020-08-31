using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        string[] arr = new string[10];
        int cnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //금지어 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                
                string data = textBox1.Text;


                if (cnt >= 10)
                    label1.Text += "금지어의 갯수는 10개로 더 추가될 수 없습니다.";

                else
                {
                    label1.Text = "";
                    arr[cnt] = data;

                    for(i=0;i<=cnt;i++)
                    {
                        label1.Text += i + 1 + "번째: " + arr[i] + "   ";

                        if ((i+1) % 5 == 0)
                            label1.Text += "\n";
                    }

                    cnt++;
                }
            }

            catch(Exception ex)
            {
                textBox2.Text = ex.Message;
            }
        }
        
        //값 보기
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string data2 = textBox2.Text; //찾을내용
                string str;
                int i;
                

                for(i=0;i< arr.Length; i++)
                {
                    string ban_word = arr[i];
                    int index = data2.IndexOf(ban_word);

                    while(index >= 0)
                    {
                        string sData02 = data2.Substring(0, index);
                        string sData03 = data2.Substring(index + ban_word.Length);

                        data2 = sData02 + "(금지어)" + sData03;
                        index = data2.IndexOf(ban_word);
                    }

                    /*textBox2.Text = data2.Substring(0, data2.IndexOf(ban_word));
                    textBox2.Text += " (금지어) ";
                    textBox2.Text += data2.Substring((data2.IndexOf(ban_word)) + ban_word.Length);
                    */
                    textBox2.Text = data2;
                }

               

            }


            catch(Exception ex)
            {
                textBox2.Text = ex.Message;
            }
        }
    }
}
