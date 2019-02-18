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
	/// Logique d'interaction pour Test.xaml
	/// </summary>
	public partial class DataTemplate : Window
	{
		StudentViewModel _viewModel;
		public DataTemplate()
		{
			_viewModel = new StudentViewModel();
			DataContext = _viewModel;
			InitializeComponent();
		}
	}

	public class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}

	public class StudentViewModel
	{

		public StudentViewModel()
		{
			LoadStudents();
		}

		public ObservableCollection<Student> Students
		{
			get;
			set;
		}

		public void LoadStudents()
		{
			ObservableCollection<Student> students = new ObservableCollection<Student>();

			students.Add(new Student { FirstName = "Mark", LastName = "Allain" });
			students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
			students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });

			Students = students;
		}
	}
}
