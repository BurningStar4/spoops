using Spoops.Game.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Combat
{
    public interface ITurnOrderMaster
    {
        public void AddActor(IActor newActor);

        public void RemoveActor(IActor actor);

        public void SendActorToFront(IActor actor);

        public void SendActorToBack(IActor actor);

        public void UpdateTurnOrder();

        public void DelayTurnByAmount(IActor actor, int delayAmount);

        public void ExecuteNextTurn();

        public string GetFullTurnOrderString();
    }
}
