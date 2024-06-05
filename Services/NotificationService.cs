using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;

        public NotificationService(NotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public bool AddNotification(Notification notification)
        {
            return _notificationRepository.AddNotification(notification);
        }

        public bool DelNotifications(int id)
        {
            return _notificationRepository.DelNotifications(id);
        }

        public List<Notification> GetNotifications()
        {
            return _notificationRepository.GetNotifications();
        }

        public bool UpdateNotifications(Notification notification)
        {
            return _notificationRepository.UpdateNotifications(notification);
        }
    }
}
