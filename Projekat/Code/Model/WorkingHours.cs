// File:    WorkingHours.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class WorkingHours

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class WorkingHours
   {
        public WorkingHours(int start, int end)
        {
            this.StartingHour = new TimeSpan(start, 0, 0);
            this.EndingHour = new TimeSpan(end, 0, 0);
        }

        public TimeSpan StartingHour { get; set; }
        public TimeSpan EndingHour { get; set; }
   
   }
}