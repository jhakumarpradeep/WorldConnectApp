using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWorldConnect.DomainModel
{
    public class Session
    {
        public int SessionId { get; set; }
        public string SessionName { get; set; }
        public string SessionFullName { get; set; }
        public DateTime? SessionStartTime { get; set; }
        public DateTime? SessionEndTime { get; set; }
        public DateTime? PresentationStart { get; set; }
    }
}
