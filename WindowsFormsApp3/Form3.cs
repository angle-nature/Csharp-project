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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string constStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#项目\WindowsFormsApp3\Database1.mdf;Integrated Security=True";
        DataSet ds = null;
        private void Form3_Load(object sender, EventArgs e)
        {
            //创建连接
            SqlConnection con = new SqlConnection(constStr);
            string sql = "select * from utable";
            //创建数据集 1.能读能写
            ds = new DataSet();
            //创建数据适配器
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            //Fill() 打开链接 执行sql语句并把结果填充到数据集中 然后关闭链接
            sda.Fill(ds);
            //控件绑定
            dataGridView1.DataSource = ds.Tables[0];

        }

        //数据集的基本操作 
        void init()
        {
            //创建数据集，内存中数据库
            DataSet ds = new DataSet("schcoolds");
            //创建数据表
            DataTable dt = new DataTable("students");
            //字段-列
            DataColumn dc = new DataColumn("name");
            //列添加到表里面
            dt.Columns.Add(dc);
            dc = new DataColumn("age");  //字段-列
            dt.Columns.Add(dc); //表的列集合添加字段
            //表的结构创建完：两个字段：name、age
            //添加数据-行
            DataRow dr = dt.NewRow();
            dr["name"] = "admin";
            dr["age"] = 19;
            //行添加到表中
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["name"] = "user";
            dr["age"] = 18;
            dt.Rows.Add(dr);
            //表添加到数据集中
            ds.Tables.Add(dt);
            //给dataGridView1控件绑定数据源
            dataGridView1.DataSource = ds.Tables["students"]; //数据集里的students表
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //如果用户修改了数据集中的数据
            //修改能提交到数据库中
            SqlConnection con = new SqlConnection(constStr);
            string sql = "select Id,uName,password,gender from utable";
            //准备数据适配器
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            //SqlCommandBuilder 自动生成Sql语句
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            //执行增删改
            sda.Update(ds.Tables[0]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //获取用户从文本框里输入的用户名
            string name = textBox1.Text.Trim();
            //获取用户从文本框里输入的密码
            string gender = textBox2.Text.Trim();
            string sql= "select * from utable where 1=1"; //1=1 永真表达式 方便分别查询用户名和密码
            if(name!=null&&name!="")           
                sql = sql + " and uName = N'" + name + "'" ;
            if (gender != null && gender != "")
                sql = sql + " and gender = N'" + gender + "'";
            SqlConnection con = new SqlConnection(constStr);
            DataSet ds = new DataSet();
            //创建数据适配器
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
