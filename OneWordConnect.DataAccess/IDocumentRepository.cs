using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWordConnect.DataAccess
{
    public interface IDocumentRepository
    {
        List<Upload> GetUploadDocumentsInfo(int presentationId, int presenter, int roomId, string conferenceName);
    }
}
