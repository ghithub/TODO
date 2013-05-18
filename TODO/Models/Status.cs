using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TODO.Models
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string Name { get; set; }
    }
}