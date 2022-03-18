using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = File.OpenRead(@"E:\C#项目\WindowsFormsApp2\电影名单.txt");
            StreamReader sr = new StreamReader(fs);
            string str;

            while ((str=sr.ReadLine())!=null)
            {
                listBox1.Items.Add(str);
            }

            sr.Close();
            fs.Close();

            //数据绑定

            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat("Tom", 2));
            cats.Add(new Cat("Jarry", 1));
            cats.Add(new Cat("Trum", 3));

            //锁定数据源
            //listBox3.Items.AddRange(cats.ToArray());
            listBox3.DataSource = cats;  //数据源
            //只能显示属性 不能显示字段
            listBox3.DisplayMember = "Name";


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获得被选中的项
            string str = listBox1.SelectedItem.ToString();
            MessageBox.Show("您选的影片是：" + str);
        }
    }
}
