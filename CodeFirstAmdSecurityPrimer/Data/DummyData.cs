using CodeFirstAmdSecurityPrimer.Models.NHL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace CodeFirstAmdSecurityPrimer.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Team> getTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team()
                {
                    TeamName="Canucks",
                    City="Vancouver",
                    Province="BC",
                }
            };
            return teams;
        }
        public static List<Player> getPlayers(NhlContext context)
        {
            List<Player> players = new List<Player>()
            {
                new Player()
                {
                    FirstName="Bob",
                    LastName="Plumber",
                    TeamName=context.Teams.Find("Canucks").TeamName,
                    Position="Defense",
                }
            };
            return players;
        }
    }
}