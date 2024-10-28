using System.Globalization;

namespace ConsoleApp3
{
   
    class Listİnt
    {

        private int[] nums; 
        public int this[int i]
        {
            get => nums[i];
            set => nums[i] = value;
        }


        public void Add()
        {
           // burda reqem daxil edirik
        }
        public void Add(params int[] nums)
        {
            // burdada array resize vasitesile
        }
        public bool Contains(int num)
        {
            // 5 gonderilib varsa true yoxdursa false {1,2,3,4,5}
            //Console.WriteLine("eded daxil edin");
            //Console.WriteLine("----------------------");
            //int number = int.Parse(Console.ReadLine());
             bool musa= false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (num == nums[i])
                {
                    musa = true;
                    break;
                } 
                
            }
            return musa;
        }
        public int Pop()
        {
            // resize vasitesile arrayin sonuncu elementini sil
            for (int i = 0; i < nums.Length; i++)
                
                nums[nums.Length - 1] = 0;
            return nums.Length - 1;
        }
        public void Sum()
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)

            {
                sum += nums[i];

            }
        }
        //public override string ToString()
        //{

        //}
    }
}
