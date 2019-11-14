using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Actor
{
    public abstract class Creature : IActor
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ActorStats Stats { get; set; }
        public void AttackTarget(IActor actor)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Talk(IActor actor)
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}
