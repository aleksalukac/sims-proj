// File:    FeedbackController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:40:30 PM
// Purpose: Definition of Class FeedbackController

using Model;
using Services;
using System;
using System.Collections.Generic;

namespace Controllers
{
   public class FeedbackController
   {
      public List<TextContent> GetAllFeedback__()
      {
         throw new NotImplementedException();
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
         throw new NotImplementedException();
      }
      
        private FeedbackService _feedbackService;

        public FeedbackController(FeedbackService feedbackService1)
        {
            this._feedbackService = feedbackService1;
        }
    }
}