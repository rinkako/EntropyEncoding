using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ToGray
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
		/// 载入图片
		/// </summary>
		private void button1_Click(object sender, EventArgs e)
		{
			FileDialog fwindow = new OpenFileDialog();
			fwindow.Filter = "bmp文件|*.bmp";
			if (fwindow.ShowDialog() == DialogResult.OK)
			{
				Buffering(fwindow.FileName);
				button4.Enabled = true; 
				groupBox2.Text = "源图像：" + fwindow.FileName + "(" + Convert.ToString(bmpData.Width) + "*" + Convert.ToString(bmpData.Height) + ")";
			}
		}
		
		/// <summary>
		/// 将图片字节发送给后台去处理
		/// </summary>
		private void Buffering(string fname)
		{
			bmp = new Bitmap(Image.FromFile(fname));
			bmpData = bmp.LockBits(new Rectangle(Point.Empty, bmp.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
			buffer = new byte[bmpData.Stride * bmpData.Height];
			Marshal.Copy(bmpData.Scan0, buffer, 0, buffer.Length);
			bmp.UnlockBits(bmpData);
			mainPicture.Image = bmp;
			Services.GetInstance().passData(buffer, bmpData);
		}

		/// <summary>
		/// 按钮：灰度化
		/// </summary>
		private void button4_Click(object sender, EventArgs e)
		{
			Services.GetInstance().GrayConvert();
			(new Form2()).ShowDialog();
		}

		/// <summary>
		/// 图像对象
		/// </summary>
		private Bitmap bmp;

		/// <summary>
		/// 图像字节包装
		/// </summary>
		private BitmapData bmpData;

		/// <summary>
		/// 图像字节数组
		/// </summary>
		private byte[] buffer;
	}
}
