using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace LocalDatabaseTutorial
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>().Wait();
        }

        public async Task<List<Person>> GetPeopleAsync()
        {
            //return _database.Table<Person>().ToListAsync();

            //await Task.Delay(3000);

            //return new List<Person>
            //{
            //    new Person{Name = "Alice", Age = 25},
            //    new Person { Name = "Bob", Age = 30 },
            //    new Person { Name = "Charlie", Age = 35 }
            //};
        }

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }
    }
}