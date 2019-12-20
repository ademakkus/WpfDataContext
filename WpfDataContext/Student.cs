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
		/// <summary>
		/// Student class constructor, it takes four parameters
		/// </summary>
		/// <param name="firstname">string student First name</param>
		/// <param name="surename"> string student sure name</param>
		/// <param name="age">integer student age</param>
		/// <param name="departmant">string student departmant</param>
		public Student(string firstname,string surename,int age,string departmant) //constructor snippet is ctor
		{
			FirstName = firstname;
			SureName = surename;
			Age = age;
			Departmant = departmant;
		}

	}
}
