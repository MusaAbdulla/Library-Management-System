using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Management_System
{
    public  class Librarian :Person
    {
        public Librarian(DateTime hiredate, int id, string name ): base (id,name)
        {
        
            
        }
        public DateTime HireDate { get; set; }
    }
}
