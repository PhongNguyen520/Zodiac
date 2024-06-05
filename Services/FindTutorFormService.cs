using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FindTutorFormService : IFindTutorFormService
    {
        private readonly IFindTutorFormRepository _repository;
        
        public FindTutorFormService(FindTutorFormRepository repository)
        {
            _repository = repository;
        }
        public bool AddFindTutorForm(FindTutorForm form)
        {
            return _repository.AddFindTutorForm(form);
        }

        public bool DelFindTutorForms(int id)
        {
            return _repository.DelFindTutorForms(id);
        }

        public List<FindTutorForm> GetFindTutorForms()
        {
            return _repository.GetFindTutorForms();
        }

        public bool UpdateFindTutorForms(FindTutorForm form)
        {
            return _repository.UpdateFindTutorForms(form);
        }
    }
}
