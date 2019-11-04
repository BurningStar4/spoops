using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Item
{
    public abstract class Item : IItem
    {
        public void CombineItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public void DropItem()
        {
            throw new NotImplementedException();
        }

        public void UseItem()
        {
            throw new NotImplementedException();
        }
    }
}
