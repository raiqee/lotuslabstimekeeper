using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusLabsTimeTracker.model;

namespace LotusLabsTimeTracker.services
{
    class UserBean : HibernateSessionFactory
    {
        public UserBean() {
            this.getMySession().BeginTransaction();
        }

        public void saveUser(Users user) {
            getMySession().Merge(user);
            getMySession().Transaction.Commit();
        
        }

        public bool validateEmployeeNoIfExist(String username) {
            Users user = getMySession().Query<Users>().Where(x => x.username == username)
                .FirstOrDefault();
            return user == null ? false: true ;
        }

        public Users getUsersByUsername(String username, String password) {
            Users user = getMySession().Query<Users>().Where(x => x.username == username && x.password == password)
                .FirstOrDefault();
            return user;
        }

        public Users getUsersByUsername(String username)
        {
            Users user = getMySession().Query<Users>().Where(x => x.username == username)
                .FirstOrDefault();
            return user;
        }
    }
}
