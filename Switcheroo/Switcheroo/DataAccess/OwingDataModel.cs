using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switcheroo.DataAccess
{
    class OwingDataModel
    {

        //DataModel ie. Database elements for this class
        [PrimaryKey, AutoIncrement]
        public int Transaction_id {get; set;}
        [Indexed]
        public string PersonOwing { get; set; }
        public DateTime Date { get; set; }

    }
}
