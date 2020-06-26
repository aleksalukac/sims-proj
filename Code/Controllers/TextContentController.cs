using Hospital_class_diagram.Services;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_class_diagram.Controllers
{
    public class TextContentController
    {
        public TextContentController(TextContentService textContentService)
        {
            _textContentService = textContentService;
        }

        private TextContentService _textContentService;

        public TextContent Add(TextContent textContent)
        {
            return _textContentService.Add(textContent);
        }
    }
}
