using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedNotesProject.Entities.Abstract
{
    public abstract class EveryEntitiy
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
