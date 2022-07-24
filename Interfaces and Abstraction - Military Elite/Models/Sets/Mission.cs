using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_and_Abstraction___Military_Elite.Models.Sets
{
    public class Mission
    {
        private string codeName;
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName
        { 
            get { return codeName; } 
            set { codeName = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public void CompleteMission(string state)
        {
            if (state == "Finished")
            {
                this.state = "Finished";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Code Name: {this.CodeName} State: {this.State}");

            return sb.ToString().TrimEnd();
        }
    }
}
