using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EntropyEncoding
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// 构造器
		/// </summary>
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 按钮：哈夫曼刷新
		/// </summary>
		private void button1_Click(object sender, EventArgs e)
		{
			HuffmanEncoder.SetUIContext(this);
			HuffmanEncoder.Get(this.input_textbox_huffman_pattern.Text);
		}
	}
}
