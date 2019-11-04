using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Actor
{
    public class Resistances : IResistances
    {
        private Dictionary<string, int> resistDictionary;

        public Resistances()
        {
            resistDictionary = new Dictionary<string, int>();
        }

        public Resistances(Dictionary<string,int> newResistDictionary)
        {
            resistDictionary = newResistDictionary;
        }

        public int GetResist(string resistID)
        {
            var resistValue = 0;
            if(!resistDictionary.TryGetValue(resistID, out resistValue))
            {
                return 0;
            }

            return resistValue;
        }

        public void SetResist(string resistID, int resistAmount)
        {
            resistDictionary[resistID] = resistAmount;
        }
    }
}
