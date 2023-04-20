using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWorldConnect.DomainModel
{
    public class Presentation
    {
        public int id { get; set; }
        public string assigned_id { get; set; }
        public string name { get; set; }
        public int session_id { get; set; }
        public int presenter_id { get; set; }
        public int room_id { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
        public int active { get; set; }
        public DateTime? presentation_date { get; set; }
        public string presentation_start { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
    }
}
