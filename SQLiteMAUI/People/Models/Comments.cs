
using Microsoft.Maui.Graphics;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace People.Models
{
    [Table("comments")]
    public class Comments
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [ForeignKey(typeof(Student))]
        public int StudentId { get; set; }
        [ForeignKey(typeof(User))]
        public int UserId { get; set; }
    }
}
