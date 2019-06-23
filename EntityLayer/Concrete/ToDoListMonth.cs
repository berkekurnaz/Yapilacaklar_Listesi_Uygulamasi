using KisiselYapilacaklarApp.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.EntityLayer.Concrete
{
    public class ToDoListMonth : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Completed { get; set; }
    }
}
