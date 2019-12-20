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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDataContext
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Student[] student ={
				new Student("Adem","Akkuş",35,"Information Technologies"),
				new Student("Furkan","Akkuş",10,"Secondary School"),
				new Student("Ayşenur","Akkuş",10,"Primary School"),
				new Student("Gülten","Akkuş",35,"Trukish Literature")
			};
			Grid grd = new Grid();
			grd.DataContext = student;
			cmbName.ItemsSource = student;
			Binding firstNameBinding = new Binding("FirstName");
			txtFirstName.SetBinding(ContentProperty, firstNameBinding);
			///
			Binding sureNameBinding = new Binding("SureName");
			txtSureName.SetBinding(ContentProperty, sureNameBinding);
			///
			Binding ageBinding = new Binding("Age");
			txtAge.SetBinding(ContentProperty, ageBinding);
			///
			Binding departmantNameBinding = new Binding("Departmant");
			txtDepartmant.SetBinding(ContentProperty, departmantNameBinding);
		}
	}
}
