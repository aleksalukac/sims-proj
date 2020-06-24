// File:    SecretaryRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:38:55 AM
// Purpose: Definition of Class SecretaryRepository

using Model; using System; using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class SecretaryRepository
    {
        private const string SECRETARY_FILE = @"..\..\Data\SecretaryData.txt";

        public SecretaryRepository()
        {
            if (!File.Exists(SECRETARY_FILE))
            {
                using (StreamWriter sw = File.CreateText(SECRETARY_FILE))
                {
                    sw.WriteLine("");
                }
            }
        }

        public  Secretary Update(Secretary secretary)
        {
            if (Get().Id != secretary.Id)
            {
                return null;
            }

            string secretarySerialized = Newtonsoft.Json.JsonConvert.SerializeObject(secretary);

            System.IO.File.WriteAllText(SECRETARY_FILE, secretarySerialized);

            return Get();
        }

        public Secretary Get(int id)
        {
            if (this.Get().Id == id)
                return this.Get();
            return null;
        }

        public  Secretary Get()
        {
            string secretarySerialized = System.IO.File.ReadAllText(SECRETARY_FILE); 

            Secretary secretary = Newtonsoft.Json.JsonConvert.DeserializeObject<Secretary>(secretarySerialized);

            return secretary;
        }

        public  Secretary Add(Secretary secretary)
        {
            if (!File.Exists(SECRETARY_FILE) || Get() == null)
            {
                string secretarySerialized = Newtonsoft.Json.JsonConvert.SerializeObject(secretary);

                System.IO.File.WriteAllText(SECRETARY_FILE, secretarySerialized);
            }

            return Get();
        }
    }
}