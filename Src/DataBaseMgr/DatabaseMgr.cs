using DataBaseMgr.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseMgr
{
    internal class DatabaseMgr : IDataBaseMgr
    {
        private static IDataBaseMgr _instance = null;
       #region Constructor 
        private DatabaseMgr(string dbName)
       {
            Trace.WriteLine("Initializing Database Manager");

       }
       #endregion    
        public static IDataBaseMgr GetDataBaseMgrInstance(string dbName)
        {
            if (_instance != null)
            {
                _instance = new DatabaseMgr(dbName);
            }
            return _instance;
        }
    }
}
