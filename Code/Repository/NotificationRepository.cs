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
        public static Notification SetNotification(Notification notification)
        {
            List<Notification> notifications = GetAllNotification();

            for (int i = 0; i < notifications.Count; i++)
            {
                if (notifications[i].Id == notification.Id)
                {
                    notifications[i] = notification;
                    break;
                }
            }

            WriteAllNotification(notifications);

            return notification;
        }

        public static Notification GetNotification(int id)
        {
            List<Notification> notifications = GetAllNotification();

            foreach (Notification notification in notifications)
            {
                if (notification.Id == id)
                    return notification;
            }

            return null;
        }

        public static Notification RemoveNotification(int id)
        {
            List<Notification> notifications = GetAllNotification();

            Notification notificationToRemove = notifications.SingleOrDefault(r => r.Id == id);

            if (notificationToRemove != null)
            {
                notifications.Remove(notificationToRemove);
                WriteAllNotification(notifications);
            }

            return notificationToRemove;
        }

        public static Notification AddNotification(Notification notification)
        {
            List<Notification> notifications = GetAllNotification();
            notifications.Add(notification);
            WriteAllNotification(notifications);

            return notification;
        }

        public static List<Notification> GetAllNotification()
        {
            string notificationsSerialized = System.IO.File.ReadAllText(@"..\..\Data\NotificationData.txt"); //notificationPath

            List<Notification> notifications = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Notification>>(notificationsSerialized);

            return notifications;
        }


        public static void WriteAllNotification(List<Notification> notifications)
        {
            string notificationsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(notifications);

            System.IO.File.WriteAllText(@"..\..\Data\NotificationData.txt", notificationsSerialized);
        }

    }
}