using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class descibing beast
    /// </summary>
    public class Beast : Creature
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Opponent's name</param>
        /// <param name="naturalWeaponName">Opponent's natural weapon name</param>
        /// <param name="maximumHealthPoints">Opponent's initial health points and maximum health points</param>
        /// <param name="level">Initial opponent's level</param>
        /// <param name="strength">Initial opponent's strength parameter</param>
        /// <param name="agility">Initial opponent's agility parameter</param>
        /// <param name="toughness">Initial opponent's toughness parameter</param>
        public Beast(string name, string naturalWeaponName, double maximumHealthPoints = 300, int level = 1, int strength = 5, int agility = 1, int toughness = 1, double equipmentQuality = 1) : base(name, maximumHealthPoints, level)
        {
            ImageName = "Wolf";
            weapon = new NaturalWeapon(naturalWeaponName, 0, 18 + level, 10 + level);
            defensiveItems = new Dictionary<DefensiveEquipment, DefensiveItem>(){
                {DefensiveEquipment.Shield, new NaturalBlockItem("Blocking " + naturalWeaponName, 0, 5*equipmentQuality)},
                {DefensiveEquipment.Helmet, new NaturalHeadArmor(name + " skull", 0, 5*equipmentQuality)},
                {DefensiveEquipment.ChestArmor, new NaturalChestArmor(name + " fur", 0, 5*equipmentQuality)}
            };
            items = new List<Item>();
        }
    }
}
