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
			HuffmanEncoder.SetUIContext(this);
			ArithmeticEncoder.SetUIContext(this);
		}

		/// <summary>
		/// 按钮：哈夫曼刷新
		/// </summary>
		private void button1_Click(object sender, EventArgs e)
		{
			HuffmanEncoder.Get(this.input_textbox_huffman_pattern.Text);
		}

		/// <summary>
		/// 按钮：生成符号表
		/// </summary>
		private void button4_Click(object sender, EventArgs e)
		{
			ae = new ArithmeticEncoder(this.input_textbox_math_pattern.Text);
			ae.GenerateSymbolTable();
		}
		
		/// <summary>
		/// 按钮：算术编码
		/// </summary>
		private void button2_Click(object sender, EventArgs e)
		{
			ae.Encode(this.input_textbox_math_pattern.Text);
		}

		/// <summary>
		/// 按钮：算术解码
		/// </summary>
		private void button3_Click(object sender, EventArgs e)
		{
			ae.Decode(Convert.ToDouble(textBox2.Text), Convert.ToInt32(textBox1.Text));
		}

		/// <summary>
		/// 算术编码器实例
		/// </summary>
		private ArithmeticEncoder ae;
	}
}
