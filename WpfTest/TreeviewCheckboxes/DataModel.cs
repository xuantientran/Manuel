using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfTest
{
	public class DataModel
	{
		public class Family : DependencyObject
		{
			public string Name { get; set; }
			public List<Person> Members { get; set; }
		}

		public class Person : DependencyObject
		{
			public string Name { get; set; }
		}
	}
}
