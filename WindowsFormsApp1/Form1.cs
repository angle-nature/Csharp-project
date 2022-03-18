using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string str in d.Keys)
            {
                if (str == textBox1.Text)
                {
                    textBox2.Text = d[str];   
                    break;
                }
            }

            if (!d.ContainsKey(textBox1.Text))
                textBox2.Text = "没有找到该单词翻译!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //初始化操作
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;  //背景色换为粉色
            
            foreach (string str in System.IO.File.ReadAllLines("英汉词典.txt", Encoding.Default))
            {  
                //StringSplitOptions.RemoveEmptyEntries  移除空字符串
                string[] word = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //查询是否有相同键值
                if (!d.ContainsKey(word[0]))
                    d.Add(word[0], word[1]);
                else
                    d[word[0]] = d[word[0]] + word[1];
            }
        }
        private Dictionary<String, String> d = new Dictionary<string, string>();  //创建字典
    }
}
