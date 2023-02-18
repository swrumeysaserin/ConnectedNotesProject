using ConnectedNotesProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedNotesProject.Entities.Model
{
    public class Note : EveryEntitiy
    {

        public string Content { get; set; }

        [ForeignKey("ConnectedNoteId")]
        public int? ConnectedNoteId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public Note ConnectedNote { get; set; }

        public User User { get; set; }

        public List<Note> Childs { get; set; }
    }
}
