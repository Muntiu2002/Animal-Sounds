﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    public interface IAnimal
    {
        string GetTypeName();
        string MakeSound();
    }
}
