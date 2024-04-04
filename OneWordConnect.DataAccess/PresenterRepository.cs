using Dapper;
using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace OneWordConnect.DataAccess
{
    public class PresenterRepository : IPresenterRepository
    {
       
        public PresenterRepository()
        {

        }
        //private readonly string  connectionString = DBHelper.GetDBConnectionFilPath();
        public IList<Presenter> GetPresenters(int conferenceId, string password, string conferrence)
        {
            
            string filePath = GetDataFilePath("Presenters.xml", conferrence);
            List<Presenter> presenters = new List<Presenter>();
            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
          
                ds.ReadXml(filePath);
                var dataRows = ds.Tables[0].Select().ToList().Where(a => a["conference_id"] != DBNull.Value && Convert.ToInt32(a["conference_id"])==conferenceId).ToList();
                //var dataRows = dsFilter.Tables[0].Select().ToList().Where(r => Convert.ToInt32(r["conference_id"]) == conferenceId).ToList();
                foreach(var dr in dataRows)
                {
                    Presenter presenter = new Presenter();
                    presenter.PresenterId = Convert.ToInt32(dr["presenter_id"]);
                    presenter.FirstName = Convert.ToString(dr["first_name"]);
                    presenter.LastName = Convert.ToString(dr["last_name"]);
                    presenter.Email = Convert.ToString(dr["email"]);
                    presenters.Add(presenter);
                }
            }
            
            return presenters;
        }

        private static string GetDataFilePath(string fileName, string conferrence)
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string configFilePath = System.IO.Path.Combine(strWorkPath, "ApplicationSetting.xml");
            System.Xml.Linq.XElement xElement = System.Xml.Linq.XElement.Load(configFilePath);
            var dbConnectionFilePath = xElement.Element("DbConnectionFilePath");
            string filePath = dbConnectionFilePath.Value + "/" + "DataFiles/" + conferrence+ "//" + fileName;
            return filePath;
        }

        public List<Session> GetSessions(List<Presenter> presenters, string conferrence)
        {
            List<Session> sessions = new List<Session>();
            DataSet ds = new DataSet();
            string sessionFilePath = GetDataFilePath("Sessions.xml", conferrence);
            DataSet dsSession = new DataSet();
            dsSession.ReadXml(sessionFilePath);
            var sessionDataRows = dsSession.Tables[0].Select().ToList();
            foreach (var dr in sessionDataRows)
            {
                sessions.Add(new Session()
                {
                    SessionId = Convert.ToInt32(dr["id"]),
                    SessionName = Convert.ToString(dr["name"]),
                    SessionFullName = Convert.ToString(dr["full_name"]),
                    SessionStartTime = Convert.ToString(dr["start_time"]),
                    SessionEndTime = Convert.ToString(dr["end_time"]),
                    session_date = Convert.ToDateTime(dr["session_date"])
                }); ;
            }
            return sessions.Distinct().ToList();
        }
        public List<Room> GetRoomList(int sessionId, string conferrence)
        {
            var rooms = new List<Room>();
            string filePath = GetDataFilePath("Presentations.xml", conferrence);
            List<string> times = new List<string>();
            if (File.Exists(filePath))
            {
                string roomFilePath = GetDataFilePath("Rooms.xml", conferrence);
                DataSet dsRooms = new DataSet();
                dsRooms.ReadXml(roomFilePath);
                var roomDataRows = dsRooms.Tables[0].Select().ToList();
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);
                var sessionRoomDataRows = ds.Tables[0].Select().ToList().Where(r=>Convert.ToInt32(r["session_id"])==sessionId);
                foreach( DataRow datar in sessionRoomDataRows)
                {
                    foreach (var dr in roomDataRows)
                    {
                        if (Convert.ToInt32(datar["room_id"]) == Convert.ToInt32(dr["id"]))
                        {
                            if (!rooms.Exists(a => a.RoomId == Convert.ToInt32(datar["room_id"])))
                            {
                                rooms.Add(new Room() { RoomId = Convert.ToInt32(dr["id"]), RoomName = Convert.ToString(dr["name"]) });
                                break;
                            }
                        }
                    }
                }
            }
               
           
            
            return rooms.ToList().Distinct().ToList();
        }

        public List<Presentation> GetPresentation(int presnterId, int roomId, int sessionId,string start_time, string end_time, string conferrence)
        {
         
            List<Presentation> presentations = new List<Presentation>();
            string filePath = GetDataFilePath("Presentations.xml", conferrence);
            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);
                var dr = ds.Tables[0].Select().ToList().Where(r =>
                Convert.ToInt32(r["room_id"]) == roomId && Convert.ToInt32(r["session_id"]) == sessionId).ToList();
                if (dr != null)
                {
                    foreach(var row in dr)
                    {
                        Presentation presentation = new Presentation();
                        presentation.id = Convert.ToInt32(row["id"]);
                        presentation.name= Convert.ToString(row["name"]);
                        presentation.assigned_id= Convert.ToString(row["assigned_id"]);
                        presentation.presentation_start= Convert.ToString(row["presentation_start"]);
                        presentation.session_id = Convert.ToInt32(row["session_id"]);
                        presentation.presenter_id = Convert.ToInt32(row["presenter_id"]);
                        presentation.room_id = Convert.ToInt32(row["room_id"]);
                        presentations.Add(presentation);
                    }
                }
            }
            return presentations;
        }

    }
}
