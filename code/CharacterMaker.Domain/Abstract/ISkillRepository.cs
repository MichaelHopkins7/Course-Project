using System;
using System.Collections.Generic;
using System.Text;
using CharacterMaker.Domain.Entities;

namespace CharacterMaker.Domain.Abstract
{
    interface ISkillRepository
    {
        IEnumerable<Skill> Skills { get; }
    }
}
