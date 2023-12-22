using System;
using System.Collections.Generic;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class StoreOverseer : Personnel, IManager
    {
        public HashSet<IManaged> Team { get; set; }
        
        public void AssignTeam(IManaged teamMember)
        {
            Team.Add(teamMember);
        }

        public void GenerateWeeklyReport()
        {
            Console.WriteLine($"Weekly report: {nameof(StoreOverseer)} {FirstName} {LastName} reporting.");
        }
    }
}