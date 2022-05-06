using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WinFormUI.Helper
{
    public static class ConfigInfo
    {
        public static string GetConString(string conString)
        {
            return ConfigurationManager.ConnectionStrings[conString].ConnectionString;
        }
    }
}
