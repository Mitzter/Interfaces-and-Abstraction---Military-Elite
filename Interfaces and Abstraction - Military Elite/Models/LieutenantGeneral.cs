


namespace Interfaces_and_Abstraction___Military_Elite.Models
{
    using Interfaces_and_Abstraction___Military_Elite.Models.Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<Private> commandList;
        private readonly List<LieutenantGeneral> ltGeneralList = new List<LieutenantGeneral>();

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, List<Private> commandList) : base(id, firstName, lastName, salary)
        {

            this.commandList = new List<Private>();
            this.CommandList = commandList;
            

        }

        public List<Private> CommandList
        {
            get { return commandList; }
            set { commandList = value; }

        }
        public void AddLtGeneralToList(int id, string firstName, string lastName, decimal salary, List<Private> commandList)
        {
            LieutenantGeneral soldier = new LieutenantGeneral(id, firstName, lastName, salary, commandList);
            ltGeneralList.Add(soldier);

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (LieutenantGeneral lieutenant in ltGeneralList)
            {
                string firstName = lieutenant.FirstName;
                string lastName = lieutenant.LastName;
                int id = lieutenant.ID;
                decimal salary = lieutenant.Salary;
                sb.AppendLine($"Name: {firstName} {lastName} Id: {id} Salary: {salary:f2}");
                sb.AppendLine("Privates: ");
                foreach (var item in lieutenant.CommandList)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
