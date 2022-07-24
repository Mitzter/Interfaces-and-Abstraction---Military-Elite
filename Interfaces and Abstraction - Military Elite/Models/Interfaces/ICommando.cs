

namespace Interfaces_and_Abstraction___Military_Elite.Models.Interfaces
{

    using Interfaces_and_Abstraction___Military_Elite.Models.Sets;
    using System.Collections.Generic;
    
    public interface ICommando : ISpecialisedSoldier
    {
        public List<Mission> MissionList { get; set; }
    }
}
