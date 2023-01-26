using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Models
{
    [Table("SelectionStudents")]
    public class SelectionStudents
    {
        [ForeignKey(typeof(Student))]
        public int StudentID { get; set; }
        [ForeignKey(typeof(Selections))]
        public int SelectionID { get; set; }
    }
}
