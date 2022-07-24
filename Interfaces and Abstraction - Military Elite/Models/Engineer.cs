


namespace Interfaces_and_Abstraction___Military_Elite.Models
{
    using Interfaces_and_Abstraction___Military_Elite.Models.Interfaces;
    using Interfaces_and_Abstraction___Military_Elite.Models.Sets;
    using System.Collections.Generic;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<Repair> repairList;
        private readonly List<Engineer> engineerList = new List<Engineer>();
        public Engineer(string corps, int id, string firstName, string lastName, decimal salary, List<Repair> repairList) : base(corps, id, firstName, lastName, salary)
        {
            this.repairList = new List<Repair>();
            this.RepairList = repairList;
            
            
        }
        public List<Repair> RepairList
        {
            get
            {
                return this.repairList;
            }
            set
            {
                this.repairList = value;
            }
        }
        public void AddEngineerToList(string corps, int id, string firstName, string lastName, decimal salary, List<Repair> repairList)
        {
            Engineer soldier = new Engineer(corps ,id, firstName, lastName, salary, repairList);
            engineerList.Add(soldier);

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (Engineer engineer in engineerList)
            {
                sb.AppendLine($"Name: {engineer.FirstName} {engineer.LastName} Id: {engineer.ID} Salary: {engineer.Salary:f2}");
                sb.AppendLine($"Corps: {engineer.Corps}");
                sb.AppendLine("Repairs: ");
                foreach (var item in engineer.RepairList)
                {
                    sb.AppendLine(item.ToString());
                }

            }
            return sb.ToString().TrimEnd();
        }

    }
}
