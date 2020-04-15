using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptiles : Animals
    {
        public Reptiles()
        {
            IsLiving = true;
            Age = 4;
            LegNum = 4;
            Name = "Fuzzy";
        }
        public bool Scaly { get; set; }
        public bool Hostile { get; set; }
        public string Diet { get; set; }
        public string Habitat { get; set; }
    }
}
