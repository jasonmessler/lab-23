﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MOCK_ASSESSMENT_3
{
    class Slacker : Villager
    {
        public Slacker()
        {
            Hunger = 3;
        }

        public override int Farm()
        {
            return 0;
        }
    }
}
