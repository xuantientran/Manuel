using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuel
{
	public interface IParent<T>
	{
		IEnumerable<T> GetChildren();
	}
}
