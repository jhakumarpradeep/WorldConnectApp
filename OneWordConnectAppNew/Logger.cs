using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWordConnectApp
{
    public static class Logger
    {
        public static void LogInfo(string text)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\ConnectAppLogFile.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(DateTime.Now.ToString() + ": " + text);
            }
        }
    }
}
