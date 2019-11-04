using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Item
{
    public interface IItem
    {
        public void UseItem();
        public void CombineItem(IItem item);
        public void DropItem();
    }
}
