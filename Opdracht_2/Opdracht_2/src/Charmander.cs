﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2.src
{
    internal class Pokemon
    {
        public string? name;
        private string strength, weakness = "";
        public Pokemon(string? name, string weakness, string strength)
        {
            this.name = name;
            this.weakness = weakness;
            this.strength = strength;
        }
        public void battleCry()
        {
            Console.WriteLine(this.name + " used battle cry: " + this.name + "!");
        }
    }
}
