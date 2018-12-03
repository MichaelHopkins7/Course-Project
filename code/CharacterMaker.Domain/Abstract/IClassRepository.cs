using System.Collections.Generic;
using CharacterMaker.Domain.Entities;

namespace CharacterMaker.Domain.Abstract
{
    interface IClassRepository
    {
        IEnumerable<CharClass> CharClasses { get; }
    }
}
