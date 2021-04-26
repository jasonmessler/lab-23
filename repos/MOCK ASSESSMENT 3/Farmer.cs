using System;
using System.Collections.Generic;
using System.Text;

namespace MOCK_ASSESSMENT_3
{
    class Farmer : Villager
    {
        public Farmer()
        {
            Hunger = 1;
        }

        public override int Farm()
        {
            return 2;
        }
    }
}
