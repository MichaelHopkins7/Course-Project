using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterMaker.Domain.Abstract
{
    interface CharClassRepository
    {
        IEnumerable<CharClass> CharClasses { get; }
    }
}
