using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XMLGenerator
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// 窗体构造函数
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			this.coreTree = new XMLTree();
        }

		/// <summary>
		/// 按钮：添加新节点
		/// </summary>
		private void button3_Click(object sender, EventArgs e)
		{
			// 检查非空
			if (this.textBox1.Text.Trim() == "")
			{
				MessageBox.Show("请输入非空的节点名字");
				return;
			}
			// 前端添加
			if (this.treeView1.SelectedNode != null)
			{
				this.treeView1.SelectedNode.Nodes.Add(this.textBox1.Text);
			}
			// 提交到后台
			List<int> path = this.GetPath(this.treeView1.SelectedNode);
			this.coreTree.Add(path, this.textBox1.Text);
			// 展开视图
			this.treeView1.ExpandAll();
			this.treeView1.SelectedNode = this.treeView1.Nodes[0];
			this.textBox1.Text = "";
		}

		/// <summary>
		/// 按钮：删除节点
		/// </summary>
		private void button2_Click(object sender, EventArgs e)
		{
			// 可行性
			if (this.treeView1.SelectedNode.Level == 0)
			{
				MessageBox.Show("不能删除文档的根节点");
				return;
			}
			// 更新前端
			var path = this.GetPath(this.treeView1.SelectedNode);
			var ridx = this.treeView1.SelectedNode.Index;
            this.treeView1.SelectedNode.Parent.Nodes.RemoveAt(ridx);
			// 更新后台
			this.coreTree.Delete(path);
			// 选中根节点
			this.treeView1.SelectedNode = this.treeView1.Nodes[0];
		}

		/// <summary>
		/// 按钮：保存修改
		/// </summary>
		private void button4_Click(object sender, EventArgs e)
		{
			// 可行性
			if (this.textBox2.Text == "")
			{
				MessageBox.Show("请输入非空的节点名字");
				return;
			}
			// 前端修改
			this.treeView1.SelectedNode.Text = this.textBox2.Text;
			// 后台修改
			var path = this.GetPath(this.treeView1.SelectedNode);
			List<KeyValuePair<string, string>> paras = new List<KeyValuePair<string, string>>();
			for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
			{
				string k = this.dataGridView1.Rows[i].Cells[0].Value == null ? "" : this.dataGridView1.Rows[i].Cells[0].Value.ToString();
				string v = this.dataGridView1.Rows[i].Cells[1].Value == null ? "" : this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                paras.Add(new KeyValuePair<string, string>(k, v));
			}
			this.coreTree.Update(path, this.textBox2.Text, paras);
		}

		/// <summary>
		/// 动作：树视图选择项改变
		/// </summary>
		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			// 清掉之前的内容
			this.dataGridView1.Rows.Clear();
			this.textBox2.Text = "";
			// 可行性判断
			if (this.treeView1.SelectedNode == null || this.treeView1.Focused == false)
			{
				this.groupBox1.Enabled = false;
				return;
			}
			else { this.groupBox1.Enabled = true; }
			if (this.treeView1.SelectedNode.Level == 0)
			{
				this.button2.Enabled = false;
			}
			else
			{
				this.button2.Enabled = true;
			}
			// 获取当前节点的参数信息
			var path = this.GetPath(this.treeView1.SelectedNode);
			var node = this.coreTree.Get(path);
			// 刷新前台信息
			this.textBox2.Text = node.NodeName;
			for (int i = 0; i < node.Parameters.Count; i++)
			{
				var idx = this.dataGridView1.Rows.Add();
				this.dataGridView1[0, idx].Value = node.Parameters[i].Key;
				this.dataGridView1[1, idx].Value = node.Parameters[i].Value;
			}
		}

		/// <summary>
		/// 获取路径描述向量
		/// </summary>
		/// <param name="fNode">要获取的节点</param>
		/// <returns>路径下标描述向量</returns>
		private List<int> GetPath(TreeNode fNode)
		{
			List<int> path = new List<int>();
			TreeNode iterNode = fNode;
			while (iterNode.Parent != null)
			{
				path.Insert(0, iterNode.Index);
				iterNode = iterNode.Parent;
			}
			return path;
		}

		// 后台树的实例
		private XMLTree coreTree;
	}
}
