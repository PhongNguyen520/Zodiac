using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ConversationService : IConversationService
    {
        private readonly IConversationRepository _iConversationRepository;  
        
        public ConversationService(ConversationRepository iConversationRepository)
        {
            _iConversationRepository = iConversationRepository;
        }
        public bool AddConversation(Conversation conversation)
        {
            return _iConversationRepository.AddConversation(conversation);
        }

        public bool DelConversations(int id)
        {
            return _iConversationRepository.DelConversations(id);
        }

        public List<Conversation> GetConversations()
        {
            return _iConversationRepository.GetConversations();
        }

        public bool UpdateConversations(Conversation conversation)
        {
            return _iConversationRepository.UpdateConversations(conversation);
        }
    }
}
