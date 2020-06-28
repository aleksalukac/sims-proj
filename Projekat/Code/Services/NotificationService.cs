using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_class_diagram.Services
{
    public class NotificationService
    {
        private NotificationRepository _notificationRepository;
        private const string NEW_DRUG_NOTIFICATION_TEXT = "Poslat vam je novi lek na odobravanje";

        public NotificationService(NotificationRepository notificationRepository)
        {
            this._notificationRepository = notificationRepository;
        }

        internal Notification Get(int id)
            => _notificationRepository.Get(id);

        internal Notification AddNewDrugNotification(int drugId, int userId)
        {
            Notification notification = new Notification();
            notification.Date = DateTime.Now;
            notification.User = userId;
            notification.Text = NEW_DRUG_NOTIFICATION_TEXT + " " + drugId.ToString();
            return _notificationRepository.Add(notification);
        }
    }
}
