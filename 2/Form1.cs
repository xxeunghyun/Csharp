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
        uint saving = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //입금
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                uint data = uint.Parse(textBox1.Text);

                if (data < 0)
                {
                    label1.Text = "결과에 이상이 있습니다.\n 홍길동 계좌잔고: " + saving.ToString() + "원";
                }

                else
                {
                    saving += data;
                    label1.Text = "홍길동 계좌잔고: " + saving.ToString() + "원";
                }
            }
            
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
            
        }
        
        //출금
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                uint data = uint.Parse(textBox1.Text);

                if (saving < data)
                {
                    label1.Text = "결과에 이상이 있습니다.\n 홍길동 계좌잔고: " + saving.ToString() + "원";
                }

                else
                {
                    saving -= data;
                    label1.Text = "홍길동 계좌잔고: " + saving.ToString() + "원";
                }
            }

            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
