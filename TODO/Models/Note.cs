using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TODO.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string Description { get; set; }
        public int? TaskId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? Modification { get; set; }
    }
}