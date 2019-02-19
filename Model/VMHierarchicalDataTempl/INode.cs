using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuel
{
	public interface INode
	{
		string Title { get; }
		object Obj { get; set; }
		INode Parent { get; }
		List<INode> Children { get; }
		List<Document> Documents { get; }
	}
}
