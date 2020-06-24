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
        public static Secretary Update(Secretary secretary)
        {
            if (Get().Id != secretary.Id)
            {
                return null;
            }

            string secretarySerialized = Newtonsoft.Json.JsonConvert.SerializeObject(secretary);

            System.IO.File.WriteAllText(@"..\..\Data\SecretaryData.txt", secretarySerialized);

            return Get();
        }

        public static Secretary Get()
        {
            string secretarySerialized = System.IO.File.ReadAllText(@"..\..\Data\SecretaryData.txt"); 

            Secretary secretary = Newtonsoft.Json.JsonConvert.DeserializeObject<Secretary>(secretarySerialized);

            return secretary;
        }

        public static Secretary Add(Secretary secretary)
        {
            if (!File.Exists(@"..\..\Data\SecretaryData.txt") || Get() == null)
            {
                string secretarySerialized = Newtonsoft.Json.JsonConvert.SerializeObject(secretary);

                System.IO.File.WriteAllText(@"..\..\Data\SecretaryData.txt", secretarySerialized);
            }

            return Get();
        }

    }
}