using ConnectedNotesProject.Bussiness.Abstract;
using ConnectedNotesProject.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedNotesProject.Bussiness.Concrete
{
    public class NoteRepository : GenericRepository<Note>, INoteService
    {
        Context _database;
        public NoteRepository(Context database) : base(database)
        {
            _database = database;
        }

        public void ChangeStatus(Note note)
        {
            note.Status = false;
            Update(note);
        }

        public void LoadChildren(Note thisNote, List<Note> allNotes)
        {
            thisNote.Childs = allNotes.Where(n => n.ConnectedNoteId == thisNote.Id).ToList();

            foreach (var childNote in thisNote.Childs)
            {
                LoadChildren(childNote, allNotes);
            }
        }
    }
}
