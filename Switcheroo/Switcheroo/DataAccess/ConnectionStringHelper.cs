using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Switcheroo.DataAccess
{
    class ConnectionStringHelper
    {
        //Returns database path
        public static string GetConnection() {
        return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "database.db3");
        }
    }
}   
