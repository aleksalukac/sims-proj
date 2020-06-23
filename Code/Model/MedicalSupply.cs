// File:    MedicalSupply.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class MedicalSupply

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class MedicalSupply : BaseModel
   {
        private const string ID_PATH = @"..\..\Data\MedicalSupplyId.txt";
        public MedicalSupply() : base(ID_PATH)
        {

        }

        public string Name { get; set; }
        public int Count { get; set; }
   
   }
}