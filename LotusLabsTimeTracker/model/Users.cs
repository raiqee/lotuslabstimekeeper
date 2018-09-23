using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.model
{
    public class Users : EntityHistory
    {
        public virtual long id { get; set; }
        public virtual String username { get; set; }
        public virtual String password { get; set; }
        public virtual String firstName { get; set; }
        public virtual String lastName { get; set; }
        public virtual String middleName { get; set; }
        public virtual String email { get; set; }
        public virtual UserType usertype { get; set; }
        public virtual DateTime last_login { get; set; }
        public virtual int invalid_login { get; set; }
        public virtual Boolean validated { get; set; }
        public virtual Users supervisor { get; set; }
    }
}
