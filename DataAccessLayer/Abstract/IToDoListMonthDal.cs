using KisiselYapilacaklarApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.DataAccessLayer.Abstract
{
    public interface IToDoListMonthDal
    {
        List<ToDoListMonth> GetAll();
        ToDoListMonth GetById(int Id);
        void Add(ToDoListMonth toDoListMonth);
        void Update(int Id, ToDoListMonth toDoListMonth);
        void UpdateOnlyMainSections(int Id, ToDoListMonth toDoListMonth);
        void UpdateCompletedStatus(int Id, string completedStatus);
        void Delete(int Id);
    }
}
