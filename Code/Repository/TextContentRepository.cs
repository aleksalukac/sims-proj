// File:    TextContentRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:17:40 AM
// Purpose: Definition of Class TextContentRepository

using Model; using System; using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class TextContentRepository
    {
        private const string TEXT_CONTENT_FILE = @"..\..\Data\TextContentData.txt";

        public TextContentRepository()
        {
            if (!File.Exists(TEXT_CONTENT_FILE))
            {
                using (StreamWriter sw = File.CreateText(TEXT_CONTENT_FILE))
                {
                    sw.WriteLine("[]");
                }
            }
        }

        public  TextContent Update(TextContent textContent)
        {
            List<TextContent> textContents = GetAll();

            for (int i = 0; i < textContents.Count; i++)
            {
                if (textContents[i].Id == textContent.Id)
                {
                    textContents[i] = textContent;
                    break;
                }
            }

            WriteAll(textContents);

            return textContent;
        }

        public  TextContent Get(int id)
        {
            List<TextContent> textContents = GetAll();

            foreach (TextContent textContent in textContents)
            {
                if (textContent.Id == id)
                    return textContent;
            }

            return null;
        }

        public  TextContent Remove(int id)
        {
            List<TextContent> textContents = GetAll();

            TextContent textContentToRemove = textContents.SingleOrDefault(r => r.Id == id);

            if (textContentToRemove != null)
            {
                textContents.Remove(textContentToRemove);
                WriteAll(textContents);
            }

            return textContentToRemove;
        }

        public  void WriteAll(List<TextContent> textContents)
        {
            string textContentsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(textContents);

            System.IO.File.WriteAllText(TEXT_CONTENT_FILE, textContentsSerialized);
        }

        public  TextContent Add(TextContent textContent)
        {
            if (Get(textContent.Id) == null)
            {
                List<TextContent> textContents = GetAll();
                textContents.Add(textContent);
                WriteAll(textContents);

                return textContent;
            }
            return null;
        }

        public  List<TextContent> GetAll()
        {
            string textContentsSerialized = System.IO.File.ReadAllText(TEXT_CONTENT_FILE);

            List<TextContent> textContents = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TextContent>>(textContentsSerialized);

            return textContents;
        }

    }
}