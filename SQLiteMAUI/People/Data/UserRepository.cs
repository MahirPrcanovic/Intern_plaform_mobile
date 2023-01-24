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
        private SQLiteConnection conn;

        private void Init()
        {
            // TODO: Add code to initialize the repository
            if (conn != null)
                return;
            conn = new SQLiteConnection(Database.DatabasePath, Database.Flags);
            conn.CreateTable<User>();
        }
        public void AddNewUser(string email,string password)
        {
            int result = 0;
            try
            {
                // TODO: Call Init()
                 Init();

                // basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                    throw new Exception("Molimo unesite validno ime!?");

                // TODO: Insert the new person into the database
                result =  conn.Insert(new User { Email = email,Password=password });

                StatusMessage = string.Format("{0} zapis(a) dodano (Student: {1})", result, email);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće dodati {0}. Greška: {1}", email, ex.Message);
            }

        }
        public bool DoesExist(string email,string password)
        {
            User found = null;
            try
            {
                Init();
                found = conn.Table<User>().FirstOrDefault(x => x.Email == email && x.Password==password);
                if(found == null)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće dodati {0}. Greška: {1}", email, ex.Message);
                return false;
            }
        }
        public User getUser(String email)
        {
            User found = null;
            try
            {
                Init();
                found = conn.Table<User>().FirstOrDefault(x => x.Email == email);
                return found;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće dodati {0}. Greška: {1}", email, ex.Message);
                return null;
            }
        }
}
}
