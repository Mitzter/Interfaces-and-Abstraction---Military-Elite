



namespace Interfaces_and_Abstraction___Military_Elite.Models.Interfaces
{

    using System.Collections.Generic;

    public interface ILieutenantGeneral : IPrivate
    {
        public List<Private> CommandList { get; }
    }
}
