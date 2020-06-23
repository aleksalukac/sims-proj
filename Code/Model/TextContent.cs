// File:    TextContent.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class TextContent

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class TextContent
   {
      public int id;
      private string text;
      private TextContentType type;
      
      public TextContent GenerateTextContent()
      {
         throw new NotImplementedException();
      }
      
      public User creator;
   
   }
}