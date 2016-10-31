using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToGray
{
	public partial class Form2 : Form
	{
		/// <summary>
		/// 构造器
		/// </summary>
		public Form2()
		{
			InitializeComponent();
			Services.GetInstance().passOut(ref preImage);
			previewPicture.Image = preImage;
		}

		/// <summary>
		/// 按钮：另存为
		/// </summary>
		private void button1_Click(object sender, EventArgs e)
		{
			FileDialog fwindow = new SaveFileDialog();
			fwindow.Filter = "bmp文件|*.bmp";
			if (fwindow.ShowDialog() == DialogResult.OK)
			{
				preImage.Save(fwindow.FileName);
			}
		}

		/// <summary>
		/// 要显示的图像字节包装
		/// </summary>
		private Bitmap preImage;
	}
}
