using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_class_diagram.Services
{
    public class TextContentService
    {
        private TextContentRepository _textContentRepository;
        public TextContentService(TextContentRepository textContentRepository)
        {
            this._textContentRepository = textContentRepository;
        }

        public TextContent Add(TextContent textContent)
            => _textContentRepository.Add(textContent);
    }
}
