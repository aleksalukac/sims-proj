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
      public static TextContent SetTextContent(TextContent textContent)
      {
            List<TextContent> textContents = GetAllTextContent();

            for (int i = 0; i < textContents.Count; i++)
            {
                if (textContents[i].id == textContent.id)
                {
                    textContents[i] = textContent;
                    break;
                }
            }

            WriteAllTextContent(textContents);

            return textContent;
        }
      
      public static TextContent GetTextContent(int id)
      {
            List<TextContent> textContents = GetAllTextContent();

            foreach (TextContent textContent in textContents)
            {
                if (textContent.id == id)
                    return textContent;
            }

            return null;
        }
      
      public static TextContent RemoveTextContent(int id)
      {
            List<TextContent> textContents = GetAllTextContent();

            TextContent textContentToRemove = textContents.SingleOrDefault(r => r.id == id);

            if (textContentToRemove != null)
            {
                textContents.Remove(textContentToRemove);
                WriteAllTextContent(textContents);
            }

            return textContentToRemove;
        }
        public static void WriteAllTextContent(List<TextContent> textContents)
        {
            string textContentsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(textContents);

            System.IO.File.WriteAllText(@"..\..\Data\TextContentData.txt", textContentsSerialized);
        }

        public static TextContent AddFTextContent(TextContent textContent)
      {
            List<TextContent> textContents = GetAllTextContent();
            textContents.Add(textContent);
            WriteAllTextContent(textContents);

            return textContent;
        }
      
      public static List<TextContent> GetAllTextContent()
      {
            string textContentsSerialized = System.IO.File.ReadAllText(@"..\..\Data\TextContentData.txt");

            List<TextContent> textContents = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TextContent>>(textContentsSerialized);

            return textContents;
        }
   
   }
}