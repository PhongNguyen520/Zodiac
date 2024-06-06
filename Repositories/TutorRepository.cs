using BusinessObjects;
using DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TutorRepository : ITutorRepository
    {
        private readonly TutorDAO tutorDAO = null;

        public TutorRepository()
        {
            if (tutorDAO == null)
            {
                tutorDAO = new TutorDAO();
            }
        }


        public bool AddTutor(Tutor tutor)
        {
            return tutorDAO.AddTutor(tutor);
        }

        public bool DelTutors(int id)
        {
            return tutorDAO.DelTutors(id);
        }

        public List<Tutor> GetTutors()
        {
            return tutorDAO.GetTutors();
        }

        public List<Subject> GetTutor(string id)
        {
            return tutorDAO.GetTutors(id);
        }

        public bool UpdateTutors(Tutor tutor)
        {
            return tutorDAO.UpdateTutors(tutor);
        }
    }
}
