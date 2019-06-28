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
    public class ToDoListTodayDal : IToDoListTodayDal
    {

        AppSQLiteConnection connection = new AppSQLiteConnection();

        public List<ToDoListToday> GetAll()
        {
            List<ToDoListToday> todos = new List<ToDoListToday>();
            string query = "Select * From ToDoListToday Order By Id Desc";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            SQLiteDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                ToDoListToday todo = new ToDoListToday();
                todo.Id = Convert.ToInt16(dr["Id"]);
                todo.Title = dr["Title"].ToString();
                todo.Day = Convert.ToInt16(dr["Day"]);
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

        public ToDoListToday GetById(int Id)
        {
            ToDoListToday todo = new ToDoListToday();
            string query = "Select * From ToDoListToday Where Id=@p1";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", Id);
            SQLiteDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                todo.Id = Convert.ToInt16(dr["Id"]);
                todo.Title = dr["Title"].ToString();
                todo.Day = Convert.ToInt16(dr["Day"]);
                todo.Week = Convert.ToInt16(dr["Week"]);
                todo.Month = Convert.ToInt16(dr["Month"]);
                todo.Year = Convert.ToInt16(dr["Year"]);
                todo.Completed = dr["Completed"].ToString();
            }
            dr.Close();
            connection.Connection().Close();
            return todo;
        }

        public void Add(ToDoListToday toDoListToday)
        {
            string query = "Insert Into ToDoListToday (Title,Day,Week,Month,Year,Completed) Values (@p1,@p2,@p3,@p4,@p5,@p6)";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", toDoListToday.Title);
            command.Parameters.AddWithValue("@p2", toDoListToday.Day);
            command.Parameters.AddWithValue("@p3", toDoListToday.Week);
            command.Parameters.AddWithValue("@p4", toDoListToday.Month);
            command.Parameters.AddWithValue("@p5", toDoListToday.Year);
            command.Parameters.AddWithValue("@p6", toDoListToday.Completed);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

        public void Update(int Id, ToDoListToday toDoListToday)
        {
            string query = "Update ToDoListToday set Title=@p1, Day=@p2, Week=@p3, Month=@p4, Year=@p5, Completed=@p6 where Id=@p7";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", toDoListToday.Title);
            command.Parameters.AddWithValue("@p2", toDoListToday.Day);
            command.Parameters.AddWithValue("@p3", toDoListToday.Week);
            command.Parameters.AddWithValue("@p4", toDoListToday.Month);
            command.Parameters.AddWithValue("@p5", toDoListToday.Year);
            command.Parameters.AddWithValue("@p6", toDoListToday.Completed);
            command.Parameters.AddWithValue("@p7", Id);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

        public void UpdateOnlyMainSections(int Id, ToDoListToday toDoListToday)
        {
            string query = "Update ToDoListToday set Title=@p1, Completed=@p2 where Id=@p3";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", toDoListToday.Title);
            command.Parameters.AddWithValue("@p2", toDoListToday.Completed);
            command.Parameters.AddWithValue("@p3", Id);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

        public void UpdateCompletedStatus(int Id, string completedStatus)
        {
            if (completedStatus == "Tamamlandı")
            {
                string query = "Update ToDoListToday set Completed=@p1 where Id=@p2";
                SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
                command.Parameters.AddWithValue("@p1", "Tamamlanmadı");
                command.Parameters.AddWithValue("@p2", Id);
                command.ExecuteNonQuery();
                connection.Connection().Close();
            }
            else
            {
                string query = "Update ToDoListToday set Completed=@p1 where Id=@p2";
                SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
                command.Parameters.AddWithValue("@p1", "Tamamlandı");
                command.Parameters.AddWithValue("@p2", Id);
                command.ExecuteNonQuery();
                connection.Connection().Close();
            }
        }

        public void Delete(int Id)
        {
            string query = "Delete From ToDoListToday Where Id=@p1";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", Id);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

    }
}
