using KisiselYapilacaklarApp.DataAccessLayer.Abstract;
using KisiselYapilacaklarApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.DataAccessLayer.Concrete
{
    public class NoteDal : INoteDal
    {

        AppSQLiteConnection connection = new AppSQLiteConnection();

        public List<Note> GetAll()
        {
            List<Note> notes = new List<Note>();
            string query = "Select * From Note Order By Id Desc";
            SQLiteCommand command = new SQLiteCommand(query,connection.Connection());
            SQLiteDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                Note note = new Note();
                note.Id = Convert.ToInt16(dr["Id"]);
                note.Title = dr["Title"].ToString();
                note.Content = dr["Content"].ToString();
                note.CreatedDate = dr["CreatedDate"].ToString();
                note.Status = dr["Status"].ToString();
                notes.Add(note);
            }
            dr.Close();
            connection.Connection().Close();
            return notes;
        }

        public Note GetById(int Id)
        {
            Note note = new Note();
            string query = "Select * From Note Where Id=@p1";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", Id);
            SQLiteDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                note.Id = Convert.ToInt16(dr["Id"]);
                note.Title = dr["Title"].ToString();
                note.Content = dr["Content"].ToString();
                note.CreatedDate = dr["CreatedDate"].ToString();
                note.Status = dr["Status"].ToString();
            }
            dr.Close();
            connection.Connection().Close();
            return note;
        }

        public void Add(Note note)
        { 
            string query = "Insert Into Note (Title,Content,CreatedDate,Status) Values (@p1,@p2,@p3,@p4)";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", note.Title);
            command.Parameters.AddWithValue("@p2", note.Content);
            command.Parameters.AddWithValue("@p3", note.CreatedDate);
            command.Parameters.AddWithValue("@p4", note.Status);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

        public void Update(int Id, Note note)
        {
            string query = "Update Note set Title=@p1, Content=@p2, CreatedDate=@p3, Status=@p4 where Id=@p5";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", note.Title);
            command.Parameters.AddWithValue("@p2", note.Content);
            command.Parameters.AddWithValue("@p3", note.CreatedDate);
            command.Parameters.AddWithValue("@p4", note.Status);
            command.Parameters.AddWithValue("@p5", note.Id);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

        public void Delete(int Id)
        {
            string query = "Delete From Note Where Id=@p1";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", Id);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

    }
}
