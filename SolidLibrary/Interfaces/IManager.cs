using System.Collections.Generic;

namespace SolidLibrary.Interfaces
{
    public interface IManager : IPersonnel
    {
        HashSet<IManaged> Team { get; set; }

        void AssignTeam(IManaged teamMember);
        void GenerateWeeklyReport();
    }
}