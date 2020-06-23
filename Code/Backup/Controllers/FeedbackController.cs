// File:    FeedbackController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:40:30 PM
// Purpose: Definition of Class FeedbackController

using System;

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
      
      public Services.FeedbackService feedbackService;
   
   }
}