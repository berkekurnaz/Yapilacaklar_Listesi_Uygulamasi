using KisiselYapilacaklarApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.DataAccessLayer.Abstract
{
    public interface IToDoListWeekDal
    {
        List<ToDoListWeek> GetAll();
        ToDoListWeek GetById(int Id);
        void Add(ToDoListWeek toDoListWeek);
        void Update(int Id, ToDoListWeek toDoListWeek);
        void Delete(int Id);
    }
}
