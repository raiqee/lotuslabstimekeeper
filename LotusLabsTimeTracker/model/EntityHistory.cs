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
        public virtual long createdBy { get; set; }
        public virtual DateTime createdDate { get; set; }
        public virtual long updatedBy { get; set; }
        public virtual DateTime updatedDate { get; set; }
    }
}
