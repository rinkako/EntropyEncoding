using System;
using System.Collections.Generic;
using System.Text;

namespace DCT
{
	/// <summary>
	/// 二维矩阵
	/// </summary>
	/// <typeparam name="T">矩阵元素类型</typeparam>
	class Mat2D<T>
	{
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="w">矩阵宽度</param>
		/// <param name="h">矩阵高度</param>
		public Mat2D(int w, int h)
		{
			this.container = new T[h, w];
			this.Height = h;
			this.Width = w;
		}

		/// <summary>
		/// 设置矩阵一个槽的值
		/// </summary>
		/// <param name="x">X坐标</param>
		/// <param name="y">Y坐标</param>
		/// <param name="value">值</param>
		public void Set(int x, int y, T value)
		{
			if (x >= 0 && x < this.Width &&
				y >= 0 && y < this.Height)
			{
				this.container[y, x] = value;
			}
			else
			{
				throw new ArgumentOutOfRangeException();
			}
		}

		/// <summary>
		/// 创造此矩阵的一个深拷贝实例
		/// </summary>
		/// <returns>拷贝出来的实例</returns>
		public Mat2D<T> Clone()
		{
			Mat2D<T> resMat = new Mat2D<T>(this.Width, this.Height);
			this.AllRowCol((x) => resMat.Set(x.A, x.B, x.C));
			return resMat;
		}

		/// <summary>
		/// 获取矩阵一个槽的值
		/// </summary>
		/// <param name="x">X坐标</param>
		/// <param name="y">Y坐标</param>
		public T Get(int x, int y)
		{
			if (x >= 0 && x < this.Width &&
				y >= 0 && y < this.Height)
			{
				return this.container[y, x];
			}
			throw new ArgumentOutOfRangeException();
		}
		
		/// <summary>
		/// 先列后行所有元素执行一个动作
		/// </summary>
		/// <param name="act">动作函数，其参数为（X坐标，Y坐标，该元素的值）</param>
		public void AllColRow(Action<TripleTuple<int, int, T>> act)
		{
			for (int i = 0; i < this.Width; i++)
			{
				for (int j = 0; j < this.Height; j++)
				{
					TripleTuple<int, int, T> procTuple = new TripleTuple<int, int, T>(i, j, this.Get(i, j));
					act(procTuple);
				}
			}
        }

		/// <summary>
		/// 先行后列所有元素执行一个动作
		/// </summary>
		/// <param name="act">动作函数，其参数为（X坐标，Y坐标，该元素的值）</param>
		public void AllRowCol(Action<TripleTuple<int, int, T>> act)
		{
			for (int i = 0; i < this.Height; i++)
			{
				for (int j = 0; j < this.Width; j++)
				{
					TripleTuple<int, int, T> procTuple = new TripleTuple<int, int, T>(j, i, this.Get(j, i));
					act(procTuple);
				}
			}
		}

		/// <summary>
		/// 获取矩阵容器的宽度
		/// </summary>
		public int Width { get; private set; }

		/// <summary>
		/// 获取矩阵容器的高度
		/// </summary>
		public int Height { get; private set; }

		/// <summary>
		/// 矩阵容器
		/// </summary>
		private T[,] container;
    }

	/// <summary>
	/// 三元组类型
	/// </summary>
	/// <typeparam name="T1">第一个值类型</typeparam>
	/// <typeparam name="T2">第二个值类型</typeparam>
	/// <typeparam name="T3">第三个值类型</typeparam>
	public class TripleTuple<T1, T2, T3>
	{
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="a">第一个值</param>
		/// <param name="b">第二个值</param>
		/// <param name="c">第三个值</param>
		public TripleTuple(T1 a, T2 b, T3 c)
		{
			this.A = a;
			this.B = b;
			this.C = c;
		}

		/// <summary>
		/// 获取或设置第一个值
		/// </summary>
		public T1 A { get; set; }

		/// <summary>
		/// 获取或设置第二个值
		/// </summary>
		public T2 B { get; set; }

		/// <summary>
		/// 获取或设置第三个值
		/// </summary>
		public T3 C { get; set; }
	}
}
