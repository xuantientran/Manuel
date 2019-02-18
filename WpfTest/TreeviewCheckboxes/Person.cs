using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfTest
{
	public class Person : DependencyObject
	{
		public string Name { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
