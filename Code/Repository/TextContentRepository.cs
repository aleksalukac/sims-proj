// File:    TextContentRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:17:40 AM
// Purpose: Definition of Class TextContentRepository

using Model; using System; using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class TextContentRepository
   {
        public static TextContent Update(TextContent textContent)
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

        public static TextContent Get(int id)
        {
            List<TextContent> textContents = GetAll();

            foreach (TextContent textContent in textContents)
            {
                if (textContent.Id == id)
                    return textContent;
            }

            return null;
        }

        public static TextContent Remove(int id)
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
        public static void WriteAll(List<TextContent> textContents)
        {
            string textContentsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(textContents);

            System.IO.File.WriteAllText(@"..\..\Data\TextContentData.txt", textContentsSerialized);
        }

        public static TextContent Add(TextContent textContent)
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

        public static List<TextContent> GetAll()
        {
            string textContentsSerialized = System.IO.File.ReadAllText(@"..\..\Data\TextContentData.txt");

            List<TextContent> textContents = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TextContent>>(textContentsSerialized);

            return textContents;
        }

    }
}