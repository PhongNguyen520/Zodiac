using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TutorService : ITutorService
    {
        private readonly ITutorRepository _repository;

        public TutorService()
        {
            _repository = new TutorRepository();
        }

        public bool AddTutor(Tutor tutor)
        {
            return _repository.AddTutor(tutor);
        }

        public bool DelTutors(int id)
        {
            return _repository.DelTutors(id);
        }

        public List<Subject> GetTutor(string id)
        {
            return _repository.GetTutor(id);
        }

        public List<Tutor> GetTutors()
        {
            return _repository.GetTutors();
        }

        public bool UpdateTutors(Tutor tutor)
        {
            return _repository.UpdateTutors(tutor);
        }
    }
}
