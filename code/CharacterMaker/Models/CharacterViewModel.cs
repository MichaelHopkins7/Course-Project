using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CharacterMaker.Domain.Entities;

namespace CharacterMaker.Models
{
    public class CharacterViewModel
    {
        public CharacterNow  Character { get; set; }
        public string ReturnUrl { get; set; }
    }
}