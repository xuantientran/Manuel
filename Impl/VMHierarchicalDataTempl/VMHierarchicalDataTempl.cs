using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Manuel
{

	public class VMHierarchicalDataTempl : INotifyPropertyChanged
	{
		ObservableCollection<INode> _tags;
		INode _tag;

		public VMHierarchicalDataTempl()
		{
			INode tag;
			INode tagA1;
			INode tagB1;
			INode tagA2;
			INode tagB2;
			_tags = new ObservableCollection<INode>();

			INode tagA = new Tag("A", null);
			tagA.Documents.Add(new Document { Name = "roman" });
			_tags.Add(tagA);
			tagA1 = new Tag("A1", tagA);
			tagA.Children.Add(tagA1);
			INode tagA1A = new Tag("A1A", tagA1);
			tagA1.Children.Add(tagA1A);
			tag = new Tag("A1A1", tagA1A);
			tagA1A.Children.Add(tag);

			tag = new Tag("A1B", tagA1);
			tagA1.Children.Add(tag);

			tagA2 = new Tag("A2", tagA);
			tagA.Children.Add(tagA2);
			tag = new Tag("A2A", tagA2);
			tagA2.Children.Add(tag);
			tag = new Tag("A2B", tagA2);
			tagA2.Children.Add(tag);

			INode tagB = new Tag("B", null);
			_tags.Add(tagB);
			tagB1 = new Tag("B1", tagB);
			tagB.Children.Add(tagB1);
			tagB2 = new Tag("B2", tagB);
			tagB.Children.Add(tagB2);
			tag = new Tag("B2B", tagB2);
			tagB2.Children.Add(tag);
		}

		public INode Tag
		{
			get => _tag;
			set
			{
				_tag = value;
				RaiseProperChanged();
			}
		}

		public ObservableCollection<INode> Tags
		{
			get => _tags;
			set
			{
				_tags = value;
				RaiseProperChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaiseProperChanged([CallerMemberName] string propertyName = "")
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
