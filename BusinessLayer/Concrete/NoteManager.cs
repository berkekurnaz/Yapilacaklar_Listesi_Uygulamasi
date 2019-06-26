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
    public class NoteManager : INoteManager
    {

        NoteDal noteDal = new NoteDal();

        public List<Note> GetAll()
        {
            return noteDal.GetAll();
        }

        public Note GetById(int Id)
        {
            var note = noteDal.GetById(Id);
            if(note == null)
            {
                throw new Exception("Error");
            }
            return note;
        }

        public void Add(Note note)
        {
            try
            {
                if (note.Title.Length > 3)
                {
                    noteDal.Add(note);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void Update(int Id, Note note)
        {
            try
            {
                if (note.Title.Length > 3)
                {
                    noteDal.Update(Id, note);
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
                noteDal.Delete(Id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

    }
}
