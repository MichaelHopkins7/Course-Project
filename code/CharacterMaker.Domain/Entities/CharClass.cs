using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterMaker.Domain.Entities
{
    class CharClass
    {
        public int HDSize {get; set; }
        public int BABGrowth { get; set; }
        public int FortGrowth { get; set; }
        public int ReflexGrowth { get; set; }
        public int WillGrowth { get; set; }
        public int WeaponProf { get; set; }
        public int ArmorProf { get; set; }
        public int ShieldProf { get; set; }
        public string SpecialProf { get; set; }

    }
}
