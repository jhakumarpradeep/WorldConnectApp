using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace OneWordConnect.DataAccess
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly string connectionString = DBHelper.GetConnection;
        public List<Upload> GetUploadDocumentsInfo(int presentationId,int presenter, int roomId)
        {
            string filePath = GetDataFilePath("Uploads.xml");
            List<Upload> uploads = new List<Upload>();
            DataSet ds = new DataSet();
            ds.ReadXml(filePath);
            var presentationDataRows = ds.Tables[0].Select().ToList().Where(r => Convert.ToInt32(r["presentation_id"]) == presentationId && Convert.ToInt32(r["presenter_id"])==presenter && Convert.ToInt32(r["room_id"])==roomId);
            foreach(var row in presentationDataRows)
            {
                uploads.Add(new Upload()
                {
                    id = Convert.ToInt32(row["id"]),
                    deleted = Convert.ToInt32(row["deleted"]),
                    presenter_id = Convert.ToInt32(row["presenter_id"]),
                    file_path = Convert.ToString(row["file_path"])
                });
            }
            return uploads;
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
    }
}
