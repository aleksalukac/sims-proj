// File:    MedicalExamRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:29:51 AM
// Purpose: Definition of Class MedicalExamRepository

using Model; using System; using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class MedicalExamRepository
   {
        public static MedicalExam SetMedicalExam(MedicalExam medicalExam)
        {
            List<MedicalExam> medicalExams = GetAllMedicalExam();

            for (int i = 0; i < medicalExams.Count; i++)
            {
                if (medicalExams[i].Id == medicalExam.Id)
                {
                    medicalExams[i] = medicalExam;
                    break;
                }
            }

            WriteAllMedicalExam(medicalExams);

            return medicalExam;
        }

        public static MedicalExam GetMedicalExam(int id)
        {
            List<MedicalExam> medicalExams = GetAllMedicalExam();

            foreach (MedicalExam medicalExam in medicalExams)
            {
                if (medicalExam.Id == id)
                    return medicalExam;
            }

            return null;
        }

        public static MedicalExam RemoveMedicalExam(int id)
        {
            List<MedicalExam> medicalExams = GetAllMedicalExam();

            MedicalExam medicalExamToRemove = medicalExams.SingleOrDefault(r => r.Id == id);

            if (medicalExamToRemove != null)
            {
                medicalExams.Remove(medicalExamToRemove);
                WriteAllMedicalExam(medicalExams);
            }

            return medicalExamToRemove;
        }

        public static MedicalExam AddMedicalExam(MedicalExam medicalExam)
        {
            List<MedicalExam> medicalExams = GetAllMedicalExam();
            medicalExams.Add(medicalExam);
            WriteAllMedicalExam(medicalExams);

            return medicalExam;
        }

        public static List<MedicalExam> GetAllMedicalExam()
        {
            string medicalExamsSerialized = System.IO.File.ReadAllText(@"..\..\Data\MedicalExamData.txt"); //medicalExamPath

            List<MedicalExam> medicalExams = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MedicalExam>>(medicalExamsSerialized);

            return medicalExams;
        }


        public static void WriteAllMedicalExam(List<MedicalExam> medicalExams)
        {
            string medicalExamsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(medicalExams);

            System.IO.File.WriteAllText(@"..\..\Data\MedicalExamData.txt", medicalExamsSerialized);
        }


    }
}