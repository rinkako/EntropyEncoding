using System;
using System.Collections.Generic;
using System.Text;

namespace DCT
{
	/// <summary>
	/// 亮度量化器
	/// </summary>
	class LuminanceQuantisationer
	{
		/// <summary>
		/// 构造器
		/// </summary>
		public LuminanceQuantisationer(Mat2D<double> DCTedMat)
		{
			this.ProcMat = DCTedMat.Clone();
            this.ResMat = new Mat2D<int>(this.FilterSize, this.FilterSize);
			this.RequanMat = new Mat2D<double>(this.FilterSize, this.FilterSize);
		}

		/// <summary>
		/// 获取亮度量化矩阵内容的字符串
		/// </summary>
		/// <returns>亮度量化矩阵的对应字符串</returns>
		public string GetLuminousString()
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.ResMat.Height; i++)
			{
				sb.Append(String.Format("{0}", this.ResMat.Get(0, i)));
				for (int j = 1; j < this.ResMat.Width; j++)
				{
					sb.Append(String.Format(" {0}", this.ResMat.Get(j, i)));
				}
				sb.Append(Environment.NewLine);
			}
			return sb.ToString();
		}

		/// <summary>
		/// 获取反量化矩阵内容的字符串
		/// </summary>
		/// <returns>反量化矩阵的对应字符串</returns>
		public string GetReLuminousString()
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.RequanMat.Height; i++)
			{
				sb.Append(String.Format("{0}", this.RequanMat.Get(0, i)));
				for (int j = 1; j < this.RequanMat.Width; j++)
				{
					sb.Append(String.Format(" {0}", this.RequanMat.Get(j, i)));
				}
				sb.Append(Environment.NewLine);
			}
			return sb.ToString();
		}

		/// <summary>
		/// 执行量化过程
		/// </summary>
		public void Luminous()
		{
			for (int i = 0; i < this.ProcMat.Height; i++)
			{
				for (int j = 0; j < this.ProcMat.Width; j++)
				{
					this.ResMat.Set(j, i, this.CalculateSQ(j, i));
				}
			}
		}
		
		/// <summary>
		/// 执行反量化过程
		/// </summary>
		public void Reluminous()
		{
			// 计算反量化矩阵
			for (int i = 0; i < this.ResMat.Height; i++)
			{
				for (int j = 0; j < this.ResMat.Width; j++)
				{
					this.RequanMat.Set(j, i, this.ResMat.Get(j, i) * this.LuminanceFilter[i, j]);
				}
			}
		}

		/// <summary>
		/// 获取反量化矩阵
		/// </summary>
		/// <returns>反量化矩阵的引用</returns>
		public Mat2D<double> GetRelumiousMat()
		{
			return this.RequanMat;
		}

		/// <summary>
		/// 计算SQ值
		/// </summary>
		/// <param name="x">维度坐标一</param>
		/// <param name="y">维度坐标二</param>
		/// <returns>量化结果</returns>
		private int CalculateSQ(int x, int y)
		{
			return (int)Math.Round(this.ProcMat.Get(x, y) / this.LuminanceFilter[y, x]);
		}
		
		/// <summary>
		/// 计算矩阵
		/// </summary>asdf9faw
		private Mat2D<double> ProcMat;

		/// <summary>
		/// 量化结果矩阵
		/// </summary>
		private Mat2D<int> ResMat;
		
		/// <summary>
		/// 反量化系数矩阵
		/// </summary>
		private Mat2D<double> RequanMat;

		/// <summary>
		/// 量化器尺寸
		/// </summary>
		private readonly int FilterSize = 8;

		/// <summary>
		/// 标准亮度量化表
		/// </summary>
		private readonly int[,] LuminanceFilter = {
			{ 17, 18, 24, 47, 99, 99, 99, 99 },
			{ 18, 21, 26, 66, 99, 99, 99, 99 },
			{ 24, 26, 56, 99, 99, 99, 99, 99 },
			{ 47, 66, 99, 99, 99, 99, 99, 99 },
			{ 99, 99, 99, 99, 99, 99, 99, 99 },
			{ 99, 99, 99, 99, 99, 99, 99, 99 },
			{ 99, 99, 99, 99, 99, 99, 99, 99 },
			{ 99, 99, 99, 99, 99, 99, 99, 99 }
		};

		/// <summary>
		/// 标准亮度量化表
		/// </summary>
		//private readonly int[,] DeltaFilter = {
		//	{16, 11, 10, 16, 24,  40,  51,  61},
		//	{12, 12, 14, 19, 26,  58,  60,  55},
		//	{14, 13, 16, 24, 40,  57,  69,  56},
		//	{14, 17, 22, 29, 51,  87,  80,  62},
		//	{18, 22, 37, 56, 68,  109, 103, 77},
		//	{24, 35, 55, 64, 81,  104, 113, 92},
		//	{49, 64, 78, 87, 103, 121, 120, 101},
		//	{72, 92, 95, 98, 112, 100, 103, 99}
		//};
    }
}
