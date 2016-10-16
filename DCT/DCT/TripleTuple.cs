using System;
using System.Collections.Generic;
using System.Text;

namespace DCT
{
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
