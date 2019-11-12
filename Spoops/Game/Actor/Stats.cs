using System;
using System.Collections.Generic;
using System.Text;

namespace Spoops.Game.Actor
{
    public class Stats
    {
        // Base Stats
        public int Level { get; set; }
        public int CurrentExperience { get; set; }
        public int TotalExperience { get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Magic { get; set; }
        public int Agility { get; set; }
        // Elemental Resistances
        public IResistances Resistances { get; set; }
        // Additional Combat Stats
        public double BlockChance { get; set; }
        public double DodgeChance { get; set; }
        public double CritHitChance { get; set; }
        public double CritDamageIncrease { get; set; }
        public double ArmorPenetration { get; set; }
        public double HPRegen { get; set; }
        public double ManaRegen { get; set; }
        public double CooldownReduction { get; set; }
        public double Accuracy { get; set; }
        public double SpellAccuracy { get; set; }
        public Stats ()
        {
            
        }
        public Stats(int newHP = 1)
        {
            HP = newHP;
            Mana = 1;
        }

        private void SetAdditionalCombatStatsDefault()
        {
            DodgeChance = .05 + (Agility * .10);
            BlockChance = 0;
        }

        private void SetBaseStatDefaults()
        {

        }
    }
}
