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

        public List<string> GetDateByPresenters(List<Presenter> presenters)
        {
            return _presenterRepository.GetDateByPresenters(presenters);
        }

        public List<Presentation> GetPresentation(int presnterId, int roomId, int sessionId, string date, string time)
        {
            return _presenterRepository.GetPresentation(presnterId, roomId, sessionId,date,time);
        }

        public IList<Presenter> GetPresenters(int conferenceId, string password)
        {

            return _presenterRepository.GetPresenters(conferenceId, password);
        }

        public List<Room> GetRoomList(string date, string time)
        {
            return _presenterRepository.GetRoomList(date,time);
        }

        public List<Session> GetSessions(int roomId, string date, string time)
        {
            return _presenterRepository.GetSessions(roomId, date, time);
        }

        public List<string> GetTimeByPresenters(List<Presenter> presenters)
        {
            return _presenterRepository.GetTimeByPresenters(presenters);
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
