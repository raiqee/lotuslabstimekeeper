using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.model
{
    class EntityCode : EntityHistory
    {
        public String code { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public Boolean activeFlag { get; set;  }

    }
}
