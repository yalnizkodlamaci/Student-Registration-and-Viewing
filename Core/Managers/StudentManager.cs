using Core.Entitys;
using System;
using System.Windows.Forms;
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

        public void DeleteByName(string name)
        {
            var WillDeleteStudent = student.FirstOrDefault(x => x.Name == name);

            if (WillDeleteStudent != null)
            {
                student.Remove(WillDeleteStudent);
                MessageBox.Show("Öğrenci başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğrenci kayıtlı değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void DeleteAll() 
        {
            student.Clear();
        }
    }
}
