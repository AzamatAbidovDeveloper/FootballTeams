using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DbAccess.Models
{
    public class TeamModel
    {
        public int ID { get; set; }
        public int UEFACups { get; set; }
        public string Coach { get; set; }
        [Required]
        public DateTime FoundingDate { get; set; }
        public string Stadium { get; set; }
        [Required]
        [MinLength(3), MaxLength(50)]
        public string Team { get; set; }
        [Required]
        [MinLength(3), MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        public string? TeamVideo { get; set; }
        //Foreign key
        public int? SponsorID { get; set; }
        [ForeignKey(nameof(SponsorID))]
        //Navigation property
        public TeamSponsor? Sponsor { get; set; }
        public int? CountryID { get; set; }
        [ForeignKey(nameof(CountryID))]
        public Country? Country { get; set; }
    }
}
