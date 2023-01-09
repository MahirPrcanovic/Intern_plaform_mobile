using People.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Data
{
    public class UserRepository
    {
        public string StatusMessage { get; set; }

        // TODO: Add variable for the SQLite connection
        private SQLiteAsyncConnection conn;

        private async Task Init()
        {
            // TODO: Add code to initialize the repository
            if (conn != null)
                return;
            conn = new SQLiteAsyncConnection(Database.DatabasePath, Database.Flags);
            await conn.CreateTableAsync<User>();
        }
        public async Task AddNewUser(string email,string password)
        {
            int result = 0;
            try
            {
                // TODO: Call Init()
                await Init();

                // basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                    throw new Exception("Molimo unesite validno ime!?");

                // TODO: Insert the new person into the database
                result = await conn.InsertAsync(new User { Email = email,Password=password });

                StatusMessage = string.Format("{0} zapis(a) dodano (Student: {1})", result, email);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće dodati {0}. Greška: {1}", email, ex.Message);
            }

        }
    }
}
