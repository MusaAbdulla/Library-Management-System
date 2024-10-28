using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal interface IStudentService
    {

        public Student GetStudentById(int id);
        public Student[] GetAllStudent();
        public Student[] GetStudentByName(string name);
        public void AddStudent(Student student);
        public void UpdateStudent(int id);
        public void RemoveStudent(int id, bool isSoftDelete);
         
    }
}
