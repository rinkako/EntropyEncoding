using System;
using System.Collections.Generic;
using System.Text;

namespace XMLGenerator
{
	/// <summary>
	/// XML树的节点类
	/// </summary>
	[Serializable]
	internal class XMLTreeNode
	{
		// 节点名称
		public string NodeName;
		// 父节点
		public XMLTreeNode Parent;
		// 子节点列表
		public List<XMLTreeNode> Children;
		// 参数列表
		public List<KeyValuePair<string, string>> Parameters;
	}
}
