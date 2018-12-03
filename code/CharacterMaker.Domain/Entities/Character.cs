﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterMaker.Domain.Entities
{
    public class CharacterNow
    {

        public string CharName { get; set; }
        public string Race { get; set; } 
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Inteligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int CharLvl { get; set; }
        public int HP { get; set; }
        public int BAB { get; set; }
        public int Fort { get; set; }
        public int Reflex { get; set; }
        public int Will { get; set; }

    }
}