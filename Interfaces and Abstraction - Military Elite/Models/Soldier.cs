


namespace Interfaces_and_Abstraction___Military_Elite.Models
{
    using Interfaces_and_Abstraction___Military_Elite.Models.Interfaces;
    using System.Collections.Generic;

    public class Soldier : ISoldier
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private readonly List<Soldier> soldierList = new List<Soldier>();

        public Soldier(int id, string firstName, string lastName)
        {
            this.LastName = lastName;
            this.ID = id;
            this.FirstName = firstName;

            

           

        }
        public int ID 
        { 
            get { return _id; }
            set { _id = value; }
        }

        

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public void AddSoldierToList(int id, string firstName, string lastName)
        {
            Soldier soldier = new Soldier(id, firstName, lastName);
            soldierList.Add(soldier);
            
        }

        public void Print()
        {
            foreach (var item in soldierList)
            {
                System.Console.WriteLine(item.ToString());
            }
        }
    }
}
