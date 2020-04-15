using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animals
    {
        public Bird()
        {
            LegNum = 2;
            Age = 3;
            IsLiving = true;
            Name = "Borb";
        }
          public string WingColor { get; set; }
          public int Wings { get; set; }
          public bool CanFly { get; set; }
          public bool CanBeep { get; set; }
    }
}
