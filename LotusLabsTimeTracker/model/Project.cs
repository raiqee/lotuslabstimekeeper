using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.model
{
    public class Project : EntityCode
    {
        public virtual long id { get; set; }
        public virtual WorkType workType { get; set; }
    }
}