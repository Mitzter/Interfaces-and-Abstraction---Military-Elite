
using Interfaces_and_Abstraction___Military_Elite.Models.Interfaces;
using Interfaces_and_Abstraction___Military_Elite.Models.Sets;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_and_Abstraction___Military_Elite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<Mission> missionList;
        private readonly List<Commando> commandoList = new List<Commando>();

        public Commando(decimal salary, int id, string firstName, string lastName, string corps, List<Mission> missionList) : base(corps, id, firstName, lastName, salary)
        {
            this.missionList = new List<Mission>();
            this.MissionList = missionList;
            
        }
        public List<Mission> MissionList
        {
            get { return missionList; }
            set { missionList = value; }
        }
        public void AddCommandoToList(decimal salary, int id, string firstName, string lastName, string corps, List<Mission> missionList)
        {
            Commando soldier = new Commando(salary, id, firstName, lastName, corps, missionList);
            commandoList.Add(soldier);

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (Commando commando in commandoList)
            {
                sb.AppendLine($"Name: {commando.FirstName} {commando.LastName} Id: {commando.ID} Salary: {commando.Salary:F2}");
                sb.AppendLine($"Corps: {commando.Corps}");
                sb.AppendLine("Missions: ");
                foreach (var item in commando.MissionList)
                {
                   
                    sb.AppendLine(item.ToString());
                }

            }
            return sb.ToString().TrimEnd();
        }
    }
}
