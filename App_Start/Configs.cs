using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSCREPORT.App_Start
{
    public class Configs
    {
        string ip = Properties.Settings.Default.IPserver;
        public string IPserver()
        {
            return ip;
        }

        public string GetIP
        {
            get
            {
                return ip;
            }
            
        }
    }
}