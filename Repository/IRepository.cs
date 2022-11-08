using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbAccess.Models;

namespace WebApp_2.Repository
{
    public interface IRepository
    {
        List<TeamModel> GetTeams();
        List<Country> GetCountries();
        List<TeamSponsor> GetSponsors();
        Country GetCountryByID(int id);
        TeamModel GetTeamByID(int id);
        bool CreateNewTeam(TeamModel newTeam);
        bool EditTeam(TeamModel editTeam);
        bool DeleteTeam(TeamModel newTeam);

        bool EditCountry(Country editCountry);
        bool AddCountry(Country newCountry);

    }
}
