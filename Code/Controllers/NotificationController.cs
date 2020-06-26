using Hospital_class_diagram.Services;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_class_diagram.Controllers
{
    public class NotificationController
    {
        private NotificationService _notificationService;

        public NotificationController(NotificationService service)
        {
            _notificationService = service;
        }

        public Notification Get(int id)
        {
            return _notificationService.Get(id);
        }
    }
}
