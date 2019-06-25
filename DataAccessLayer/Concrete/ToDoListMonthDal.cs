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
    public class ToDoListMonthDal : IToDoListMonthDal
    {

        AppSQLiteConnection connection = new AppSQLiteConnection();

        public List<ToDoListMonth> GetAll()
        {
            List<ToDoListMonth> todos = new List<ToDoListMonth>();
            string query = "Select * From ToDoListMonth";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            SQLiteDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                ToDoListMonth todo = new ToDoListMonth();
                todo.Id = Convert.ToInt16(dr["Id"]);
                todo.Title = dr["Title"].ToString();
                todo.Month = Convert.ToInt16(dr["Month"]);
                todo.Year = Convert.ToInt16(dr["Year"]);
                todo.Completed = dr["Completed"].ToString();
                todos.Add(todo);
            }
            dr.Close();
            connection.Connection().Close();
            return todos;
        }

        public ToDoListMonth GetById(int Id)
        {
            ToDoListMonth todo = new ToDoListMonth();
            string query = "Select * From ToDoListMonth Where Id=@p1";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", Id);
            SQLiteDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                todo.Id = Convert.ToInt16(dr["Id"]);
                todo.Title = dr["Title"].ToString();
                todo.Month = Convert.ToInt16(dr["Month"]);
                todo.Year = Convert.ToInt16(dr["Year"]);
                todo.Completed = dr["Completed"].ToString();
            }
            dr.Close();
            connection.Connection().Close();
            return todo;
        }

        public void Add(ToDoListMonth toDoListMonth)
        {
            string query = "Insert Into ToDoListMonth (Title,Month,Year,Completed) Values (@p1,@p2,@p3,@p4)";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", toDoListMonth.Title);
            command.Parameters.AddWithValue("@p2", toDoListMonth.Month);
            command.Parameters.AddWithValue("@p3", toDoListMonth.Year);
            command.Parameters.AddWithValue("@p4", toDoListMonth.Completed);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

        public void Update(int Id, ToDoListMonth toDoListMonth)
        {
            string query = "Update ToDoListMonth set Title=@p1, Month=@p2, Year=@p3, Completed=@p4 where Id=@p5";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", toDoListMonth.Title);
            command.Parameters.AddWithValue("@p2", toDoListMonth.Month);
            command.Parameters.AddWithValue("@p3", toDoListMonth.Year);
            command.Parameters.AddWithValue("@p4", toDoListMonth.Completed);
            command.Parameters.AddWithValue("@p5", toDoListMonth.Id);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

        public void Delete(int Id)
        {
            string query = "Delete From ToDoListMonth Where Id=@p1";
            SQLiteCommand command = new SQLiteCommand(query, connection.Connection());
            command.Parameters.AddWithValue("@p1", Id);
            command.ExecuteNonQuery();
            connection.Connection().Close();
        }

    }
}
