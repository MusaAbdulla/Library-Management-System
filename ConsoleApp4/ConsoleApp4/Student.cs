using System.Runtime.CompilerServices;

namespace ConsoleApp4
{
    class Student
    {
        public Student(string firstname, string lastname, string email, string phonenumber, double gpa, string major)
        {

            firstname = FirstName;
            lastname = LastName;
            email = Email;
            gpa = Gpa;
            major = Major;
            phonenumber = Phonenumber;


        }
        private Student std;
        private string _id;
        public string Id
        {
            get { return _id; }


        }
        private string _firstname;
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }

        }
        private string _lastname;
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _phonenumber;
        public string Phonenumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }
        private double _gpa;
        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }
        private StudentStatus _status;
        public StudentStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private string _major;
        public string Major
        {
            get { return _major; }
            set { _major = value; } // Ixtisas

        }
        public Student GetStudentById(int id)
        {
            int ID = 155155;
            return std;
        }

        //public Student[] GetAllStudent()
        //{
        //    return ;
        //}
        //public Student[] GetStudentByName(string name)
        //{
        //    return 
        //}
        //public void AddStudent(Student student);
        //public void UpdateStudent(int id);
        //public void RemoveStudent(int id, bool isSoftDelete);
    }
}
