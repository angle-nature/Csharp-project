using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string constStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#项目\WindowsFormsApp3\Database1.mdf;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            //创建连接
            SqlConnection con = new SqlConnection(constStr);
            con.Open();
            //查询表里已有记录
            string name = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            //查询sql语句
            string sql = string.Format("select * from utable where uName=N'{0}'", name); //查用户名
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read()) //用户名正确
            {
                if (reader.GetString(2) == password)
                    MessageBox.Show("登录成功！");
                else
                    MessageBox.Show("密码错误！");
            }
            else
                MessageBox.Show("用户名错误！");
            reader.Close();
            con.Close();
        }

    }
}
