using OneWorldConnect.DomainModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OneWordConnectApp
{
    public static class APIHelper
    {
        public static List<Conference> GetAPIUploadList()
        {
            string currentExecutionPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = currentExecutionPath + "/Conferences.xml";
            List<Conference> conferences = new List<Conference>();
            if (File.Exists(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);
                var dataRow = ds.Tables[0].Select().ToList();

                foreach (DataRow dr in dataRow)
                {
                    Conference conference = new Conference();
                    conference.conference_id = Convert.ToInt32(dr["id"]);
                    conference.conference_name = Convert.ToString(dr["name"]);
                    conference.conference_password= Convert.ToString(dr["conference_password"]);
                    conferences.Add(conference);
                }
            }
            return conferences;
        }

    }
}
