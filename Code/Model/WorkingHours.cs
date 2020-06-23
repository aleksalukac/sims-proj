// File:    WorkingHours.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class WorkingHours

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class WorkingHours
   {
      public TimeSpan StartingHour { get; set; }
      public TimeSpan EndingHour { get; set; }
   
   }
}