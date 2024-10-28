using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        private int _id;
        public int Id 
        { 
            get { return _id; }
            set { _id = value; }
        }
        private string _fullname;
        public string FullName
        { 
            get { return _fullname; }
            set { _fullname = value; }
        }
        Project[] projects=new Project[0];
        public Employee(int id ,string fullname)
        {
            projects=new Project[0];
        }
        public void Leave()
        {

        }
    }
}
