﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Abstraction
{
     class Lion : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("abstract method");
        }
    }
}
