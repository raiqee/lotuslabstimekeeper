using LotusLabsTimeTracker.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusLabsTimeTracker.services;


namespace LotusLabsTimeTracker.controllers
{
    public class UserController
    {
        public UserController() {

        }

        public void viewSampleData() {
            ModuleBean bean = new ModuleBean();
            IList<Module> modules = bean.GetModuleList();
            Console.WriteLine(modules);
        }
    }
}
