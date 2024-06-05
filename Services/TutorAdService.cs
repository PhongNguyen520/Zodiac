using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TutorAdService : ITutorAdService
    {
        private readonly ITutorAdRepository _repository;

        public TutorAdService(TutorAdRepository repository)
        {
            _repository = repository;
        }

        public bool AddTutorAd(TutorAd tutorAd)
        {
            return _repository.AddTutorAd(tutorAd);
        }

        public bool DelTutorAds(int id)
        {
            return _repository.DelTutorAds(id);
        }

        public List<TutorAd> GetTutorAds()
        {
            return _repository.GetTutorAds();
        }

        public bool UpdateTutorAds(TutorAd tutorAd)
        {
            return _repository.UpdateTutorAds(tutorAd);
        }
    }
}
