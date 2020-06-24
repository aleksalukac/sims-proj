// File:    QuestionController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:40:30 PM
// Purpose: Definition of Class QuestionController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class QuestionController
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
      
        private QuestionService _questionService;

        public QuestionController(QuestionService questionService1)
        {
            this._questionService = questionService1;
        }
    }
}