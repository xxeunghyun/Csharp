using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_volume
{
    public partial class calcvol : Form
    {
        public calcvol()
        {
            InitializeComponent();
        }

        //mm
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                uint width = uint.Parse(textBox1.Text) * 10;
                uint length = uint.Parse(textBox2.Text) * 10;
                uint height = uint.Parse(textBox3.Text) * 10;
                uint volume = width * length * height;

                label4.Text = "직육면체 가로: " + width.ToString() + "mm\n"
                    + "세로: " + length.ToString() + "mm\n"
                    + "높이: " + height.ToString() + "mm\n"
                    + "부피: " + volume.ToString() + "mm^3";
            }

            catch(Exception ex)
            {
                label4.Text = ex.Message + "\n다시 입력해주세요.";
            }
        }

        //cm
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                uint width = uint.Parse(textBox1.Text);
                uint length = uint.Parse(textBox2.Text);
                uint height = uint.Parse(textBox3.Text);
                uint volume = width * length * height;

                label4.Text = "직육면체 가로: " + width.ToString() + "cm\n"
                    + "세로: " + length.ToString() + "cm\n"
                    + "높이: " + height.ToString() + "cm\n"
                    + "부피: " + volume.ToString() + "cm^3";
            }

            catch (Exception ex)
            {
                label4.Text = ex.Message + "\n다시 입력해주세요.";
            }
        }
    


        //m
        private void button2_Click(object sender, EventArgs e)
        {
            try
              {
            uint width = uint.Parse(textBox1.Text) / 10;
            uint length = uint.Parse(textBox2.Text) / 10;
            uint height = uint.Parse(textBox3.Text) / 10;
            uint volume = width * length * height;

            label4.Text = "직육면체 가로: " + width.ToString() + "m\n"
                + "세로: " + length.ToString() + "m\n"
                + "높이: " + height.ToString() + "m\n"
                + "부피: " + volume.ToString() + "m^3";
             }

        catch (Exception ex)
        {
            label4.Text = ex.Message + "\n다시 입력해주세요.";
        }
    }


        //exit
        private void button5_Click(object sender, EventArgs e)
        {
          label4.Text = "결과가 표시되는 곳입니다!\n입력값은 프로그램에서 cm으로 인식됩니다.";
        }
    }
}


