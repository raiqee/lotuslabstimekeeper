using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusLabsTimeTracker.model;
using NHibernate;
using NHibernate.Criterion;

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

        public IList<Users> getUsersByRank(Users users) {
            String hql = "";
            if (users.usertype.code.Equals(Constants.ROLE_RANK_AND_FILE))
            {
                hql = "select u from Users as u " +
                    " where u.id = :userId";
            }
            else if (users.usertype.code.Equals(Constants.ROLE_QA_MANAGER))
            {
                hql = "select u from Users as u " +
                    " inner join u.usertype ut " +
                    " where (ut.code = 'QA_MANAGER' OR u.id in (" +
                    "   select uu.id from Users as uu where uu.supervisor.id = :userId " +
                    "))";
            }
            else if (users.usertype.code.Equals(Constants.ROLE_SUPERVISOR))
            {
                hql = "select u from Users as u " +
                    " inner join u.usertype ut " +
                    " where (ut.code = 'SUPERVISOR' OR u.id in (" +
                    "   select uu.id from Users as uu where uu.supervisor.id = :userId " +
                    "))";
            }
            else if (users.usertype.code.Equals(Constants.ROLE_ADMIN)) {
                hql = "select u from Users as u ";
            }

            IQuery query = getMySession().CreateQuery(hql);
            if (!users.usertype.code.Equals(Constants.ROLE_ADMIN)) {
                query.SetParameter("userId", users.id); 
            }

            return query.List<Users>();
        }

        public Users getUserDetails(long id) {
            return getMySession().Query<Users>().Where(x => x.id == id).SingleOrDefault();
        }

        public IList<Users> getUsersListPerUserType(String usertypes) { 
            String hql = "select u From Users as u " +
                        " inner join u.usertype ut " + 
                        " where ut.code in (" + usertypes + ")";
            IList<Users> result = getMySession().CreateQuery(hql)
                                        .List<Users>();
            return result;
        }

        public IList<Users> getUsersList(UserType userType, Users supervisor)
        {
            ICriteria criteria = getMySession().CreateCriteria<Users>();

            if (userType != null && userType.id != 0L) { 
                criteria.Add(Restrictions.Eq(Projections.Property<Users>(x => x.usertype.id), userType.id));
            }
            if (supervisor != null && supervisor.id != 0L) {
                criteria.Add(Restrictions.Eq(Projections.Property<Users>(x => x.supervisor.id), supervisor.id));
            }
            return criteria.List<Users>();
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
