using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbAccess.Models
{
    public class TeamSponsor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string StudioDescription { get; set; }
        public IEnumerable<TeamModel>? Teams { get; set; }
    }
}
