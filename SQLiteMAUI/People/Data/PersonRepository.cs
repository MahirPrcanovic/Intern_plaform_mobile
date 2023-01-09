 using People.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Data
{
    // Jedna klasa u kojoj se definira manipualcija sa podacima vezanim za klasu Student
    public class StudentRepository
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
            conn.CreateTable<Student>();
        }

        public void AddNewStudent(string name)
        {
            int result = 0;
            try
            {
                // TODO: Call Init()
                Init();

                // basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Molimo unesite validno ime!?");

                // TODO: Insert the new person into the database
                result = conn.Insert(new Student { Email = name });

                StatusMessage = string.Format("{0} zapis(a) dodano (Student: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće dodati {0}. Greška: {1}", name, ex.Message);
            }

        }

        public List<Student> GetAllStudents()
        {
            // TODO: Init then retrieve a list of Person objects from the database into a list
            try
            {
                Init();
                return conn.Table<Student>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće isčitati podatke iz baze. {0}", ex.Message);
            }

            return new List<Student>();
        }
    }
}
