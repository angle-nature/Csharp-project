using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; //不检测所有控件的跨线程调用
        }

        bool flag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if(!flag)
            {
                flag = true;
                button1.Text = "停止";
                Thread thread = new Thread(test);
                thread.Start();
            }
            else
            {
                flag = false;
                button1.Text = "开始";
            }
        }

        private void test()
        {
            Random random = new Random();
            while (flag)
            {             
                label1.Text = random.Next(9).ToString();
                label2.Text = random.Next(9).ToString();
                label3.Text = random.Next(9).ToString();
            }
        }
    }
}
