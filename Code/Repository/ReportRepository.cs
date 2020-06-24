// File:    ReportRepository.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:11:09 PM
// Purpose: Definition of Class ReportRepository

using Model; using System; using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class ReportRepository
   {
        public static Report Update(Report report)
        {
            List<Report> reports = GetAll();

            for (int i = 0; i < reports.Count; i++)
            {
                if (reports[i].Id == report.Id)
                {
                    reports[i] = report;
                    break;
                }
            }

            WriteAll(reports);

            return report;
        }

        public static Report Get(int id)
        {
            List<Report> reports = GetAll();

            foreach (Report report in reports)
            {
                if (report.Id == id)
                    return report;
            }

            return null;
        }

        public static Report Remove(int id)
        {
            List<Report> reports = GetAll();

            Report reportToRemove = reports.SingleOrDefault(r => r.Id == id);

            if (reportToRemove != null)
            {
                reports.Remove(reportToRemove);
                WriteAll(reports);
            }

            return reportToRemove;
        }

        public static Report Add(Report report)
        {
            List<Report> reports = GetAll();
            reports.Add(report);
            WriteAll(reports);

            return report;
        }

        public static List<Report> GetAll()
        {
            string reportsSerialized = System.IO.File.ReadAllText(@"..\..\Data\ReportData.txt"); //reportPath

            List<Report> reports = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Report>>(reportsSerialized);

            return reports;
        }


        public static void WriteAll(List<Report> reports)
        {
            string reportsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(reports);

            System.IO.File.WriteAllText(@"..\..\Data\ReportData.txt", reportsSerialized);
        }

    }
}