// File:    Report.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 2:51:43 PM
// Purpose: Definition of Class Report

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Report : BaseModel
   {
        private const string ID_PATH = @"..\..\Data\ReportId.txt";
        public Report() : base(ID_PATH)
        {

        }

        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public string Name { get; set; }
   
   }
}