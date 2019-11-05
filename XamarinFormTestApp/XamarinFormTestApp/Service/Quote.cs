using System;
using SQLite;

namespace XamarinFormTestApp.Service
{
    public class Quote
    {
        [PrimaryKey,AutoIncrement]
        public int QuoteID
        {
            get;
            set;
        }
        public string QuoteTxt
        { 
            get; 
            set;
        }
        public int QuoterID
        { 
            get;
            set;
        }
        public override string ToString()
        {
            return QuoteTxt;
        }
    }
}