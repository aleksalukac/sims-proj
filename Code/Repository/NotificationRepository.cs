// File:    NotificationRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:08:41 AM
// Purpose: Definition of Class NotificationRepository

using Model; using System; using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class NotificationRepository
   {
        public static Notification Update(Notification notification)
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

        public static Notification Get(int id)
        {
            List<Notification> notifications = GetAll();

            foreach (Notification notification in notifications)
            {
                if (notification.Id == id)
                    return notification;
            }

            return null;
        }

        public static Notification Remove(int id)
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

        public static Notification Add(Notification notification)
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

        public static List<Notification> GetAll()
        {
            string notificationsSerialized = System.IO.File.ReadAllText(@"..\..\Data\NotificationData.txt"); //notificationPath

            List<Notification> notifications = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Notification>>(notificationsSerialized);

            return notifications;
        }


        public static void WriteAll(List<Notification> notifications)
        {
            string notificationsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(notifications);

            System.IO.File.WriteAllText(@"..\..\Data\NotificationData.txt", notificationsSerialized);
        }

    }
}