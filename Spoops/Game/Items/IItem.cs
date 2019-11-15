using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Items
{
    public interface IItem
    {
        public void UseItem();
        public void CombineItem(IItem item);
        public void DropItem();
    }
}
