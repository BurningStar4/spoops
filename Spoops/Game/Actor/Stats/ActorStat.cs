using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Actor.Stats
{
    public class ActorStat
    {
        private bool isDirty = true;
        public double BaseValue { get; set; }
        private double statValue;
        private bool isForcedValue;
        public double StatValue { get
            {
                if (isDirty && !isForcedValue)
                {
                    {
                        this.statValue = CalculateFinalStatValue();
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
        }

        public void AddActorStatModifier(ActorStatModifier newActorStatModifier)
        {
            statModifiers.Add(newActorStatModifier);
        }

        public void RemoveActorStatModifier(ActorStatModifier actorStatModifier)
        {
            statModifiers.Remove(actorStatModifier);
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

        public virtual double CalculateFinalStatValue()
        {
            var finalValue = BaseValue;

            foreach(ActorStatModifier statMod in statModifiers)
            {
                
            }

            return finalValue;
        }
    }
}
