// File:    Renovation.cs
// Author:  Aleksa
// Created: Friday, May 29, 2020 11:02:09 PM
// Purpose: Definition of Class Renovation

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Renovation : BaseModel
   {
        private const string ID_PATH = @"..\..\Data\RenovationId.txt";
        public Renovation() : base(ID_PATH)
        {

        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public RenovationType RenovationType { get; set; }

    }
}