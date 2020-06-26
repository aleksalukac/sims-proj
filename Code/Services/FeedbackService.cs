// File:    FeedbackService.cs
// Author:  Aleksa
// Created: Friday, May 29, 2020 11:19:08 PM
// Purpose: Definition of Class FeedbackService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class FeedbackService
   {
      public List<TextContent> GetAllFeedback__()
      {
            return _textContentRepository.GetAll();
      }
      
      public TextContent SetFeedback__(TextContent feedback)
      {
         throw new NotImplementedException();
      }
      
      public TextContent DeleteFeedback__(int id)
      {
         throw new NotImplementedException();
      }

        public TextContent AddFeedback__(TextContent feedback)
      {
           return _textContentRepository.Add(feedback);
      }
      
        private TextContentRepository _textContentRepository;

        public FeedbackService(TextContentRepository textContentRepository1)
        {
            this._textContentRepository = textContentRepository1;
        }
    }
}