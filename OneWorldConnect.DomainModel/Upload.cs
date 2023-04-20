using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWorldConnect.DomainModel
{
    public class Upload
    {
        public int id { get; set; }
        public string name { get; set; }
        public string file_name { get { return this.name; } }
        public string format { get; set; }
        public string extension { get; set; }
        public string size { get; set; }
        public string file_path { get; set; }
        public int presentation_id { get; set; }
        public int presenter_id { get; set; }
        public int room_id { get; set; }
        public DateTime uploaded_date_time { get; set; }
        public int deleted { get; set; }
        public DateTime? deleted_date_time { get; set; }
    }
}
