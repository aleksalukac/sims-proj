// File:    MedicalSupplyController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:39:18 PM
// Purpose: Definition of Class MedicalSupplyController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class MedicalSupplyController
   {
      public MedicalSupply GetMedicalSupplyByName(string name)
      {
         throw new NotImplementedException();
      }

        private MedicalSupplyService _medicalSupplyService;

        public MedicalSupplyController(MedicalSupplyService medicalSupplyService1)
        {
            this._medicalSupplyService = medicalSupplyService1;
        }
    }
}