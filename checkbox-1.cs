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

            
             if (checkBox1.Checked == true)
                  listBox2.Items.Add(checkBox1.Text);

              if (checkBox2.Checked == true)
                  listBox2.Items.Add(checkBox2.Text);

              if (checkBox3.Checked == true)
                  listBox2.Items.Add(checkBox3.Text);

              if (checkBox4.Checked == true)
                  listBox2.Items.Add(checkBox4.Text);

              if (checkBox5.Checked == true)
                  listBox2.Items.Add(checkBox5.Text);

              if (checkBox6.Checked == true)
                  listBox2.Items.Add(checkBox6.Text);
                  
        }
    }
}
