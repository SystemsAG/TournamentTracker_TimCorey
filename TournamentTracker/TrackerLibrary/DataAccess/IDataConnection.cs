using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    /// <summary>
    /// This interface needed to set up the connection to the sql table
    /// </summary>
   public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
        TeamModel CreateTeam(TeamModel model);
        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();
    }
}
