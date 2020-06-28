// File:    Notification.cs
// Author:  Aleksa
// Created: Tuesday, May 26, 2020 8:04:21 PM
// Purpose: Definition of Class Notification

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Notification : BaseModel
   {
        private const string ID_PATH = @"..\..\Data\NotificationId.txt";
        public Notification() : base(ID_PATH)
        {

        }
        public string Text { get; set; }
        public DateTime Date { get; set; }
      
        public int User { get; set; }
   
   }
}