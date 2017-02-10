using DataBaseMgr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseMgr
{
    public class DatabaseMgrPlugin
    {
        public static IDataBaseMgr GetDataBaseMgr(string dbName)
        {
            return DatabaseMgr.GetDataBaseMgrInstance(dbName);
        }
    }
}
