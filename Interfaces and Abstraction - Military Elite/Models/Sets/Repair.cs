

using System.Text;

namespace Interfaces_and_Abstraction___Military_Elite.Models.Sets
{
    public class Repair
    {
        private string _name;
        private int _hoursWorked;

        public Repair(string name, int hoursWorked)
        {
            this.Name = name;
            this.HoursWorked = hoursWorked;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Part Name: {this.Name} Hours Worked: {this.HoursWorked}");

            return sb.ToString().TrimEnd();
        }
    }
}
