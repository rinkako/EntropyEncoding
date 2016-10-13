using System;
using System.Collections.Generic;
using System.Text;

namespace EntropyEncoding
{
	/// <summary>
	/// 算术编码器类
	/// </summary>
	class ArithmeticEncoder
	{
		/// <summary>
		/// 设置前端UI的引用
		/// </summary>
		/// <param name="syncUI">窗体引用</param>
		public static void SetUIContext(Form1 syncUI)
		{
			ArithmeticEncoder.UIContext = syncUI;
		}

		/// <summary>
		/// 构造器
		/// </summary>
		/// <param name="pattern">要处理的串</param>
		public ArithmeticEncoder(string pattern)
		{
			this.code = pattern;
			this.symbolTable = new List<AENode>();
			this.symbolDict = new Dictionary<char, int>();
		}

		/// <summary>
		/// 生成符号表
		/// </summary>
		public void GenerateSymbolTable()
		{
			// 统计次数
			int totalTimes = this.code.Length;
			Dictionary<char, int> timesDict = new Dictionary<char, int>();
			foreach (var cc in this.code)
			{
				if (timesDict.ContainsKey(cc))
				{
					timesDict[cc]++;
				}
				else
				{
					timesDict[cc] = 1;
				}
            }
			// 构造符号表
			foreach (var kvp in timesDict)
			{
				AENode node = new AENode()
				{
					symbol = kvp.Key,
					P = (double)kvp.Value / (double)totalTimes
				};
				this.symbolTable.Add(node);
            }
			// 字母排序并分配区间
			this.symbolTable.Sort((x, y) => x.symbol > y.symbol ? 1 : (x.symbol < y.symbol ? -1 : 0));
			double basePointer = 0.0f;
			for (int i = 0; i < this.symbolTable.Count; i++)
			{
				var node = this.symbolTable[i];
                node.X = basePointer;
				node.Y = basePointer + node.P;
				basePointer = node.Y;
				this.symbolDict[node.symbol] = i;
			}
			// 画到前端
			var symbolUI = ArithmeticEncoder.UIContext.output_textbox_math_symbols;
			symbolUI.Text = String.Empty;
			foreach (var node in this.symbolTable)
			{
				symbolUI.Text += String.Format("{0} {1} -> [{2},{3})" + Environment.NewLine,
					node.symbol, node.P.ToString("0.000"), node.X.ToString("0.000"), node.Y.ToString("0.000"));
			}
		}

		/// <summary>
		/// 编码串
		/// </summary>
		/// <param name="orgStr">要编码的内容</param>
		public void Encode(string orgStr)
		{
			StringBuilder sb = new StringBuilder("i\tl\t\tr\t\td" + Environment.NewLine);
			double l = 0f, r = 1f, d = 1f;
			sb.AppendLine(String.Format("{0}\t{1}\t{2}\t{3}", 0, l.ToString("0.000000000000"), r.ToString("0.000000000000"), d));
			for (int i = 1; i <= this.code.Length; i++)
			{
				char c = this.code[i - 1];
				double orgL = l;
				l = orgL + d * this.symbolTable[this.symbolDict[c]].X;
				r = orgL + d * this.symbolTable[this.symbolDict[c]].Y;
				d = r - l;
				sb.AppendLine(String.Format("{0}\t{1}\t{2}\t{3}", i, l.ToString("0.000000000000"), r.ToString("0.000000000000"), d));
			}
			// 更新UI
			ArithmeticEncoder.UIContext.output_textbox_math_encoded.Text = l.ToString();
			ArithmeticEncoder.UIContext.output_textbox_math_encodeproc.Text = sb.ToString();
		}

		/// <summary>
		/// 解码串
		/// </summary>
		/// <param name="orgNum">要解码的数字</param>
		/// <param name="len">长度</param>
		public void Decode(double orgNum, int len)
		{
			StringBuilder procsb = new StringBuilder("j\tv\t\ti\tc" + Environment.NewLine);
			StringBuilder resb = new StringBuilder();
			double v = orgNum;
			int encounter = 1;
			while (encounter <= len) {
				int i = this.LayIn(v);
				if (i == -1)
				{
					break;
				}
				var inode = this.symbolTable[i];
				char c = inode.symbol;
				var orgV = v;
				v = (double)(orgV - inode.X) / (double)inode.P;
				procsb.AppendLine(String.Format("{0}\t{1}\t{2}\t{3}", encounter, orgV.ToString("0.000000000000"), i, c));
				encounter++;
				resb.Append(c);
			}
			// 更新UI
			ArithmeticEncoder.UIContext.output_textbox_math_decoded.Text = resb.ToString();
			ArithmeticEncoder.UIContext.output_textbox_math_decodeproc.Text = procsb.ToString();
		}

		/// <summary>
		/// 判断数字落在哪个符号表的哪一项中
		/// </summary>
		/// <param name="num">要判断的数</param>
		/// <returns>符号表下标</returns>
		private int LayIn(double num)
		{
			for (int i = 0; i < this.symbolTable.Count; i++)
			{
				var node = this.symbolTable[i];
				if (node.X - num <= 1e-7 && node.Y - num > 1e-7 )
				{
					return i;
				}
			}
			return -1;
		}
		
		/// <summary>
		/// 符号表
		/// </summary>
		private List<AENode> symbolTable;

		/// <summary>
		/// 符号表字典
		/// </summary>
		private Dictionary<char, int> symbolDict;

		/// <summary>
		/// 主窗体的引用
		/// </summary>
		private static Form1 UIContext;

		/// <summary>
		/// 要处理的串
		/// </summary>
		private string code = String.Empty;

		/// <summary>
		/// 符号表记录
		/// </summary>
		private class AENode
		{
			/// <summary>
			/// 节点的符号
			/// </summary>
			public char symbol = '#';
			/// <summary>
			/// 出现概率
			/// </summary>
			public double P = 0.0f;
			/// <summary>
			/// 下边界
			/// </summary>
			public double X = 0.0f;
			/// <summary>
			/// 上边界
			/// </summary>
			public double Y = 0.0f;
		}
	}
}
