// File:    MedicalExamRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:29:51 AM
// Purpose: Definition of Class MedicalExamRepository

using Model; using System; using System.Collections.Generic;

namespace Repository
{
   public class MedicalExamRepository
   {
      public MedicalExam SetMedicalExam(MedicalExam medicalExam)
      {
         throw new NotImplementedException();
      }
      
      public MedicalExam GetMedicalExam(int id)
      {
         throw new NotImplementedException();
      }
      
      public MedicalExam RemoveMedicalExam(int id)
      {
         throw new NotImplementedException();
      }

        public MedicalExam AddMedicalExam(MedicalExam medicalExam)
        {
            List<MedicalExam> medicalExams = GetAllMedicalExam();
            medicalExams.Add(medicalExam);
            WriteAllMedicalExam(medicalExams);

            return medicalExam;

        }
        public static void WriteAllMedicalExam(List<MedicalExam> medicalExams)
        {
            string medicalExamsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(medicalExams);

            System.IO.File.WriteAllText(@"..\..\Data\MedicalExamData.txt", medicalExamsSerialized);
        }

        public static List<MedicalExam> GetAllMedicalExam()
        {
            string medicalExamsSerialized = System.IO.File.ReadAllText(@"..\..\Data\MedicalExamData.txt");

            List<MedicalExam> medicalExams = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MedicalExam>>(medicalExamsSerialized);

            return medicalExams;
        }


    }
}