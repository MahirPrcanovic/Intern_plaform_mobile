using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace People.Models
{
    [Table("students")]
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string EducationLevel { get; set; } = string.Empty;

        public string CoverLetter { get; set; } = string.Empty;
        public string CV { get; set; } = string.Empty;
    }
}
