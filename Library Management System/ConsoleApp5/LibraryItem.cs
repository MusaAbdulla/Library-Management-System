using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
     public abstract  class LibraryItem
    {
        protected LibraryItem(string title,int? publicationyear)
        {
             PublicationYear = publicationyear;
            Title = title;
        }
        public string Title { get; set; }
        public int? PublicationYear { get; set; } 
      public  abstract void DisplayInfo();
    }
}
