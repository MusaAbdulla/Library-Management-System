using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Car
    {
        public int Id { get; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int EngineCode { get; set; }
       public static bool operator >(Car car1,Car car2)
        {
            return car1.Year>car2.Year;
        }
        public static bool operator <(Car car1, Car car2)
        {
            return car1.Year < car2.Year; 
        }
        

    }
}
