using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Actor.Stats
{
    public enum StatModType
    {
        Flat,
        PercentAdditive,
        PercentMultiplicative
    }
    public class ActorStatModifier
    {
        public double ModifierValue { get; set; }
        public string ModifierID { get; }
        public StatModType ModifierType { get; }
        public int ModifierOrder { get; }
        public ActorStatModifier(string newModifierID, double newModifierAmount, StatModType newStatModifierType, int newStatModifierOrder)
        {
            ModifierID = newModifierID;
            ModifierValue = newModifierAmount;
            ModifierType = newStatModifierType;
            ModifierOrder = newStatModifierOrder;
        }
    }
}
