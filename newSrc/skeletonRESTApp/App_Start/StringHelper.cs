using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;

namespace skeletonRESTApp.App_Start
{
    public class StringHelper
    {
        public static string DBPath
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["ObjectDBPath"];
            }
        }
        public static string AppAuthUser
        {
            get
            {
                NameValueCollection section = (NameValueCollection)ConfigurationManager.GetSection("secureAppSettings");
                return section["AppAuthUser"];
            }
        }
        public static string AppAuthPwd
        {
            get
            {
                NameValueCollection section = (NameValueCollection)ConfigurationManager.GetSection("secureAppSettings");
                return section["AppAuthPwd"];
            }
        }
    }
}