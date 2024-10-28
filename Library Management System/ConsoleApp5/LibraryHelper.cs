using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
     public static class LibraryHelper
    {
        public static int CalculateAge(this LibraryItem item)
        {
            if (item != null)
            {
                return DateTime.Now.Year - item.PublicationYear.Value;

            }
            else
            {
                return 0;
            }
        }
        public static string ToTitleCase(this LibraryItem item)
        {
            if ( item.Title==null)
            {
                return string.Empty; 
            }

            
            return char.ToUpper(item.Title[0]) + item.Title.Substring(1).ToLower();

        }
    }
}
