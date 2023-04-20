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
        public IList<Presenter> GetPresenters(int conferenceId, string password)
        {
            
            string filePath = GetDataFilePath("Presenters.xml");
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

        private static string GetDataFilePath(string fileName)
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string configFilePath = System.IO.Path.Combine(strWorkPath, "ApplicationSetting.xml");
            System.Xml.Linq.XElement xElement = System.Xml.Linq.XElement.Load(configFilePath);
            var dbConnectionFilePath = xElement.Element("DbConnectionFilePath");
            string filePath = dbConnectionFilePath.Value + "/" + "DataFiles" + "//" + fileName;
            return filePath;
        }

        public List<Session> GetSessions(int roomId, string date, string time)
        {
            string filePath = GetDataFilePath("Presentations.xml");
            List<Session> sessions = new List<Session>();
            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();

                ds.ReadXml(filePath);

                var presentationDataRows = ds.Tables[0].Select().ToList().Where(r => Convert.ToInt32(r["room_id"]) == roomId &&
                Convert.ToString(r["presentation_date"]) == date && Convert.ToString(r["start_time"]) == time);
                if (presentationDataRows != null)
                {
                    string sessionFilePath = GetDataFilePath("Sessions.xml");
                    DataSet dsSession = new DataSet();
                    dsSession.ReadXml(sessionFilePath);
                    foreach (DataRow dataRow in presentationDataRows)
                    {
                        var sessionDataRows = dsSession.Tables[0].Select().ToList().Where(r => Convert.ToInt32(r["id"]) == Convert.ToInt32(dataRow["session_Id"]));
                        foreach (var dr in sessionDataRows)
                        {
                            sessions.Add(new Session()
                            {
                                SessionId = Convert.ToInt32(dr["id"]),
                                SessionName = Convert.ToString(dr["name"]),
                                SessionFullName = Convert.ToString(dr["full_name"]),
                                //SessionStartTime = dr["start_time"]!=null? Convert.ToDateTime(dr["start_time"]):null,
                                //SessionEndTime = Convert.ToDateTime(dr["end_time"]),

                            });
                        }
                    }
                }

            }
            return sessions.Distinct().ToList();
            //using (var con = new SqlConnection(connectionString))
            //{
            //    return con.Query<Session>("select Id as SessionId, name as SessionName,full_name as SessionFullName,start_time as SessionStartTime,end_time as SessionEndTime from Sessions where id in (select session_Id from presentations where presenter_id=@presenter_Id)",new { presenter_Id =presenterId}).ToList();
            //}
        }
        public List<Room> GetRoomList(string date,string time)
        {
            string filePath = GetDataFilePath("Presentations.xml");
            List<Room> rooms = new List<Room>();
            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();

                ds.ReadXml(filePath);

                var presentationDataRows = ds.Tables[0].Select().ToList().Where(r => Convert.ToString(r["presentation_date"]) == date &&
                Convert.ToString(r["start_time"]) == time);
                if (presentationDataRows != null)
                {
                    string roomFilePath = GetDataFilePath("Rooms.xml");
                    DataSet dsRooms = new DataSet();
                    dsRooms.ReadXml(roomFilePath);
                    foreach (DataRow dataRow in presentationDataRows)
                    {
                        var roomDataRows = dsRooms.Tables[0].Select().ToList().Where(r => Convert.ToInt32(r["id"]) == Convert.ToInt32(dataRow["room_Id"]));
                        foreach (var dr in roomDataRows)
                        {
                            if (!rooms.Exists(a => a.RoomId == Convert.ToInt32(dr["id"])))
                            {
                                rooms.Add(new Room() { RoomId = Convert.ToInt32(dr["id"]), RoomName = Convert.ToString(dr["name"]) });
                            }
                        }
                    }
                }
            }
            return rooms.ToList().Distinct().ToList();
        }
        public List<string> GetDateByPresenters(List<Presenter> presenters)
        {
            string filePath = GetDataFilePath("Presentations.xml");
            List<string> dates = new List<string>();
            foreach (var preseneter in presenters)
            {
                if (File.Exists(filePath))
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(filePath);
                    var presentationDataRows = ds.Tables[0].Select().ToList().Where(r => Convert.ToInt32(r["presenter_Id"]) == preseneter.PresenterId);
                    if (presentationDataRows != null)
                    {
                        foreach (var row in presentationDataRows)
                        {
                            dates.Add(Convert.ToString(row["presentation_date"]));
                        }
                    }
                }
            }
            return dates.Distinct().ToList();
        }
        public List<string> GetTimeByPresenters(List<Presenter> presenters)
        {
            string filePath = GetDataFilePath("Presentations.xml");
            List<string> times = new List<string>();
            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);
                foreach (var preseneter in presenters)
                {
                    var presentationDataRows = ds.Tables[0].Select().ToList().Where(r => Convert.ToInt32(r["presenter_Id"]) == preseneter.PresenterId);
                    if (presentationDataRows != null)
                    {
                        foreach (var row in presentationDataRows)
                        {
                            times.Add(Convert.ToString(row["start_time"]));
                        }
                    }
                }
            }
            return times.Distinct().ToList();
        }

        public List<Presentation> GetPresentation(int presnterId, int roomId, int sessionId,string date,string time)
        {
            List<Presentation> presentations = new List<Presentation>();
            string filePath = GetDataFilePath("Presentations.xml");
            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();

                ds.ReadXml(filePath);
                var dr = ds.Tables[0].Select().ToList().Where(r =>
                Convert.ToInt32(r["room_id"]) == roomId && Convert.ToInt32(r["session_id"]) == sessionId && 
                Convert.ToString(r["presentation_date"]) ==date && Convert.ToString(r["start_time"])==time).ToList();
                if (dr != null)
                {
                    foreach(var row in dr)
                    {
                        Presentation presentation = new Presentation();
                        presentation.id = Convert.ToInt32(row["id"]);
                        presentation.name= Convert.ToString(row["name"]);
                        presentation.assigned_id= Convert.ToString(row["assigned_id"]);
                        presentation.presentation_date = Convert.ToDateTime(row["presentation_date"]);
                        presentation.presentation_start= Convert.ToString(row["presentation_start"]);
                        presentation.start_time= Convert.ToString(row["start_time"]);
                        presentation.end_time= Convert.ToString(row["end_time"]);
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
