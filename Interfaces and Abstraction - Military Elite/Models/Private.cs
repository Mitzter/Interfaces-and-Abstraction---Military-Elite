

namespace Interfaces_and_Abstraction___Military_Elite.Models
{
    using Interfaces_and_Abstraction___Military_Elite.Models.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Private : Soldier, IPrivate
    {
        private readonly List<Private> privateList = new List<Private>();
        private decimal _salary;
        public Private(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }
        public decimal Salary
        {
            get { return this._salary; }
            set { this._salary = value; }
        }

        public void FindPrivate(int ID)
        {
            privateList.Find(x => x.ID == ID);
        }
        public void AddPrivateToList(int id, string firstName, string lastName, decimal salary)
        {
            Private soldier = new Private(id, firstName, lastName, salary);
            privateList.Add(soldier);

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (Private priv in privateList)
            {
                string firstName = priv.FirstName;
                string lastName = priv.LastName;
                int id = priv.ID;
                decimal salary = priv.Salary;
                sb.AppendLine($"Name: {firstName} {lastName} Id: {id} Salary: {salary:f2}");
            }

            return sb.ToString().TrimEnd();

        }
        public void PrintSoldier(List<Private> privates)
        {
            foreach (var item in privateList)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
