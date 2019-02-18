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
		ObservableCollection<INode> _children;
		string _title;
		INode _parent;
		object _obj;
		public Tag(string title, INode parent)
		{
			_title = title;
			_parent = parent;
			_children = new ObservableCollection<INode>();
		}
		public object Obj { get => _obj; set => _obj = value; }
		public string Title { get => _title; }
		public INode Parent { get => _parent; }
		public ObservableCollection<INode> Children => _children;
	}
}
