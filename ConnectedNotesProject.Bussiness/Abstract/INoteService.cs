using ConnectedNotesProject.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedNotesProject.Bussiness.Abstract
{
    public interface INoteService : IGenericService<Note>
    {
        void ChangeStatus(Note note);

        void LoadChildren(Note thisNote, List<Note> allNotes);
    }
}
