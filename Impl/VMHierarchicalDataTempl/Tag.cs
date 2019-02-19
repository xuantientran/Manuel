using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuel
{
	public class Tag : INode
	{
		List<INode> _children;
		string _title;
		INode _parent;
		object _obj;
		List<Document> _documents;
		public Tag(string title, INode parent)
		{
			_title = title;
			_parent = parent;
			_children = new List<INode>();
			_documents = new List<Document>();
		}
		public object Obj { get => _obj; set => _obj = value; }
		public string Title { get => _title; }
		public INode Parent { get => _parent; }
		public List<INode> Children => _children;

		public List<Document> Documents => _documents;
	}
}
