using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.model
{
    class Users : EntityHistory
    {
        public long id { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String fullName { get; set; }
        public DateTime birthdate { get; set; }
        public UserType usertype { get; set; }
        public int last_login { get; set; }
        public int invalid_login { get; set; }
    }
}
