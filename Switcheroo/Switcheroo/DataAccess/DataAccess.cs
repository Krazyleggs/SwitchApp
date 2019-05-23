using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace Switcheroo.DataAccess
{
    class DataAccess
    {

        //Return name of person who is currently owing from db
        public static string GetPersonOwing()
        {
            var db = new SQLiteConnection(ConnectionStringHelper.GetConnection());
            var query = db.Table<OwingDataModel>().OrderByDescending(v => v.Transaction_id).First();
            return query.PersonOwing;
        }

        //Switch name of person owing then update database
        public static void SwitchPersonOwing (string CurrentPersonOwing)
        {
            var db = new SQLiteConnection(ConnectionStringHelper.GetConnection());
            var Nextowing = new OwingDataModel();
            if (CurrentPersonOwing == "Robin") {Nextowing.PersonOwing = "Mischel";}
            else {Nextowing.PersonOwing = "Robin";}
            Nextowing.Date = DateTime.Now;
            db.Insert(Nextowing);
            
        }
    }
}
