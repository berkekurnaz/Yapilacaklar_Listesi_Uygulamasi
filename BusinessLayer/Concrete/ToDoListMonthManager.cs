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
    public class ToDoListMonthManager : IToDoListMonthManager
    {

        ToDoListMonthDal toDoListMonthDal = new ToDoListMonthDal();

        public List<ToDoListMonth> GetAll()
        {
            return toDoListMonthDal.GetAll();
        }

        public ToDoListMonth GetById(int Id)
        {
            var todo = toDoListMonthDal.GetById(Id);
            if (todo == null)
            {
                throw new Exception("Error");
            }
            return todo;
        }

        public void Add(ToDoListMonth toDoListMonth)
        {
            try
            {
                if (toDoListMonth.Title.Length > 2)
                {
                    toDoListMonthDal.Add(toDoListMonth);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(int Id, ToDoListMonth toDoListMonth)
        {
            try
            {
                if (toDoListMonth.Title.Length > 2)
                {
                    toDoListMonthDal.Update(Id, toDoListMonth);
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
                toDoListMonthDal.Delete(Id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

    }
}
