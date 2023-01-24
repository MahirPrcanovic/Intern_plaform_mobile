
using SQLite;

namespace People.Models
{
    [Table("comments")]
    public class Comments
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateTime dateCreated = DateTime.Now;
        public Student student;
        #nullable enable
        public User? user;
    }
}
