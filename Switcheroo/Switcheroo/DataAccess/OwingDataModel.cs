using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switcheroo.DataAccess
{
    class OwingDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Transaction_id {get; set;}
        [Indexed]
        public string PersonOwing { get; set; }
        public DateTime Date { get; set; }

    }
}
