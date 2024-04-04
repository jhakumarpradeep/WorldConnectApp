using OneWordConnect.DataAccess;
using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OneWorldConnect.BusinessLogic
{
    public class PresenterBusinessLogic : IPresenterBusinessLogic
    {
        IPresenterRepository _presenterRepository;
        public PresenterBusinessLogic(IPresenterRepository presenterRepository)
        {
            _presenterRepository = presenterRepository;
        }

        public List<Presentation> GetPresentation(int presnterId, int roomId, int sessionId, string start_time, string end_time, string conferrence)
        {
            return _presenterRepository.GetPresentation(presnterId, roomId, sessionId, start_time, end_time,conferrence);
        }

        public IList<Presenter> GetPresenters(int conferenceId, string password, string conferrence)
        {

            return _presenterRepository.GetPresenters(conferenceId, password,conferrence);
        }

        public List<Room> GetRoomList(int sessionId, string conferrence)
        {
            return _presenterRepository.GetRoomList(sessionId,conferrence);
        }

        public List<Session> GetSessions(List<Presenter> presenters, string conferrence)
        {
            return _presenterRepository.GetSessions(presenters,conferrence);
        }

        

        private bool ISValidEmail(string emailId)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            return re.IsMatch(emailId);
        }
    }
}
