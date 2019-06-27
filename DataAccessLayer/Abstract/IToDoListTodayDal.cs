using KisiselYapilacaklarApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.DataAccessLayer.Abstract
{
    public interface IToDoListTodayDal
    {
        List<ToDoListToday> GetAll();
        ToDoListToday GetById(int Id);
        void Add(ToDoListToday toDoListToday);
        void Update(int Id, ToDoListToday toDoListToday);
        void UpdateOnlyMainSections(int Id, ToDoListToday toDoListToday);
        void UpdateCompletedStatus(int Id, string completedStatus);
        void Delete(int Id);
    }
}
