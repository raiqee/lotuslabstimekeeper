using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusLabsTimeTracker.model;

namespace LotusLabsTimeTracker.utilities
{
    class GlobalUtility
    {
        public EntityHistory getHistory() {
            EntityHistory history = new EntityHistory();
            history.createdBy = 0L;
            history.createdDate = new DateTime();
            history.updatedBy = 0L;
            history.updatedDate = new DateTime();
            return history;
        }
    }
}
