using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 종합예제
{
    public partial class Form1 : Form
    {
        CheckBox[] option;
        const int optsize = 5;
        int cost;

        public Form1()
        {
            InitializeComponent();

            option = new CheckBox[optsize];
            option[0] = checkBox1; //썬루프
            option[1] = checkBox2; //지피에스
            option[2] = checkBox3; // 에어백
            option[3] = checkBox4; // 자동온도조절
            option[4] = checkBox5; //도난방지

            //제일 처음 화면에 떠있어야 하는 것
            radioButton1.Checked = true;
            label2.Image = Properties.Resources.승용차;
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //견적내기
        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            cost = 0;

            //radiobutton(동그라미)(차종) + 각각 알맞는 자동차 사진 띄우기
            listBox1.Items.Add("선택차종:");

            if (radioButton1.Checked == true)
            {
                label2.Image = Properties.Resources.승용차;
                listBox1.Items.Add("   "+radioButton1.Text);
                cost += 100;
            }

            else if (radioButton2.Checked == true)
            {
                label2.Image = Properties.Resources.트럭;
                listBox1.Items.Add("   " + radioButton2.Text);
                cost += 80;
            }

            else if (radioButton3.Checked == true)
            {
                label2.Image = Properties.Resources.승합차;
                listBox1.Items.Add("   " + radioButton3.Text);
                cost += 50;
            }

            listBox1.Items.Add("=========");

            //checkbox(네모)(옵션)
            listBox1.Items.Add("선택옵션:");

            for (int i = 0; i < 5; i++)
            {
                if (option[i].Checked == true)
                {
                    listBox1.Items.Add("   " + option[i].Text);

                    if (i == 0) cost += 1;
                    if (i == 1) cost += 3;
                    if (i == 2) cost += 10;
                    if (i == 3) cost += 2;
                    if (i == 4) cost += 2;
                }
            }

            listBox1.Items.Add("=========");

            //combo box (결제방법)
            listBox1.Items.Add("결제방법:");

            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("   " + comboBox1.Text);

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("   " + comboBox1.Text);
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add("   " + comboBox1.Text);
            }

            listBox1.Items.Add("========");


            listBox1.Items.Add("견적금액:\n" + "   " + cost + "만원");
        }
    }
}
