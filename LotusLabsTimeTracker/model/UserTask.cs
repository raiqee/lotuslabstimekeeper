using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.model
{
    class UserTask : EntityHistory
    {
        public virtual long id { get; set; }
        public virtual Users user { get; set; }
        public virtual DateTime startDateTime { get; set; }
        public virtual DateTime endDateTime { get; set; }
        public virtual Project project { get; set; }
        public virtual TaskType taskType { get; set; }
        public virtual WorkType workType { get; set; }
        public virtual Boolean billable { get; set; }
        public virtual String description { get; set; }
    }
}
