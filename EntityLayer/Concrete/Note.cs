using KisiselYapilacaklarApp.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.EntityLayer.Concrete
{
    public class Note : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreatedDate { get; set; }
        public string Status { get; set; }
    }
}
