using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ITutorRepository
    {
        public bool AddTutor(Tutor tutor);

        public bool DelTutors(int id);

        public List<Tutor> GetTutors();

        public bool UpdateTutors(Tutor tutor);
    }
}

