using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWordConnect.DataAccess
{
    public interface IPresenterRepository
    {
        IList<Presenter> GetPresenters(int conferenceId, string password,string conferrence);
        List<Room> GetRoomList(int sessionId, string conferrence);
        List<Session> GetSessions(List<Presenter> presenters, string conferrence);
        List<Presentation> GetPresentation(int presnterId, int roomId, int sessionId, string start_time, string end_time, string conferrence);
    }
}
