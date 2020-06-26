// File:    TextContent.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class TextContent

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class TextContent : BaseModel
   {
        private const string ID_PATH = @"..\..\Data\TextContentId.txt";
        public TextContent() : base(ID_PATH)
        {

        }

        public string Text { get; set; }
        public TextContentType Type { get; set; }
        
        public int OriginQuestion { get; set; }

        public int CreatorUser { get; set; }
   
   }
}