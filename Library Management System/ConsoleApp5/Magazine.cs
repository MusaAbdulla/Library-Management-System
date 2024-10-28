using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
     public class Magazine: LibraryItem
    {
        public Magazine (string title, int? publicationyear) : base(title, publicationyear) { }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazanin adi {Title}, Magazanin yaranma ili {PublicationYear}");
        }
    }
}
