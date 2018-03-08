using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EMRFacade
{
    public class Common
    {
        #region Static Url Properties
        public static string URLServicePath { get { return ConfigurationManager.AppSettings["URLServicePath"]; } }
        #endregion

        #region Static Method
        public static void AbortSession()
        {
            HttpContext.Current.Session.Clear();
            HttpContext.Current.Session.Abandon();
        }
        #endregion
    }
    public class NameValuePair
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }

    public class APIMessage
    {
        public string Message { get; set; }
    }
}