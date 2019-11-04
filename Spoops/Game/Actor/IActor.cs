using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Actor
{
    public interface IActor
    {
        public void Move();
        public void AttackTarget(IActor actor);
        public void Talk();
    }
}
