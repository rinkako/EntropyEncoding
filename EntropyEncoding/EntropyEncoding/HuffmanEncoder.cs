using System;
using System.Collections.Generic;
using System.Text;

namespace EntropyEncoding
{
	/// <summary>
	/// 哈夫曼编码类
	/// </summary>
	class HuffmanEncoder
	{
		public static void SetUIContext(Form1 syncUI)
		{
			HuffmanEncoder.UIContext = syncUI;
		}

		/// <summary>
		/// 获取指定格式串的哈夫曼树
		/// </summary>
		/// <param name="pattern">以symbol1@time1;symbol2@time2;...格式编码的串</param>
		public static void Get(string pattern)
		{
			// preprocess
			var lineItem = pattern.Split(';');
			int totalTimes = 0;
			List<KeyValuePair<int, string>> symbolTable = new List<KeyValuePair<int, string>>();
			Dictionary<string, ResultTreeNode> resultTable = new Dictionary<string, ResultTreeNode>();
			foreach (var symbolPair in lineItem)
			{
				var symbolItem = symbolPair.Split('@');
				int time = Convert.ToInt32(symbolItem[1]);
                var kvp = new KeyValuePair<int, string>(time, symbolItem[0]);
				symbolTable.Add(kvp);
				ResultTreeNode node = new ResultTreeNode(symbolItem[0], null, null, null);
				node.Time = time;
				resultTable.Add(symbolItem[0], node);
				totalTimes += time;
            }
			foreach (var node in resultTable)
			{
				node.Value.P = (double)node.Value.Time / (double)totalTimes;
            }
			// loop to consturct
			while (symbolTable.Count != 1)
			{
				symbolTable.Sort((x, y) => { return x.Key > y.Key ? 1 : ((x.Key < y.Key) ? -1 : 0); });
				var dashKvp = new KeyValuePair<int, string>(symbolTable[0].Key + symbolTable[1].Key, symbolTable[0].Value + symbolTable[1].Value);
				var leftNode = resultTable[symbolTable[0].Value];
				var rightNode = resultTable[symbolTable[1].Value];
				var dashNode = new ResultTreeNode(dashKvp.Value, null, leftNode, rightNode);
				dashNode.Time = leftNode.Time + rightNode.Time;
				dashNode.P = leftNode.P + rightNode.P;
                leftNode.Parent = rightNode.Parent = dashNode;
				resultTable.Add(dashKvp.Value, dashNode);
				symbolTable.RemoveAt(0);
				symbolTable.RemoveAt(0);
				symbolTable.Add(dashKvp);
			}
			// find root
			ResultTreeNode root = null;
			foreach (var kvp in resultTable)
			{
				if (kvp.Value.Parent == null)
				{
					root = kvp.Value;
					break;
                }
			}
			// draw tree
			if (root != null)
			{
				var treeview = UIContext.res_treeview_huffman_tree;
				treeview.Nodes.Clear();
				recursiveDrawTree(root, null, treeview);
                treeview.ExpandAll();
			}
		}

		private static void recursiveDrawTree(ResultTreeNode root, System.Windows.Forms.TreeNode viewNodeParent, System.Windows.Forms.TreeView tv)
		{
			if (root != null)
			{
				System.Windows.Forms.TreeNode retNode;
                if (viewNodeParent == null)
				{
					retNode = tv.Nodes.Add(root.Code + "(" + root.P.ToString("0.000") + ")");
                }
				else
				{
					retNode = viewNodeParent.Nodes.Add(root.Code + "(" + root.P.ToString("0.000") + ")");
				}
				recursiveDrawTree(root.ChildLeft, retNode, tv);
				recursiveDrawTree(root.ChildRight, retNode, tv);
			}
		}

		/// <summary>
		/// 主窗体的引用
		/// </summary>
		private static Form1 UIContext;

		/// <summary>
		/// 哈夫曼树节点类
		/// </summary>
		private class ResultTreeNode
		{
			/// <summary>
			/// 构造器
			/// </summary>
			/// <param name="code">该节点的子串</param>
			/// <param name="parent">父节点</param>
			/// <param name="L">左子节点</param>
			/// <param name="R">右子节点</param>
			public ResultTreeNode(string code, ResultTreeNode parent, ResultTreeNode L, ResultTreeNode R)
			{
				this.Code = code;
				this.Parent = parent;
				this.ChildLeft = L;
				this.ChildRight = R;
			}

			/// <summary>
			/// 节点上的串
			/// </summary>
			public string Code = String.Empty;
			/// <summary>
			/// 节点出现概率
			/// </summary>
			public double P = 0.0f;
			/// <summary>
			/// 节点出现次数
			/// </summary>
			public int Time = 0;
			/// <summary>
			/// 父节点引用
			/// </summary>
			public ResultTreeNode Parent = null;
			/// <summary>
			/// 左孩子节点引用
			/// </summary>
			public ResultTreeNode ChildLeft = null;
			/// <summary>
			/// 右孩子节点引用
			/// </summary>
			public ResultTreeNode ChildRight = null;
		}
	}
}
