using KisiselYapilacaklarApp.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.EntityLayer.Concrete
{
    public class ToDoListWeek : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Week { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Completed { get; set; }
    }
}
