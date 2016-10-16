using System;
using System.Collections.Generic;
using System.Text;

namespace EntropyEncoding
{
	/// <summary>
	/// LZW编码器类
	/// </summary>
	class LZWEncoder
	{
		/// <summary>
		/// LZW编码一段字符串
		/// </summary>
		/// <param name="pattern">待处理字符串</param>
		/// <returns>编码过程</returns>
		public string Encode(string pattern)
		{
			Dictionary<char, int> charDict = new Dictionary<char, int>();
			foreach (var cc in pattern)
			{
				if (charDict.ContainsKey(cc))
				{
					charDict[cc]++;
				}
				else
				{
					charDict[cc] = 1;
				}
			}
			int next = 1;


		}



		private List<LZWNode> symbolTable = new List<LZWNode>();

		private class LZWNode
		{
			public string WC = String.Empty;

			public int next = 0;

			public int output = 0;
		}
	}
}
