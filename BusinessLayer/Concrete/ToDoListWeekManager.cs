using KisiselYapilacaklarApp.BusinessLayer.Abstract;
using KisiselYapilacaklarApp.DataAccessLayer.Concrete;
using KisiselYapilacaklarApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.BusinessLayer.Concrete
{
    public class ToDoListWeekManager : IToDoListWeekManager
    {

        ToDoListWeekDal toDoListWeekDal = new ToDoListWeekDal();

        public List<ToDoListWeek> GetAll()
        {
            return toDoListWeekDal.GetAll();
        }

        public ToDoListWeek GetById(int Id)
        {
            var todo = toDoListWeekDal.GetById(Id);
            if (todo == null)
            {
                throw new Exception("Error");
            }
            return todo;
        }

        public void Add(ToDoListWeek toDoListWeek)
        {
            try
            {
                if (toDoListWeek.Title.Length > 2)
                {
                    toDoListWeekDal.Add(toDoListWeek);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(int Id, ToDoListWeek toDoListWeek)
        {
            try
            {
                if (toDoListWeek.Title.Length > 2)
                {
                    toDoListWeekDal.Update(Id, toDoListWeek);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Delete(int Id)
        {
            try
            {
                toDoListWeekDal.Delete(Id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

    }
}
