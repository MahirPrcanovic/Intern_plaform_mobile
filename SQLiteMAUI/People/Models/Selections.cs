using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Models
{
    [Table("selections")]
    public class Selections
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public String SelectionName { get; set; } = string.Empty;
        public String Description { get; set; } = string.Empty;
        public DateTime DateOfStart { get; set; } = DateTime.Now;
        public DateTime DateOfEnd { get; set; }
        [ForeignKey(typeof(User))]
        public int UserID { get; set; }
    }
}
