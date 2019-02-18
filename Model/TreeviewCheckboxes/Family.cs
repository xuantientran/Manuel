using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Manuel
{
	public class Family : DependencyObject, IParent<object>
	{
		public string Name { get; set; }
		public List<Person> Members { get; set; }

		IEnumerable<object> IParent<object>.GetChildren()
		{
			return Members;
		}
	}
}
