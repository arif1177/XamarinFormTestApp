using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormTestApp.Service
{
    public class QuoterDetailsModel
    {
        public string QuoterName
        {
            get;
            set;
        }
        public string QuoteTxt
        {
            get;
            set;
        }
        
        public static QuoterDetailsModel getQuoterDetails
        {//this is needed to show test data during design phase. Not sure how this works. 2019-10-27.
            get
            {
                return new QuoterDetailsModel
                {
                    QuoterName = "Test Quoter",
                    QuoteTxt = "All good here"
                };
            }
        }
    }
}
