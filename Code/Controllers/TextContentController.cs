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

        public List<TextContent> GetAllByType(TextContentType type)
        {
            return _textContentService.GetAllByType(type);
        }

        public TextContent Add(TextContent textContent)
        {
            return _textContentService.Add(textContent);
        }

        public TextContent Get(int id)
        {
            return _textContentService.Get(id);
        }

        public TextContent Update(TextContent textContent)
        {
            return _textContentService.Update(textContent);
        }
    }
}
