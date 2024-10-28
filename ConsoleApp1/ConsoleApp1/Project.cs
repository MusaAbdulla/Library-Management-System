using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Project
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Employee[] employees;
        

        private DateTime _starttime;
        public DateTime StartTime
        {
            get { return _starttime; }
            set { _starttime = value; }
        }  
         
        private DateTime _deadline;
        public DateTime DeadLine
        {
            get { return _deadline; }
            set { _deadline = value; }
        }
        private bool _isSuccesfull;
        public bool IsSuccesfull
        {
            get { return _isSuccesfull; }
            set { _isSuccesfull = value; }

        }
        public Project(int id, bool issuccesfull, DateTime stratttime, DateTime deadline)
        {
            employees = new Employee[0];

        }
        public void AssignEmployee(Employee employee)
        {

        }
        public void RemoveEmployee()
        {

        }
        public void Finish()
        {
            StartTime = DateTime.Now;
            Console.WriteLine("MM/dd/yyyy");
            DeadLine = DateTime.Now ;
        }
        public void Print()
        {

        }

    }
}
