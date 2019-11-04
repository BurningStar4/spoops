using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Item
{
    public abstract class Equipment : Item
    {
        public abstract void Equip();

        public abstract void Unequip();

        public abstract void GetDescription();
    }
}
