using Manuel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	/// Logique d'interaction pour HeterogeneousTreeView.xaml
	/// </summary>
	public partial class HeterogeneousTreeView : Window
	{
		private ObservableCollection<Farm> farms;

		public HeterogeneousTreeView()
		{
			InitializeComponent();
			Farm farm1 = new Farm { FarmName = "Farm 1" };
			farm1.Farmer = new Person { FirstName = "Joe", LastName = "Miller" };
			farm1.Animals.Add(new Animal("Pigs"));
			farm1.Animals.Add(new Animal("Cows"));
			farm1.Animals.Add(new Animal("Sheep"));
			farm1.Crops.Add(new Plant("Corn"));
			farm1.Crops.Add(new Plant("Wheat"));

			Farm farm2 = new Farm { FarmName = "Farm 2" };
			farm2.Farmer = new Person { FirstName = "Lucy", LastName = "Brown" };
			farm2.Animals.Add(new Animal("Cows"));
			farm2.Animals.Add(new Animal("Sheep"));
			farm2.Crops.Add(new Plant("Wheat"));

			//create farm list and bind to tree
			farms = new ObservableCollection<Farm> { farm1, farm2 };
			farmsTree.ItemsSource = farms;


		}
	}
}
