using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWorldConnect.BusinessLogic
{
    public interface IPresenterBusinessLogic
    {
        IList<Presenter> GetPresenters(int conferenceId, string password);
        List<Room> GetRoomList(string date,string time);
        List<Session> GetSessions(int roomId, string date, string time);
        List<Presentation> GetPresentation(int presnterId, int roomId, int sessionId, string date, string time);
        List<string> GetDateByPresenters(List<Presenter> presenters);
        List<string> GetTimeByPresenters(List<Presenter> presenters);

    }
}

