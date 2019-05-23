using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Switcheroo.DataAccess
{
    class ConnectionStringHelper
    {
        //Path of database
        public static string GetConnection() {
        return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "database.db3");
        }
    }
}   
