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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            //创建连接对象
            SqlConnection con = new SqlConnection(constStr); //或不传参数 con.ConnectionString = constStr;
            try
            {
                con.Open();
                MessageBox.Show("成功连接！");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();  //关闭连接
                MessageBox.Show("连接关闭！");
            }
        }

        string constStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#项目\WindowsFormsApp3\Database1.mdf;Integrated Security=True";

        private void button2_Click(object sender, EventArgs e)
        {
            //创建连接
            SqlConnection con = new SqlConnection(constStr);
            //创建command对象
            SqlCommand command = new SqlCommand();
            //sql语句
            string sql = "insert into utable(uName,password) values(N'Tom',1234567)";
            command.CommandText = sql;
            command.Connection = con;
            //执行
            con.Open();
            int n = command.ExecuteNonQuery();
            MessageBox.Show("修改了" + n.ToString()+"行");
            //关闭连接
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //创建连接
            SqlConnection con = new SqlConnection(constStr);
            //sql语句-统计表里有多少条记录
            string sql = "select count(*) from utable";
            SqlCommand command = new SqlCommand(sql, con);
            con.Open();
            int n=Convert.ToInt32(command.ExecuteScalar());
            MessageBox.Show(n.ToString());
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //创建连接
            SqlConnection con = new SqlConnection(constStr);
            //查询sql语句
            string sql = "select * from utable";
            SqlCommand command = new SqlCommand(sql, con);
            con.Open();
            //SqlDataReader 读取器 只读只进
            SqlDataReader reader =command.ExecuteReader();

            listBox1.Items.Clear();
            //listBox1.Items.Add("用户名\t密码");
            int i = 1;
            while (reader.Read())
            {
                //SqlDataReader 有 get 方法
                string uname = reader.GetString(1); //表中的第1列  第0列是 id
                //索引返回的是object类型
                string password = reader["password"].ToString();  //[]索引里可放表里的字段 也可放列数
                listBox1.Items.Add("编号："+(i++)+"\t用户名："+uname+"\t密码："+password);
            }
            reader.Close();
            con.Close();

        }
    }
}
