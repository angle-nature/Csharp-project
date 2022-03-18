using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //根节点
            TreeNode pNode = new TreeNode("中国");
            //二级节点
            TreeNode cNode1 = new TreeNode("安徽");
            TreeNode cNode2 = new TreeNode("浙江");
            TreeNode cNode3 = new TreeNode("云南");
            //三级节点
            TreeNode cNode1_1 = new TreeNode("马鞍山");
            TreeNode cNode1_2 = new TreeNode("芜湖");
            TreeNode cNode1_3 = new TreeNode("合肥");
            cNode1.Nodes.Add(cNode1_1);
            cNode1.Nodes.Add(cNode1_2);
            cNode1.Nodes.Add(cNode1_3);
            TreeNode cNode2_1 = new TreeNode("杭州");
            TreeNode cNode2_2 = new TreeNode("湖州");
            TreeNode cNode2_3 = new TreeNode("宁波");
            cNode2.Nodes.Add(cNode2_1);
            cNode2.Nodes.Add(cNode2_2);
            cNode2.Nodes.Add(cNode2_3);
            //叶子节点
            cNode1_1.Nodes.Add("雨山湖");
            cNode1_1.Nodes.Add("采石公园");
            cNode1_1.Nodes.Add("濮塘");

            cNode2_1.Nodes.Add("西湖");
            cNode2_1.Nodes.Add("灵隐寺");
            cNode2_1.Nodes.Add("千岛湖");

            cNode3.Nodes.Add("昆明");
            cNode3.Nodes.Add("丽江");
            cNode3.Nodes.Add("普洱");
            //向根节点中添加二级节点
            pNode.Nodes.Add(cNode1);
            pNode.Nodes.Add(cNode2);
            pNode.Nodes.Add(cNode3);
            //向树形控件中添加根节点
            treeView1.Nodes.Add(pNode);
            //初始状态设为展开状态
            //treeView1.ExpandAll(); 
        }
    }
}
