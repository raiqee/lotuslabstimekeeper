using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.model
{
    [Serializable]
    class EntityHistory
    {
        public long createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public long updatedBy { get; set; }
        public DateTime updatedDate { get; set; }
    }
}
