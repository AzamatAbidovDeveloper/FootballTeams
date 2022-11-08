using DbAccess.Models;
using System;
using System.Collections.Generic;
using DbAccess;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_2.Repository
{
    public class SqlRepository : IRepository
    {
        private readonly AppDBContext _db;
        public SqlRepository(AppDBContext db)
        {
            _db = db;
        }
        public bool CreateNewTeam(TeamModel newTeam)
        {
            if (newTeam is null) return false;

            _db.Add(newTeam);
            _db.SaveChanges();
            return true;
        }
        public bool EditTeam(TeamModel editTeam)
        {
            if (editTeam is null) return false;

            _db.Teams.Update(editTeam);
            _db.SaveChanges();
            return true;
        }
        public bool DeleteTeam(TeamModel team)
        {
            if (team is null) return false;

            _db.Remove(team);
            _db.SaveChanges();
            return true;
        }
        public bool AddCountry(Country newCountry)
        {
            if (newCountry is null) return false;

            _db.Add(newCountry);
            _db.SaveChanges();
            return true;
        }

        public bool EditCountry(Country editCountry)
        {
            if (editCountry is null) return false;

            _db.Countries.Update(editCountry);
            _db.SaveChanges();
            return true;
        }

        public List<Country> GetCountries()
        {
            var countries = _db.Countries.ToList();
            return countries;
        }

        public Country GetCountryByID(int id)
        {
            var country = _db.Countries.FirstOrDefault(x => x.ID == id);
            return country;
        }

        public List<TeamSponsor> GetSponsors()
        {
            var sponsors = _db.TeamSponsors.ToList();
            return sponsors;
        }

        public TeamModel GetTeamByID(int id)
        {
            var team = _db.Teams.FirstOrDefault(x => x.ID == id);
            return team;
        }

        public List<TeamModel> GetTeams()
        {
            var teams = _db.Teams.ToList();
            return teams;
        }      
    }
}
