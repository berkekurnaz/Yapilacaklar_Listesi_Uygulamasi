using KisiselYapilacaklarApp.DataAccessLayer.Abstract;
using KisiselYapilacaklarApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.DataAccessLayer.Concrete
{
    public class ToDoListWeekDal : IToDoListWeekDal
    {

        AppSQLiteConnection connection = new AppSQLiteConnection();

        public List<ToDoListWeek> GetAll()
        {
            List<ToDoListWeek> todos = new List<ToDoListWeek>();
            string query = "Select * From ToDoListWeek";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            SQLiteDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                ToDoListWeek todo = new ToDoListWeek();
                todo.Id = Convert.ToInt16(dr["Id"]);
                todo.Title = dr["Title"].ToString();
                todo.Week = Convert.ToInt16(dr["Week"]);
                todo.Month = Convert.ToInt16(dr["Month"]);
                todo.Year = Convert.ToInt16(dr["Year"]);
                todo.Completed = dr["Completed"].ToString();
                todos.Add(todo);
            }
            dr.Close();
            connection.Connection().Close();
            return todos;
        }

        public ToDoListWeek GetById(int Id)
        {
            ToDoListWeek todo = new ToDoListWeek();
            string query = "Select * From ToDoListWeek Where Id=@p1";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", Id);
            SQLiteDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                todo.Id = Convert.ToInt16(dr["Id"]);
                todo.Title = dr["Title"].ToString();
                todo.Week = Convert.ToInt16(dr["Week"]);
                todo.Month = Convert.ToInt16(dr["Month"]);
                todo.Year = Convert.ToInt16(dr["Year"]);
                todo.Completed = dr["Completed"].ToString();
            }
            dr.Close();
            connection.Connection().Close();
            return todo;
        }

        public void Add(ToDoListWeek toDoListWeek)
        {
            string query = "Insert Into ToDoListWeek (Title,Week,Month,Year,Completed) Values (@p1,@p2,@p3,@p4,@p5)";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", toDoListWeek.Title);
            command.Parameters.AddWithValue("@p2", toDoListWeek.Week);
            command.Parameters.AddWithValue("@p3", toDoListWeek.Month);
            command.Parameters.AddWithValue("@p4", toDoListWeek.Year);
            command.Parameters.AddWithValue("@p5", toDoListWeek.Completed);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

        public void Update(int Id, ToDoListWeek toDoListWeek)
        {
            string query = "Update ToDoListWeek set Title=@p1, Week=@p2, Month=@p3, Year=@p4, Completed=@p5 where Id=@p6";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", toDoListWeek.Title);
            command.Parameters.AddWithValue("@p2", toDoListWeek.Week);
            command.Parameters.AddWithValue("@p3", toDoListWeek.Month);
            command.Parameters.AddWithValue("@p4", toDoListWeek.Year);
            command.Parameters.AddWithValue("@p5", toDoListWeek.Completed);
            command.Parameters.AddWithValue("@p6", toDoListWeek.Id);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

        public void UpdateOnlyMainSections(int Id, ToDoListWeek toDoListWeek)
        {
            string query = "Update ToDoListWeek set Title=@p1, Completed=@p2 where Id=@p3";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", toDoListWeek.Title);
            command.Parameters.AddWithValue("@p2", toDoListWeek.Completed);
            command.Parameters.AddWithValue("@p3", Id);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

        public void UpdateCompletedStatus(int Id, string completedStatus)
        {
            if (completedStatus == "Tamamlandı")
            {
                string query = "Update ToDoListWeek set Completed=@p1 where Id=@p2";
                SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
                command.Parameters.AddWithValue("@p1", "Tamamlanmadı");
                command.Parameters.AddWithValue("@p2", Id);
                command.ExecuteNonQuery();
                connection.Connection().Close();
            }
            else
            {
                string query = "Update ToDoListWeek set Completed=@p1 where Id=@p2";
                SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
                command.Parameters.AddWithValue("@p1", "Tamamlandı");
                command.Parameters.AddWithValue("@p2", Id);
                command.ExecuteNonQuery();
                connection.Connection().Close();
            }
        }

        public void Delete(int Id)
        {
            string query = "Delete From ToDoListWeek Where Id=@p1";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", Id);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

    }
}
