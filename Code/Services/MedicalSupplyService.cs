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
      
        private MedicalSupplyRepository _medicalSupplyRepository;

        public MedicalSupplyService(MedicalSupplyRepository medicalSupplyRepository)
        {
            this._medicalSupplyRepository = medicalSupplyRepository;
        }

        internal List<MedicalSupply> GetAll()
            => _medicalSupplyRepository.GetAll();

        internal MedicalSupply Get(int id)
            => _medicalSupplyRepository.Get(id);

        internal MedicalSupply Update(MedicalSupply medicalSupply)
            => _medicalSupplyRepository.Update(medicalSupply);

        internal MedicalSupply Add(MedicalSupply medicalSupply)
            => _medicalSupplyRepository.Add(medicalSupply);

        internal MedicalSupply Remove(int id)
            => _medicalSupplyRepository.Remove(id);
    }
}