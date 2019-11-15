using System;
using System.Collections.Generic;
using System.Text;
using Spoops.Game.Actor;

namespace Spoops.Game.Combat
{
    class TurnOrderMaster : ITurnOrderMaster
    {
        private Queue<IActor> TurnQueue;

        public void AddActor(IActor newActor)
        {
            throw new NotImplementedException();
        }

        public void DelayTurnByAmount(IActor actor, int delayAmount)
        {
            throw new NotImplementedException();
        }

        public void ExecuteNextTurn()
        {
            throw new NotImplementedException();
        }

        public string GetFullTurnOrderString()
        {
            throw new NotImplementedException();
        }

        public void RemoveActor(IActor actor)
        {
            throw new NotImplementedException();
        }

        public void SendActorToBack(IActor actor)
        {
            throw new NotImplementedException();
        }

        public void SendActorToFront(IActor actor)
        {
            throw new NotImplementedException();
        }

        public void UpdateTurnOrder()
        {
            throw new NotImplementedException();
        }
    }
}
