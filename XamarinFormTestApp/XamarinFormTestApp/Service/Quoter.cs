using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamarinFormTestApp.Service
{
    public class Quoter
    {
        [PrimaryKey, AutoIncrement]
        public int QuoterID
        {
            get;
            set;
        }
        public string QuoterName
        {
            get;
            set;
        }
    }
}
