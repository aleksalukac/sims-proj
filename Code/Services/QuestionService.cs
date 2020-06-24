// File:    QuestionService.cs
// Author:  Aleksa
// Created: Friday, May 29, 2020 11:22:30 PM
// Purpose: Definition of Class QuestionService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class QuestionService
   {
      public List<TextContent> GetAllQuestion__()
      {
         throw new NotImplementedException();
      }
      
      public TextContent SetQuestion__(TextContent question)
      {
         throw new NotImplementedException();
      }
      
      public TextContent DeleteQuestion__(int id)
      {
         throw new NotImplementedException();
      }
      
      public TextContent AddQuestion__(TextContent question)
      {
         throw new NotImplementedException();
      }
      
        private TextContentRepository _textContentRepository;

        public QuestionService(TextContentRepository textContentRepository1)
        {
            this._textContentRepository = textContentRepository1;
        }
    }
}