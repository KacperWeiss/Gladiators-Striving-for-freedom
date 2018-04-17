using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class descibing most common opponent
    /// </summary>
    public class SwordGladiator : Creature
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Opponent's name</param>
        /// <param name="maximumHealthPoints">Opponent's initial health points and maximum health points</param>
        /// <param name="level">Initial opponent's level</param>
        /// <param name="strength">Initial opponent's strength parameter</param>
        /// <param name="agility">Initial opponent's agility parameter</param>
        /// <param name="toughness">Initial opponent's toughness parameter</param>
        public SwordGladiator(string name, double maximumHealthPoints = 150, int level = 1, int strength = 1, int agility = 3, int toughness = 1, double equipmentQuality = 1) : base(name, maximumHealthPoints, level, strength, agility, toughness)
        {
            ImageName = "swordGladiator";
            weapon = new Sword("Soldier's sword", (decimal)(10 * equipmentQuality), equipmentQuality);
            defensiveItems = new Dictionary<DefensiveEquipment, DefensiveItem>(){
                {DefensiveEquipment.Shield, new RoundShield("Soldier's shield", (decimal)(10 * equipmentQuality), equipmentQuality)},
                {DefensiveEquipment.Helmet, new LeatherHelmet("Tough lether helm", (decimal)(10 * equipmentQuality), equipmentQuality + 0.3)},
                {DefensiveEquipment.ChestArmor, new NaturalChestArmor("Human chest")}
            };
            items = new List<Item>()
            {
                weapon,
                defensiveItems[DefensiveEquipment.Shield],
                defensiveItems[DefensiveEquipment.Helmet]
            };
        }
    }
}
