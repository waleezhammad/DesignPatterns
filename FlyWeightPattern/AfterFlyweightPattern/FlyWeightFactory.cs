using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.After
{
    public class FlyWeightFactory
    {
        Dictionary<DocumentType, IDocument> documents = new Dictionary<DocumentType, IDocument>();

        public IDocument GetDocument(DocumentType documentType)
        {
            if (!documents.Any(c => c.Key == documentType))
                switch (documentType)
                {
                    case DocumentType.Book:
                        documents.Add(documentType, new Book());
                        break;
                    case DocumentType.Paper:
                        documents.Add(documentType, new Paper());
                        break;
                    default:
                        break;
                }

            return documents.FirstOrDefault(c => c.Key == documentType).Value;
        }
    }

    public enum DocumentType
    {
        Book,
        Paper
    }
}
