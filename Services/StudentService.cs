using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public bool AddStudent(Student student)
        {
            return _studentRepository.AddStudent(student);
        }

        public bool DelStudents(int id)
        {
            return _studentRepository.DelStudents(id);
        }

        public List<Student> GetStudents()
        {
            return _studentRepository.GetStudents();
        }

        public bool UpdateStudents(Student student)
        {
            return _studentRepository.UpdateStudents(student);
        }
    }
}
