// File:    ReportRepository.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:11:09 PM
// Purpose: Definition of Class ReportRepository

using Model; using System; using System.Collections.Generic;

namespace Repository
{
   public class ReportRepository
   {
      public Report SetReport(Report report)
      {
         throw new NotImplementedException();
      }
      
      public Report GetReport(int id)
      {
         throw new NotImplementedException();
      }
      
      public Report AddReport(int report)
      {
         throw new NotImplementedException();
      }

        public static void WriteAllReport(List<Report> reports)
        {
            string reportsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(reports);

            System.IO.File.WriteAllText(@"..\..\Data\ReportData.txt", reportsSerialized);
        }

        public static List<Report> GetAllReport()
        {
            string reportsSerialized = System.IO.File.ReadAllText(@"..\..\Data\ReportData.txt");

            List<Report> reports = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Report>>(reportsSerialized);

            return reports;
        }

    }
}