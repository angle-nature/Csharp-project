using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = File.OpenRead(@"E:\C#项目\WindowsFormsApp4\aaa.txt");
            StreamReader sr = new StreamReader(fs);

            string s;
            string[] str = new string[2]; 
            while ((s=sr.ReadLine())!=null)
            {
                str = s.Split('，');
                listBox1.Items.Add(str[0]);
                listBox2.Items.Add(str[1]);
            }

            sr.Close();
            fs.Close();
        }
    }
}
