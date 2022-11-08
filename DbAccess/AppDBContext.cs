using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DbAccess.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccess
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) { }
        public DbSet<TeamModel> Teams { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<TeamSponsor> TeamSponsors { get; set; }
    }
}
