using ConnectedNotesProject.Bussiness.Abstract;
using ConnectedNotesProject.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectedNotesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : BaseController<Note>
    {
        private readonly INoteService  _noteRepository;
        public NoteController(INoteService noteRepository,IGenericService<Note> genericRepository) : base(genericRepository)
        {
            _noteRepository = noteRepository;
        }     

        public IActionResult ChangeStatus(Note note)
        {
            _noteRepository.ChangeStatus(note);
            return Ok();
        }
        public IActionResult LoadChildren(Note thisNote, List<Note> allNotes)
        {
            _noteRepository.LoadChildren(thisNote, allNotes);
            return Ok();
        }
    }
}
