using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Combat
{
   interface ITurnBasedCombat : ICombat
    {
        public void AssignTurnOrderMaster(ITurnOrderMaster newTurnOrderMaster);
        public void RemoveTurnMaster();
    }
}
