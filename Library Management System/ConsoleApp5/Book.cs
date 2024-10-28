using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
  public class Book : LibraryItem
    {
        public string Genre {  get; set; }
        public LibraryLocation LibraryLocation { get; set; }
        public Book(string title, int? publicationyear) : base(title, publicationyear) { }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Kitab Adi {Title} Buraxilis ili {PublicationYear} Janri{Genre} Kitabin yeri{LibraryLocation}");
        }
    }
    
}
