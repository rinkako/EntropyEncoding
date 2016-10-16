using System;
using System.Collections.Generic;
using System.Text;

namespace DCT
{
	class DCTTransformer
	{
		/// <summary>
		/// 构造函数
		/// </summary>
		public DCTTransformer()
		{
			this.ProcMat = new Mat2D<double>(this.FilterSize, this.FilterSize);
			this.DCTMat = new Mat2D<double>(this.FilterSize, this.FilterSize);
			this.ReDCTMat = new Mat2D<double>(this.FilterSize, this.FilterSize);
			this.ReResMat = new Mat2D<int>(this.FilterSize, this.FilterSize);
		}

		/// <summary>
		/// 获取DCT矩阵内容的字符串
		/// </summary>
		/// <returns>DCT矩阵的对应字符串</returns>
		public string GetDCTString()
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.DCTMat.Height; i++)
			{
				sb.Append(String.Format("{0}", this.DCTMat.Get(0, i).ToString("0.0")));
				for (int j = 1; j < this.DCTMat.Width; j++)
				{
					sb.Append(String.Format(" {0}", this.DCTMat.Get(j, i).ToString("0.0")));
				}
				sb.Append(Environment.NewLine);
			}
			return sb.ToString();
		}

		/// <summary>
		/// 获取反向计算结果矩阵内容的字符串
		/// </summary>
		/// <returns>反向计算出源图矩阵的对应字符串</returns>
		public string GetReDCTString()
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.ReResMat.Height; i++)
			{
				sb.Append(String.Format("{0}", this.ReResMat.Get(0, i)));
				for (int j = 1; j < this.ReResMat.Width; j++)
				{
					sb.Append(String.Format(" {0}", this.ReResMat.Get(j, i)));
				}
				sb.Append(Environment.NewLine);
			}
			return sb.ToString();
		}

		/// <summary>
		/// 为矩阵设置值
		/// </summary>
		/// <param name="x">X坐标</param>
		/// <param name="y">Y坐标</param>
		/// <param name="v">该坐标的值</param>
		public void SetMat(int x, int y, double v)
		{
			this.ProcMat.Set(x, y, v);
		}

		/// <summary>
		/// 设置要反向计算的矩阵
		/// </summary>
		/// <param name="mat">待处理矩阵</param>
		public void SetReMat(Mat2D<double> mat)
		{
			this.ReDCTMat = mat.Clone();
		}

		/// <summary>
		/// 获取DCT矩阵
		/// </summary>
		/// <returns>DCT矩阵的引用</returns>
		public Mat2D<double> GetDCTMat()
		{
			return this.DCTMat;
		}

		/// <summary>
		/// 获取反向计算DCT得到源图矩阵
		/// </summary>
		/// <returns>源图矩阵的引用</returns>
		public Mat2D<double> GetReDCTMat()
		{
			return this.ReDCTMat;
		}

		/// <summary>
		/// 预处理，减128动作
		/// </summary>
		public void Preprocess()
		{
			this.ProcMat.AllColRow((x) => this.ProcMat.Set(x.A, x.B, x.C - 128));
		}

		/// <summary>
		/// 逆转预处理，加128动作
		/// </summary>
		public void Postprocess()
		{
			this.ReResMat.AllColRow((x) => this.ReResMat.Set(x.A, x.B, x.C + 128));
		}

		/// <summary>
		/// 计算正向离散余弦变换
		/// </summary>
		public void DCT()
		{
			this.ProcMat.AllColRow((x) => this.DCTMat.Set(x.A, x.B, this.CalculateDCT(x.A, x.B)));
		}

		/// <summary>
		/// 逆运算正向离散余弦变换
		/// </summary>
		public void ReDCT()
		{
			this.ReDCTMat.AllColRow((x) => this.ReResMat.Set(x.A, x.B, (int)Math.Round(this.CalculateReDCT(x.A, x.B))));
		}

		/// <summary>
		/// 计算单点的DCT值
		/// </summary>
		/// <param name="u">第一维坐标</param>
		/// <param name="v">第二维坐标</param>
		/// <returns>DCT变换的结果</returns>
		private double CalculateDCT(int u, int v)
		{
			double prefix = 0.25f * this.CalculateC(u) * this.CalculateC(v);
			double postfix = 0.0f;
			for (int i = 0; i < this.FilterSize; i++)
			{
				for (int j = 0; j < this.FilterSize; j++)
				{
					postfix += this.ProcMat.Get(i, j) * Math.Cos(((2 * i + 1) * u * Math.PI) / 16.0f) * Math.Cos(((2 * j + 1) * v * Math.PI) / 16.0f);
				}
			}
			return prefix * postfix;
		}

		/// <summary>
		/// 从单点的DCT值反向计算原图值
		/// </summary>
		/// <param name="i">第一维坐标</param>
		/// <param name="j">第二维坐标</param>
		/// <returns>DCT变换的结果</returns>
		private double CalculateReDCT(int i, int j)
		{
			double acc = 0.0f;
			for (int u = 0; u < this.FilterSize; u++)
			{
				for (int v = 0; v < this.FilterSize; v++)
				{
					acc += this.CalculateC(u) * this.CalculateC(v) * this.ReDCTMat.Get(u, v) * Math.Cos(((2 * i + 1) * u * Math.PI) / 16.0f) * Math.Cos(((2 * j + 1) * v * Math.PI) / 16.0f);
				}
			}
			return 0.25f * acc;
		}

		/// <summary>
		/// 计算C系数
		/// </summary>
		/// <param name="w">C系数计算参数</param>
		/// <returns>C系数</returns>
		private double CalculateC(double w)
		{
			if (w < 0) { throw new ArgumentOutOfRangeException(); }
			return w == 0 ? (1.0f / Math.Sqrt(2.0f)) : 1.0f;
		}

		/// <summary>
		/// 处理矩阵
		/// </summary>
		private Mat2D<double> ProcMat;

		/// <summary>
		/// 处理矩阵
		/// </summary>
		private Mat2D<double> DCTMat;

		/// <summary>
		/// 等待反向计算的矩阵
		/// </summary>
		private Mat2D<double> ReDCTMat;

		/// <summary>
		/// 反向计算结果矩阵
		/// </summary>
		private Mat2D<int> ReResMat;

		/// <summary>
		/// 矩阵大小
		/// </summary>
		private readonly int FilterSize = 8;
	}
}
