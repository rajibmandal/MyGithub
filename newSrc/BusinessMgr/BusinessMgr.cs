using BusinessMgr.Interfaces;
using DataBaseMgr;
using DataBaseMgr.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessMgr
{
    internal class BusinessMgr : IBusinessMgr
    {
       private static IBusinessMgr _instance = null;
       private readonly IDataBaseMgr _dbMgr = null;
       #region Constructor 
       private BusinessMgr(string dbName)
       {
            Trace.WriteLine("Initializing Core");
            this._dbMgr = DatabaseMgrPlugin.GetDataBaseMgr(dbName);
       }
       #endregion    
      
        
        public static IBusinessMgr GetBusinessMgrInstance(string dbName)
        {
            if (_instance != null)
            {
                _instance = new BusinessMgr(dbName);
            }
            return _instance;
        }
    }
}
