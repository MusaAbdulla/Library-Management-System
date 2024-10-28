using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    sealed  class LibraryMember :Person
        

    {
        public LibraryMember(DateTime membership,int id, string name): base (id,name)
        {
            
        }
        public DateTime MemberShipDate { get; set; }
    }
}
