using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(MessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public bool AddMessage(Message message)
        {
            return _messageRepository.AddMessage(message);
        }

        public bool DelMessages(int id)
        {
            return _messageRepository.DelMessages(id);
        }

        public List<Message> GetMessages()
        {
            return _messageRepository.GetMessages();
        }

        public bool UpdateMessages(Message message)
        {
            return _messageRepository.UpdateMessages(message);
        }
    }
}
