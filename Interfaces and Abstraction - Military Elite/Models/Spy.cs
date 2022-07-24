


namespace Interfaces_and_Abstraction___Military_Elite.Models

{
    using Interfaces_and_Abstraction___Military_Elite.Models.Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class Spy : Soldier, ISpy
    {
        private int codeNumber;
        private readonly List<Spy> spyList = new List<Spy>();

        public Spy(int id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
        {
            this.codeNumber = CodeNumber;
            
        }

        public  int CodeNumber
        {
            get { return codeNumber; }
            set { codeNumber = value; }
        }
        public void AddSpyToList(int id, string firstName, string lastName, int codeNumber)
        {
            spyList.Add(new Spy(id, firstName, lastName, codeNumber));
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (Spy spy in spyList)
            {
                string firstName = spy.FirstName;
                string lastName = spy.LastName;
                int id = spy.ID;
                int codeNumber = spy.CodeNumber;


                sb.AppendLine($"Name: {firstName} {lastName} Id: {id}");
                sb.AppendLine($"Code Number: {codeNumber}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
