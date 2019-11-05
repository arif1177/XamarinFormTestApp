using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamarinFormTestApp.Service
{
    public class QuoteRepo
    {
        private List<Quoter> _quoters =
            new List<Quoter>
            {
                new Quoter{QuoterID=0,QuoterName="Abraham Lincoln" },
                new Quoter{QuoterID=1,QuoterName="David Beckham" }
            };
        private List<Quote> _quotes =
            new List<Quote>
            {
                new Quote{QuoteID = 0, QuoterID=0,QuoteTxt="Don't believe everything you read on the Internet just because there's a picture with a quote next to it.\" ~Abraham Lincoln" },
                new Quote{QuoteID = 1, QuoterID=0,QuoteTxt="Unga Bunga Lorem Ipsum Sit Omit put on" },
                new Quote{QuoteID = 2, QuoterID=1,QuoteTxt="Potpot Putput KutkutGac কাইফা হালুকা" }
            };        
        public QuoteRepo()
        {

        }
        public List<Quote> getQuotesByQuoterID(int id)
        {
            return (from q in _quotes where q.QuoterID == id select q).ToList();
        }
        public List<Quote> getTopQuotes()
        {
            return (from q in _quotes select q).ToList();
        }
        public string getQuoterNameByQuoterID(int quoterID)
        {
            return (from q in _quoters where q.QuoterID == quoterID select q.QuoterName).FirstOrDefault();
        }

        public Quote getQuoteByQuoteID(int id)
        {
            return (from q in _quotes where q.QuoteID == id select q).FirstOrDefault();
        }
    }
}
                                   