using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int i;
            int[] array = new int[10];
            System.Random randata = new System.Random();
            int sum = 0;
            double avg = 0;


            for(i=0;i<10;i++)
            {
                array[i] = randata.Next(100);

            }

            label1.Text = "";
            for(i=0;i<10;i++)
            {
                label1.Text += " iarray[" + i.ToString() + "] = " + array[i].ToString() + "        ";
                if(i%2 != 0)
                {
                    label1.Text += '\n';
                }

                sum += array[i];
            }
            avg = (double)sum / 10;
            label1.Text += "\n\n10개 원소 배열값의 평균은 " + avg.ToString() + "입니다.";
        }
    }
}
