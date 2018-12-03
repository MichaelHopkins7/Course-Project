using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterMaker.Domain.Entities
{
    class Race
    {
        public int RaceID { get; set; }
        public string RaceName { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }
        public int StrMod { get; set; }
        public int DexMod { get; set; }
        public int ConMod { get; set; }
        public int IntMod { get; set; }
        public int WisMod { get; set; }
        public int ChaMod { get; set; }
        public string Traits { get; set; }
        public string Senses { get; set; }
    }
}
