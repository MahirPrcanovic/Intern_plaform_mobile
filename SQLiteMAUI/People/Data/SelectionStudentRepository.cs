using People.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Data
{
    public class SelectionStudentRepository
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
            conn.CreateTable<SelectionStudents>();
        }
        public void AddNewfield(int selectionID,int studentID)
        {
            int result = 0;
            try
            {
                Init();
                result = conn.Insert(new SelectionStudents { SelectionID=selectionID,StudentID=studentID});
                StatusMessage = string.Format("{0} zapis(a) dodano (Student: {1})", result, selectionID);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće dodati {0}. Greška: {1}", selectionID, ex.Message);
            }

        }
        public List<Selections> getAllStudentSelections(int studentID)
        {
            // TODO: Init then retrieve a list of Person objects from the database into a list
            try
            {
                List<Selections> list = new List<Selections>();
                Init();
                var found =conn.Table<SelectionStudents>().Where(x=>x.StudentID == studentID).ToList();
                for(int i =0;i<found.Count; i++)
                {
                    list.Add(App.SelectionRepository.GetSelection(found[i].SelectionID));
                }
                return list;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće isčitati podatke iz baze. {0}", ex.Message);
            }

            return new List<Selections>();
        }
        public List<Student> getAllSelectionStudents(int selectionID)
        {
            // TODO: Init then retrieve a list of Person objects from the database into a list
            try
            {
                List<Student> list = new List<Student>();
                Init();
                var found = conn.Table<SelectionStudents>().Where(x => x.SelectionID == selectionID).ToList();
                for (int i = 0; i < found.Count; i++)
                {
                    list.Add(App.PersonRepository.GetSingleStudent(found[i].StudentID));
                }
                return list;
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće isčitati podatke iz baze. {0}", ex.Message);
            }

            return new List<Student>();
        }
    }
}
