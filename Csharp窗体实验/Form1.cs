using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp窗体实验
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.Text == "1" || comboBox1.Text == "3" || comboBox1.Text == "5" || 
                comboBox1.Text == "7" || comboBox1.Text == "8" || comboBox1.Text == "10" || comboBox1.Text == "12")
                for (int i = 1; i <= 31; i++)
                    comboBox2.Items.Add(i);
            else if (comboBox1.Text == "2")
                for (int i = 1; i <= 28; i++)
                    comboBox2.Items.Add(i);
            else
                for (int i = 1; i <= 30; i++)
                    comboBox2.Items.Add(i);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "您的生日是："+comboBox1.Text+"月"+comboBox2.Text+"日";
        }


    }
}
