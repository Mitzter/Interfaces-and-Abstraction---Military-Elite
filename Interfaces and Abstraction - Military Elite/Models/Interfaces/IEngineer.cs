

namespace Interfaces_and_Abstraction___Military_Elite.Models.Interfaces
{

    using Interfaces_and_Abstraction___Military_Elite.Models.Sets;
    using System.Collections.Generic;
    
    public interface IEngineer : ISpecialisedSoldier
    {
        public List<Repair> RepairList { get; set; }
    }
}
