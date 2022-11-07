using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4_AlekseiStepanov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 1;
            label2.Text = "1";
            while (count <= long.Parse(textBox1.Text))
            {
                label2.Text = (long.Parse(label2.Text) * count).ToString();
                count = count + 1;

            }
        }
    }
}