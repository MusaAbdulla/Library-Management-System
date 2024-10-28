using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
     static class Extension
     {
        public static int  OrderByYear( this carsyears)
        {
            int[] newcarsyears = new int[carsyears.Length];
            int n = carsyears.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (carsyears[j] > carsyears[j + 1])
                    {
                       
                        int temp = carsyears[j];
                        carsyears[j] = carsyears[j + 1];
                        carsyears[j + 1] = temp;
                    }
                }
            }

           
        }

     }
}
