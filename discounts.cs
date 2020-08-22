using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4_discounts
{
    public partial class discounts : Form
    {
        public discounts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(textBox1.Text);
                bool result = age <= 15 || age >= 65;

                label2.Text = "할인여부: " + result.ToString();

            }

            catch(Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
