using OneWordConnect.DataAccess;
using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWorldConnect.BusinessLogic
{
    public class DocumentBusinesssService : IDocumentBusinesssService
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentBusinesssService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }
        public List<Upload> GetUploadDocumentsInfo(int presentationId, int presenter, int roomId, string conferenceName)
        {
            return _documentRepository.GetUploadDocumentsInfo(presentationId, presenter, roomId,conferenceName);
        }
    }
}
