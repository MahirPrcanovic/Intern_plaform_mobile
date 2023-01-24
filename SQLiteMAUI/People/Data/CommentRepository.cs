using People.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Data
{
    public class CommentRepository
    {
        public string StatusMessage { get; set; }

        private SQLiteConnection conn;

        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(Database.DatabasePath, Database.Flags);
            conn.CreateTable<Comments>();
        }
        public List<Comments> GetAllComments()
        {
            try
            {
                Init();
                return conn.Table<Comments>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće isčitati podatke iz baze. {0}", ex.Message);
            }
            return new List<Comments>();
        }
        public void AddNewComment(Comments comment)
        {
            int result = 0;
            try
            {
                Init();
                result = conn.Insert(comment);
                var student = App.PersonRepository.GetSingleStudent(comment.StudentId);
                student.Comments.Add(comment);
                var user = App.UserRepository.getByID(comment.UserId);
                user.Comments.Add(comment);
                conn.Update(student);
                conn.Update(user);
                //var student = App.UserRepository.getUser(comment.user.Email);
                //student.Comments.Add(comment);
                StatusMessage = string.Format("{0} zapis(a) dodano (Student: {1})", result, comment.CommentText);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće dodati {0}. Greška: {1}", comment.CommentText, ex.Message);
            }
        }
        public List<Comments> GetAllStudentsComments(int studentID)
        {
            try
            {
                Init();
                return conn.Table<Comments>().Where(x=>x.StudentId== studentID).ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće isčitati podatke iz baze. {0}", ex.Message);
            }
            return new List<Comments>();
        }
    }
}
