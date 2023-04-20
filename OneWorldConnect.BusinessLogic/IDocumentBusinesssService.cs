using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneWorldConnect.DomainModel;
namespace OneWorldConnect.BusinessLogic
{
    public interface IDocumentBusinesssService
    {
        List<Upload> GetUploadDocumentsInfo(int presentationId, int presenter, int roomId);
    }
}
