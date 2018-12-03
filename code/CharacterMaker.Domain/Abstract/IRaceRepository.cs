using System.Collections.Generic;
using CharacterMaker.Domain.Entities;

namespace CharacterMaker.Domain.Abstract
{
    interface IRaceRepository
    {
        IEnumerable<Race> Races { get; }
    }
}
