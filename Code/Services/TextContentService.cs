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

        public List<TextContent> GetAll()
            => _textContentRepository.GetAll();

        public TextContent Add(TextContent textContent)
            => _textContentRepository.Add(textContent);

        internal List<TextContent> GetAllByType(TextContentType type)
        {
            List<TextContent> textContentsByType = new List<TextContent>();

            foreach(var textContent in GetAll())
            {
                if (textContent.Type == type)
                    textContentsByType.Add(textContent);
            }
            return textContentsByType;
        }

        internal TextContent Update(TextContent textContent)
            => _textContentRepository.Update(textContent);

        internal TextContent Get(int id)
            => _textContentRepository.Get(id);
    }
}
