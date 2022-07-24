


namespace Interfaces_and_Abstraction___Military_Elite.Models
{
    using Interfaces_and_Abstraction___Military_Elite.Models.Interfaces;
    using System;
    using System.Collections.Generic;

    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
        private readonly List<SpecialisedSoldier> ssList = new List<SpecialisedSoldier>();
        public SpecialisedSoldier(string corps, int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            
            this.Corps = corps;
            
        }

        public string Corps
        {
            get { return this.corps; }
            set
            {
                corps = value;
            }

        }

        
    }
}
