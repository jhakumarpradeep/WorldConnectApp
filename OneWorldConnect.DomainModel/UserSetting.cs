using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWorldConnect.DomainModel
{
    public class UserSetting
    {
        public int RoomId { get; set; }
        public int SessionId { get; set; }
        public string UserLogoImagePath { get; set; }
        public string UserBackgroundLoginImagePath { get; set; }
        public string UserBackGroundShowImagePath { get; set; }
        public string Time { get; set; } 
        public DateTime Date { get; set; }

        public string DbConnectionFilePath { get; set; }


    }
}
