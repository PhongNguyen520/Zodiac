using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(SubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public bool AddSubject(Subject subject)
        {
            return _subjectRepository.AddSubject(subject);
        }

        public bool DelSubjects(int id)
        {
            return _subjectRepository.DelSubjects(id);
        }

        public List<Subject> GetSubjects()
        {
            return _subjectRepository.GetSubjects();
        }

        public bool UpdateSubjects(Subject subject)
        {
            return _subjectRepository.UpdateSubjects(subject);
        }
    }
}
