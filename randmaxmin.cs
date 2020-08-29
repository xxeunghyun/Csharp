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
    public partial class randomavg : Form
    {
        public randomavg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int i;
            int[] array = new int[10];
            System.Random randata = new System.Random();
            int max=0,min=100; 

            for(i=0;i<10;i++)
            {
                array[i] = randata.Next(100);

            }

            label1.Text = "";

            //or max=array[0], min=array[0] here
            for(i=0;i<10;i++)
            {
                label1.Text += " iarray[" + i.ToString() + "] = " + array[i].ToString() + "        ";


                //max = array[i];

                if (max < array[i])
                    max = array[i];

                if (min > array[i])
                    min = array[i];

                if (i%2 != 0)
                {
                    label1.Text += '\n';
                }

               
            }

            label1.Text += "\n\n10개 원소 배열값의 최대값은 " + max.ToString() + "이고, \n최소값은 "+min.ToString()+"입니다.";
        }
    }
}
