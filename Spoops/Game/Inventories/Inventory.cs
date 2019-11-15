using System;
using System.Collections.Generic;
using System.Text;
using Spoops.Game.Items;

namespace Spoops.Game.Inventories
{
    public abstract class Inventory
    {
        int Id { get; set; }
        int Size { get; set; }
        Dictionary<string, Item> Container { get; set; }

        public abstract bool AddItem(Item item);
        public abstract bool RemoveItem(Item item);
        public abstract Dictionary<string, Item> DisplayItems();
    }
}
