namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] carsyears = {2005,1998,2009};
            Car car1 = new Car()
            {
                
                Brand = "BMW",
                Model = "E60",
                Year = 2005,
                EngineCode = 1234554321

            };
            Car car2 = new Car()
            {

                Brand = "Mers",
                Model = "w212",
                Year = 1998,
                EngineCode = 123459876


            };
            Car car3 = new Car()
            {

                Brand = "Audi",
                Model = "Rs6",
                Year = 2009,
                EngineCode = 1234576545

            };
            Console.WriteLine(car1<car3);
            
        }
    }
}
