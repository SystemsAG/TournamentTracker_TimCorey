﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one tournament, with all of the rounds, matchups, prizes and outcomes.
    /// </summary>
   public class TournamentModel
    {
        /// <summary>
        /// The name given to this tournament
        /// </summary>
        public string TournamentName{ get; set; }

        /// <summary>
        /// The amount of money each team needs to put up tho enter
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// The set of teams that have been entered.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// The list of prizes for the various places
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// The matchup per round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
