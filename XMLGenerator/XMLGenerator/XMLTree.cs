using System;
using System.Collections.Generic;
using System.Text;

namespace XMLGenerator
{
	/// <summary>
	/// XML树类
	/// </summary>
	[Serializable]
	internal class XMLTree
	{
		/// <summary>
		/// 构造函数
		/// </summary>
		public XMLTree()
		{
			this.Root = new XMLTreeNode()
			{
				Children = new List<XMLTreeNode>(),
				NodeName = "XML_Root",
				Parent = null,
				Parameters = new List<KeyValuePair<string, string>>()
			};
		}

		/// <summary>
		/// 添加节点
		/// </summary>
		/// <param name="parentPath">父节点的层次路径</param>
		/// <param name="nodeName">要添加节点的名字</param>
		public void Add(List<int> parentPath, string nodeName)
		{
			XMLTreeNode opNode = this.Get(parentPath);
			opNode.Children.Add(new XMLTreeNode()
			{
				NodeName = nodeName,
				Children = new List<XMLTreeNode>(),
				Parameters = new List<KeyValuePair<string, string>>(),
				Parent = opNode
			});
		}
		
		/// <summary>
		/// 更新节点
		/// </summary>
		/// <param name="path">节点的层次路径</param>
		/// <param name="nodeName">新的节点名字</param>
		/// <param name="paras">新的节点参数列表</param>
		public void Update(List<int> path, string nodeName, List<KeyValuePair<string, string>> paras)
		{
			XMLTreeNode opNode = this.Get(path);
			opNode.NodeName = nodeName;
			opNode.Parameters = paras;
		}

		/// <summary>
		/// 删除节点和她的孩子
		/// </summary>
		/// <param name="path">节点的层次路径</param>
		public void Delete(List<int> path)
		{
			XMLTreeNode opNode = this.Get(path).Parent;
			opNode.Children.RemoveAt(path[path.Count - 1]);
		}

		/// <summary>
		/// 获取指定路径的节点
		/// </summary>
		/// <param name="path">节点的层次路径</param>
		/// <returns>节点实例</returns>
		public XMLTreeNode Get(List<int> path)
		{
			XMLTreeNode opNode = this.Root;
			for (int i = 0; i < path.Count; i++)
			{
				opNode = opNode.Children[path[i]];
			}
			return opNode;
		}

		// 树的根节点
		public XMLTreeNode Root { get; private set; }
	}
}
