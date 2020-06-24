// File:    NotificationRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:08:41 AM
// Purpose: Definition of Class NotificationRepository

using Model; using System; using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class NotificationRepository
    {
        private const string NOTIFICATION_FILE = @"..\..\Data\NotificationData.txt";

        public NotificationRepository()
        {
            if (!File.Exists(NOTIFICATION_FILE))
            {
                using (StreamWriter sw = File.CreateText(NOTIFICATION_FILE))
                {
                    sw.WriteLine("[]");
                }
            }
        }

        public  Notification Update(Notification notification)
        {
            List<Notification> notifications = GetAll();

            for (int i = 0; i < notifications.Count; i++)
            {
                if (notifications[i].Id == notification.Id)
                {
                    notifications[i] = notification;
                    break;
                }
            }

            WriteAll(notifications);

            return notification;
        }

        public  Notification Get(int id)
        {
            List<Notification> notifications = GetAll();

            foreach (Notification notification in notifications)
            {
                if (notification.Id == id)
                    return notification;
            }

            return null;
        }

        public  Notification Remove(int id)
        {
            List<Notification> notifications = GetAll();

            Notification notificationToRemove = notifications.SingleOrDefault(r => r.Id == id);

            if (notificationToRemove != null)
            {
                notifications.Remove(notificationToRemove);
                WriteAll(notifications);
            }

            return notificationToRemove;
        }

        public  Notification Add(Notification notification)
        {
            if (Get(notification.Id) == null)
            {
                List<Notification> notifications = GetAll();
                notifications.Add(notification);
                WriteAll(notifications);

                return notification;
            }
            return null;
        }

        public  List<Notification> GetAll()
        {
            string notificationsSerialized = System.IO.File.ReadAllText(NOTIFICATION_FILE); //notificationPath

            List<Notification> notifications = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Notification>>(notificationsSerialized);

            return notifications;
        }


        public  void WriteAll(List<Notification> notifications)
        {
            string notificationsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(notifications);

            System.IO.File.WriteAllText(NOTIFICATION_FILE, notificationsSerialized);
        }

    }
}