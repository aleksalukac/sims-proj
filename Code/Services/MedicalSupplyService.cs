// File:    MedicalSupplyService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 3:26:25 PM
// Purpose: Definition of Class MedicalSupplyService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class MedicalSupplyService
   {
      public MedicalSupply GetMedicalSupplyByName(string name)
      {
         throw new NotImplementedException();
      }
      
        private MedicalSupplyRespository _medicalSupplyRepository;

        public MedicalSupplyService(MedicalSupplyRespository medicalSupplyRepository)
        {
            this._medicalSupplyRepository = medicalSupplyRepository;
        }
    }
}