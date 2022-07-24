using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_and_Abstraction___Military_Elite.Models.Interfaces
{
    public interface IPrivate : ISoldier
    {
        public decimal Salary { get; }
    }
}
