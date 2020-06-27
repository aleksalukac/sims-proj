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
        private MedicalSupplyService _medicalSupplyService;

        public MedicalSupplyController(MedicalSupplyService medicalSupplyService1)
        {
            this._medicalSupplyService = medicalSupplyService1;
        }

        public List<MedicalSupply> GetAll()
        {
            return _medicalSupplyService.GetAll();
        }

        public MedicalSupply Get(int id)
        {
            return _medicalSupplyService.Get(id);
        }

        public MedicalSupply Update(MedicalSupply medicalSupply)
        {
            return _medicalSupplyService.Update(medicalSupply);
        }

        public MedicalSupply Add(MedicalSupply medicalSupply)
        {
            return _medicalSupplyService.Add(medicalSupply);
        }

        public MedicalSupply Remove(MedicalSupply medicalSupply)
        {
            return _medicalSupplyService.Remove(medicalSupply.Id);
        }
    }
}