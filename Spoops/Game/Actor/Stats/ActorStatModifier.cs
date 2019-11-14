using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Actor.Stats
{
    public class ActorStatModifier
    {
        public double ModifierValue { get; set; }
        public string ModifierID { get; set; }
        public ActorStatModifier(string modifierID, double newModifierAmount)
        {
            ModifierValue = newModifierAmount;
        }
    }
}
