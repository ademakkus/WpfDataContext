using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataContext
{
	class Student
	{
		public string FirstName { get; set; }
		public string SureName { get; set; }
		public int Age { get; set; }
	public string Departmant { get; set; }

		public Student(string firstname,string surename,int age,string departmant) //constructor snippet is ctor
		{
			FirstName = firstname;
			SureName = surename;
			Age = age;
			Departmant = departmant;
		}

	}
}
