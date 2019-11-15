using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Spoops.Game.Actor.Stats
{
    public class ActorStat
    {
        private bool isDirty = true;
        private double statValue;
        private bool isForcedValue;
        private double lastBaseValue;

        public double BaseValue { get; set; }

        public ReadOnlyCollection<ActorStatModifier> StatModifiers;
        public double StatValue { get
            {
                if ((isDirty || lastBaseValue != BaseValue) && !isForcedValue)
                {
                    {
                        this.lastBaseValue = BaseValue;
                        this.statValue = CalculateFinalStatValue();
                        isDirty = false;
                    }
                }
                return this.statValue;
            }
        }

        private readonly List<ActorStatModifier> statModifiers;

        public ActorStat(double baseValue)
        {
            this.statValue = baseValue;
            statModifiers = new List<ActorStatModifier>();
            StatModifiers = statModifiers.AsReadOnly();
        }

        public void AddActorStatModifier(ActorStatModifier newActorStatModifier)
        {
            isDirty = true;
            statModifiers.Add(newActorStatModifier);
            statModifiers.Sort(CompareModifierOrder);
        }

        public bool RemoveActorStatModifier(ActorStatModifier actorStatModifier)
        {
            if(statModifiers.Remove(actorStatModifier))
            {
                isDirty = true;
                return true;
            }
            return false;
        }

        public void ForceValue(double newValue)
        {
            this.isForcedValue = true;
            statValue = newValue;
        }

        public void UnforceValue()
        {
            this.isForcedValue = false;
        }

        public bool RemoveAllModifiersByID(string modifierID)
        {
            var didRemove = false;

            for (int i = statModifiers.Count - 1; i>=0; i--)
            {
                if(statModifiers[i].ModifierID == modifierID)
                {
                    isDirty = true;
                    didRemove = true;
                    statModifiers.RemoveAt(i);
                }
            }

            return didRemove;
        }

        public virtual double CalculateFinalStatValue()
        {
            var finalValue = BaseValue;
            var sumPercentAdditive = 0;

            for(int i = 0; i < statModifiers.Count; i++)
            {
                var statModifier = statModifiers[i];
                if (statModifier.ModifierType == StatModType.PercentMultiplicative)
                {
                    finalValue *= 1 + statModifier.ModifierValue;
                }
                else if (statModifier.ModifierType == StatModType.PercentAdditive)
                {
                    if ( (i+1) >= statModifiers.Count || statModifiers[i + 1].ModifierType != StatModType.PercentAdditive)
                    {
                        finalValue *= 1 + sumPercentAdditive;
                        sumPercentAdditive = 0;
                    }
                }
                else
                {
                    finalValue += statModifier.ModifierValue;
                }
            }

            return finalValue;
        }

        private int CompareModifierOrder(ActorStatModifier a, ActorStatModifier b)
        {
            if (a.ModifierOrder < b.ModifierOrder)
            {
                return -1;
            }
            else if (a.ModifierOrder > b.ModifierOrder)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
