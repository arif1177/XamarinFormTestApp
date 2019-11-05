using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace XamarinFormTestApp.Service
{
    public class DBSQLite
    {
        readonly SQLiteAsyncConnection _database;

        public DBSQLite(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Quoter>().Wait();
            _database.CreateTableAsync<Quote>().Wait();
        }

        public Task<List<Quoter>> GetAllQuoterAsync()
        {
            return _database.Table<Quoter>().ToListAsync();
        }
        public Task<List<Quote>> GetAllQuoteAsync()
        {
            return _database.Table<Quote>().ToListAsync();
        }
        public async Task<int> SaveQuoterAsync(Quoter quoter)
        {
            await _database.InsertAsync(quoter);
            return quoter.QuoterID;
        }
        public Task<int> SaveQuoteAsync(Quote quote)
        {
            return _database.InsertAsync(quote);
        }
    }
}
