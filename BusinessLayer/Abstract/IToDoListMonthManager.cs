using KisiselYapilacaklarApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.BusinessLayer.Abstract
{
    public interface IToDoListMonthManager
    {
        List<ToDoListMonth> GetAll();
        ToDoListMonth GetById(int Id);
        void Add(ToDoListMonth toDoListMonth);
        void Update(int Id, ToDoListMonth toDoListMonth);
        void Delete(int Id);
    }
}
