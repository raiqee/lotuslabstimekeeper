using LotusLabsTimeTracker.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusLabsTimeTracker.services;


namespace LotusLabsTimeTracker.controllers
{
    class UserController
    {
        private LookupBean lookupBean;
        public UserController()
        {
            lookupBean = new LookupBean();
        }

        public IList<UserType> getUserTypes() {
            return lookupBean.getUserTypes();
        }
    }
}
