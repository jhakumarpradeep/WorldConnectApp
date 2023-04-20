using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWordConnect.DataAccess
{
    public static class DBHelper
    {
        public static string GetConnection { get { return  ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString(); } }
        public static string GetDBConnectionFilPath()
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string configFilePath = System.IO.Path.Combine(strWorkPath, "ApplicationSetting.xml");
            System.Xml.Linq.XElement xElement = System.Xml.Linq.XElement.Load(configFilePath);
            var dbConnectionFilePath = xElement.Element("DbConnectionFilePath");
            string GetBaseConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbConnectionFilePath.Value + @"\OneWorld.mdf;Integrated Security=true;Encrypt=False;TrustServerCertificate=False;Connection Timeout=300";
            return GetBaseConnectionString;
        }
    }
}
