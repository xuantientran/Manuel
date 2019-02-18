using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Manuel
{
	/// <summary>
	/// Simple base class that provides a solid implementation
	/// of the <see cref="INotifyPropertyChanged"/> event including
	/// reflection-based property name verification in debug builds.
	/// </summary>
	public abstract class SimpleObject : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void RaiseProperChanged([CallerMemberName] string propertyName = "")
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}