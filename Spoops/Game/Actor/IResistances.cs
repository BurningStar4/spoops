using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Actor
{
    public interface IResistances
    {
        public int GetResist(string resistID);
        public void SetResist(string resistID, int resistAmount);
    }
}
