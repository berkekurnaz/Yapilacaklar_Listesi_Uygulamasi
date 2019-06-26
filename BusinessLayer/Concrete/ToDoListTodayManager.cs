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
    public class ToDoListTodayManager : IToDoListTodayManager
    {

        ToDoListTodayDal toDoListTodayDal = new ToDoListTodayDal();

        public List<ToDoListToday> GetAll()
        {
            return toDoListTodayDal.GetAll();
        }

        public ToDoListToday GetById(int Id)
        {
            var todo = toDoListTodayDal.GetById(Id);
            if (todo == null)
            {
                throw new Exception("Error");
            }
            return todo;
        }

        public void Add(ToDoListToday toDoListToday)
        {
            try
            {
                if (toDoListToday.Title.Length > 2)
                {
                    toDoListTodayDal.Add(toDoListToday);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(int Id, ToDoListToday toDoListToday)
        {
            try
            {
                if (toDoListToday.Title.Length > 2)
                {
                    toDoListTodayDal.Update(Id, toDoListToday);
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
                toDoListTodayDal.Delete(Id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

    }
}
