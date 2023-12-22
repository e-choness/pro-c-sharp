using System;
using System.Collections.Generic;
using SolidLibrary.Interfaces;

namespace SolidLibrary.Models
{
    public class StoreSupervisor : Personnel, IManager, IManaged
    {
        public HashSet<IManaged> Team { get; set; }
        public IManager Manager { get; set; }
        
        public void AssignTeam(IManaged teamMember)
        {
            Team.Add(teamMember);
        }
        
        public void AssignManager(IManager manager)
        {
            Manager = manager;
        }

        public void GenerateWeeklyReport()
        {
            Console.WriteLine($"Weekly report: {nameof(StoreSupervisor)} {FirstName} {LastName} is reporting.");
        }
    }
}