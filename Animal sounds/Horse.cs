﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    public class Horse : IAnimal
    {
        public string GetTypeName() => "Horse";
        public string MakeSound() => "Neigh";
    }
}
