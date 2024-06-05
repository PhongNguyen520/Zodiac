using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GradeService : IGradeService
    {
        private readonly IGradeRepository _gradeRepository;   

        public GradeService(GradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }
    
        public bool AddGrade(Grade grade)
        {
            return _gradeRepository.AddGrade(grade);
        }

        public bool DelGrades(int id)
        {
            return _gradeRepository.DelGrades(id);
        }

        public List<Grade> GetGrades()
        {
            return _gradeRepository.GetGrades();
        }

        public bool UpdateGrades(Grade grade)
        {
            return _gradeRepository.UpdateGrades(grade);
        }
    }
}
