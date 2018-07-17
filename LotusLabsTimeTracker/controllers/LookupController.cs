using LotusLabsTimeTracker.model;
using LotusLabsTimeTracker.services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.controllers
{
    class LookupController
    {
        public WorkType saveWorkType(WorkType workType) {
            workType.createdBy = 0L;
            workType.createdDate = DateTime.Now;
            workType.updatedBy = 0L;
            workType.updatedDate = DateTime.Now;
            workType.activeFlag = true;
            workType = getLookupBean().saveWorkType(workType);
            return workType;
        }

        public DataTable getWorkTypeDataTable() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("Code");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Status");

            IList<WorkType> workTypes = getLookupBean().getWorkTypes();
            if (workTypes.Count > 0) {
                foreach(WorkType workType in workTypes)
                {
                    dataTable.Rows.Add(new object[] { workType.id,
                                                      workType.code,
                                                      workType.name,
                                                      workType.description ,
                                                      workType.activeFlag });
                }
            }
            return dataTable;
        }

        public LookupBean getLookupBean() {
            return new LookupBean();
        }
    }
}
