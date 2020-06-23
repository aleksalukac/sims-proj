// File:    Manager.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Manager

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Manager : Employee
   {
        public List<Report> Report { get; set; }
        
   }
}