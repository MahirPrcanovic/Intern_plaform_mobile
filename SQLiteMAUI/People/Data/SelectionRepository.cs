using People.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Data
{
    public class SelectionRepository
    {
        public string StatusMessage { get; set; }
        private SQLiteConnection conn;
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(Database.DatabasePath, Database.Flags);
            conn.CreateTable<Selections>();
        }
        public void AddNewSelection(Selections selection)
        {
            int result = 0;
            try
            {
                Init();
                if (string.IsNullOrEmpty(selection.SelectionName))
                    throw new Exception("Molimo unesite validno ime selekcije!?");
                result = conn.Insert(selection);
                StatusMessage = string.Format("{0} zapis(a) dodano (Selekcija: {1})", result, selection.SelectionName);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće dodati {0}. Greška: {1}", selection.SelectionName, ex.Message);
            }
        }
        public List<Selections> GetAllSelections()
        {
            try
            {
                Init();
                return conn.Table<Selections>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće isčitati podatke iz baze. {0}", ex.Message);
            }
            return new List<Selections>();
        }
    }
}
