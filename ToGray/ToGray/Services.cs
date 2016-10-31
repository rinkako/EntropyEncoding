using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ToGray
{
	/// <summary>
	/// 控制器类
	/// </summary>
	internal class Services
	{
		/// <summary>
		/// 灰度化
		/// </summary>
		public void GrayConvert()
		{
			int lineBytes = (bitmapData.Width * 8 + 31) / 32 * 4;
			int biSizeImage = 3 * lineBytes * bitmapData.Height;
			GrayPool = new byte[biSizeImage];
			int k = 0, j;
			Array.Clear(GrayPool, 0, GrayPool.Length);
			for (j = 0; j < biSizeImage; j += 3)
			{
				int red = pBmpData[j];
				int green = pBmpData[j + 1];
				int blue = pBmpData[j + 2];
				byte gray = Convert.ToByte((77 * red + 151 * green + 28 * blue) >> 8);
				GrayPool[k] = GrayPool[k + 1] = GrayPool[k + 2] = gray;
				k += 3;
			}
		}

		/// <summary>
		/// 从前台传输数据到后台的方法
		/// </summary>
		/// <param name="originalBuffer">原图像的像素值</param>
		/// <param name="originalData">原图像的头部</param>
		public void passData(byte[] originalBuffer, BitmapData originalData)
		{
			bitmapData = originalData;
			pBmpData = new byte[originalBuffer.Length];
			originalBuffer.CopyTo(pBmpData, 0);
		}

		/// <summary>
		/// 从后台传输数据到前台的方法
		/// </summary>
		/// <param name="outputImage">用于存储返回图片的引用</param>
		public void passOut(ref Bitmap outputImage)
		{
			Bitmap bp = new Bitmap(bitmapData.Width, bitmapData.Height);
			BitmapData bpData = bp.LockBits(new Rectangle(Point.Empty, bp.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			Marshal.Copy(GrayPool, 0, bpData.Scan0, GrayPool.Length);
			bp.UnlockBits(bpData);
			outputImage = bp;
		}

		/// <summary>
		/// 工厂方法：获得类的唯一实例
		/// </summary>
		public static Services GetInstance()
		{
			return Services.SyncObj;
		}

		/// <summary>
		/// 私有的构造器
		/// </summary>
		private Services() { }

		/// <summary>
		/// 图像的字节流
		/// </summary>
		private BitmapData bitmapData { get; set; }

		/// <summary>
		/// 灰度化结果池
		/// </summary>
		private byte[] GrayPool;

		/// <summary>
		/// 源图字节池
		/// </summary>
		private byte[] pBmpData;

		/// <summary>
		/// 唯一实例
		/// </summary>
		private static readonly Services SyncObj = new Services();
	}
}
