using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DCT
{
	public partial class ReDCTForm : Form
	{
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="resList">要输出的结果字符串向量</param>
		public ReDCTForm(List<string> resList)
		{
			InitializeComponent();
			if (resList.Count != 4)
			{
				throw new ArgumentException();
			}
			this.input_textBox1.Text = resList[0];
			this.input_textBox2.Text = resList[1];
			this.input_textBox3.Text = resList[2];
			this.input_textBox4.Text = resList[3];
		}
	}
}
