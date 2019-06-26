using KisiselYapilacaklarApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.BusinessLayer.Abstract
{
    public interface INoteManager
    {
        List<Note> GetAll();
        Note GetById(int Id);
        void Add(Note note);
        void Update(int Id, Note note);
        void Delete(int Id);
    }
}
