using Core.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Managers
{
    public class StudentManager
    {
        private List<Student> student = new List<Student>();

        public void Add(Student student_)
        {
            student.Add(student_);
        }

        public List<Student> GetAll() 
        {
            return student;
        }

        public List<Student> GetByName(string name)
        {
            return student.Where(x => x.Name == name).ToList();
        }
    }
}
