using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
     public  class DVD : LibraryItem 
    {
        public DVD (string title , int? publicationyear) :base (title, publicationyear) { }
        public override void DisplayInfo()
        {
            Console.WriteLine($"DVD - nin adi {Title}, DVD -nin yazilma tarixi {PublicationYear}");
        }
    }
}
