using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
   public  abstract class Person
     
   
    {
        public Person(int id , string name )
        {
            Name = name;
            Id = id;
        }
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}
