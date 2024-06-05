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
        private readonly IFeedbackRepository _ifeedbackRepository;

        public FeedbackService(FeedbackRepository feedbackRepository)
        {
            _ifeedbackRepository = feedbackRepository;
        }
        public bool AddFeedback(Feedback feedback)
        {
            return _ifeedbackRepository.AddFeedback(feedback);
        }

        public bool DelFeedbacks(int id)
        {
            return _ifeedbackRepository.DelFeedbacks(id);
        }

        public List<Feedback> GetFeedbacks(string id)
        {
            return _ifeedbackRepository.GetFeedbacks(id);
        }

        public bool UpdateFeedbacks(Feedback feedback)
        {
            return _ifeedbackRepository.UpdateFeedbacks(feedback);
        }
    }
}
