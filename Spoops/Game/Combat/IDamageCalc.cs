using Spoops.Game.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Combat
{
    interface IDamageCalc
    {
        public int GetDamage(DamageType damageType, int damageAmount, ActorStats actorStats);
    }
}
