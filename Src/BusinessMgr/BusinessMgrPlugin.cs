using BusinessMgr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessMgr
{
    public class BusinessMgrPlugin
    {
        public static IBusinessMgr GetBusinessMgr(string dbName)
        {
            return BusinessMgr.GetBusinessMgrInstance(dbName);
        }
    }
}
