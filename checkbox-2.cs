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
        CheckBox[] chkbx;
        const int SIZE = 6;
        public Form1()
        {
            InitializeComponent();


            chkbx = new CheckBox[SIZE];

            // 0~size - 1    checkbox 1~size
            chkbx[0] = checkBox1;
            chkbx[1] = checkBox2;
            chkbx[2] = checkBox3;
            chkbx[3] = checkBox4;
            chkbx[4] = checkBox5;
            chkbx[5] = checkBox6;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void a_CheckedChanged(object sender, EventArgs e)
        {

        }


        //선택완료 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); //안에 내용 비우기

            int i;

            for(i=0;i<SIZE;i++)
            {
                if(chkbx[i].Checked == true)
                {
                    listBox2.Items.Add(chkbx[i].Text);
                }
            }
         
        }
    }
}

