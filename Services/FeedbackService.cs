using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository iFeedbackRepository = null;

        public FeedbackService()
        {
            if (iFeedbackRepository == null)
            {
                iFeedbackRepository = new FeedbackRepository();
            }
        }
        public bool AddFeedback(Feedback feedback)
        {
            return iFeedbackRepository.AddFeedback(feedback);
        }

        public bool DelFeedbacks(int id)
        {
            return iFeedbackRepository.DelFeedbacks(id);
        }

        public List<Feedback> GetFeedbacks(string id)
        {
            return iFeedbackRepository.GetFeedbacks(id);
        }

        public bool UpdateFeedbacks(Feedback feedback)
        {
            return iFeedbackRepository.UpdateFeedbacks(feedback);
        }
    }
}
