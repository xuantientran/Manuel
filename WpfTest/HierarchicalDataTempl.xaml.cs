using Manuel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfTest
{
	/// <summary>
	/// Logique d'interaction pour HierarchicalDataTempl.xaml
	/// </summary>
	public partial class HierarchicalDataTempl : Window
	{
		VMHierarchicalDataTempl _viewModel;
		public HierarchicalDataTempl()
		{
			_viewModel = new VMHierarchicalDataTempl();
			InitializeComponent();
			DataContext = _viewModel;
		}

		private void Tag_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
		{
			var tag = ((TreeView)sender).SelectedItem;
			_viewModel.Tag = (Tag)tag;
		}
	}
}
