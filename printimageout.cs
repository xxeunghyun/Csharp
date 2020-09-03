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
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                label1.Image = Properties.Resources.자동차__1_;
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                label1.Image = Properties.Resources.자동차__2_;
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                label1.Image = Properties.Resources.자동차__3_;
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                label1.Image = Properties.Resources.자동차__4_;
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                label1.Image = Properties.Resources.자동차__5_;
            }
        }
    }
}
