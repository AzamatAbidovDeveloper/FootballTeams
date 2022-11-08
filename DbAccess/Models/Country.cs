using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DbAccess.Models
{
    public class Country
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Image { get; set; }
        public IEnumerable<TeamModel>? Teams { get; set; }
    }
}
