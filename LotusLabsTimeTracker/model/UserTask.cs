using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.model
{
    class UserTask : EntityHistory
    {
        public long id { get; set; }
        public Users user { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }
        public Project project { get; set; }
        public Module module { get; set; }
        public TaskType taskType { get; set; }
        public WorkType workType { get; set; }
        public Boolean billable { get; set; }
        public String description { get; set; }
    }
}
