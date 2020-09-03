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

            radioButton1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //radiobutton 선택시 
            
            if(radioButton1.Checked == true)
            {
                label1.Text += radioButton1.Text;
            }

            else if (radioButton2.Checked == true)
            {
                label1.Text += radioButton2.Text;
            }

            else if(radioButton3.Checked == true)
            {
                label1.Text += radioButton3.Text;
            }

            //combo box 
            /*if(comboBox1.SelectedIndex == 0)
            {
                label2.Text += comboBox1.Text;
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                label2.Text += comboBox1.Text;
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                label2.Text += comboBox1.Text;
            }

            else if (comboBox1.SelectedIndex == 3)
            {*/
                label2.Text += comboBox1.Text;
            
        }
    }
}
