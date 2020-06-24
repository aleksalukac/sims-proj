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
        private const string MEDICAL_EXAM_FILE = @"..\..\Data\MedicalExamData.txt";

        public  MedicalExam Update(MedicalExam medicalExam)
        {
            List<MedicalExam> medicalExams = GetAll();

            for (int i = 0; i < medicalExams.Count; i++)
            {
                if (medicalExams[i].Id == medicalExam.Id)
                {
                    medicalExams[i] = medicalExam;
                    break;
                }
            }

            WriteAll(medicalExams);

            return medicalExam;
        }

        public  MedicalExam Get(int id)
        {
            List<MedicalExam> medicalExams = GetAll();

            foreach (MedicalExam medicalExam in medicalExams)
            {
                if (medicalExam.Id == id)
                    return medicalExam;
            }

            return null;
        }

        public  MedicalExam Remove(int id)
        {
            List<MedicalExam> medicalExams = GetAll();

            MedicalExam medicalExamToRemove = medicalExams.SingleOrDefault(r => r.Id == id);

            if (medicalExamToRemove != null)
            {
                medicalExams.Remove(medicalExamToRemove);
                WriteAll(medicalExams);
            }

            return medicalExamToRemove;
        }

        public  MedicalExam Add(MedicalExam medicalExam)
        {
            if (Get(medicalExam.Id) == null)
            {
                List<MedicalExam> medicalExams = GetAll();
                medicalExams.Add(medicalExam);
                WriteAll(medicalExams);

                return medicalExam;
            }
            return null;
        }

        public  List<MedicalExam> GetAll()
        {
            string medicalExamsSerialized = System.IO.File.ReadAllText(MEDICAL_EXAM_FILE); //medicalExamPath

            List<MedicalExam> medicalExams = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MedicalExam>>(medicalExamsSerialized);

            return medicalExams;
        }


        public  void WriteAll(List<MedicalExam> medicalExams)
        {
            string medicalExamsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(medicalExams);

            System.IO.File.WriteAllText(MEDICAL_EXAM_FILE, medicalExamsSerialized);
        }


    }
}