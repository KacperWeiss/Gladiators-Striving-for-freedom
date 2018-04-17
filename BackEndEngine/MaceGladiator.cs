using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class descibing opponent with blunt weapon
    /// </summary>
    public class MaceGladiator : Creature
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
        public MaceGladiator(string name, double maximumHealthPoints = 175, int level = 1, int strength = 2, int agility = 1, int toughness = 2, double equipmentQuality = 1) : base(name, maximumHealthPoints, level, strength, agility, toughness)
        {
            ImageName = "maceGladiator";
            weapon = new BluntWeapon("Soldier's mace", (decimal)(10 * equipmentQuality), equipmentQuality);
            defensiveItems = new Dictionary<DefensiveEquipment, DefensiveItem>(){
                {DefensiveEquipment.Shield, new RoundShield("Soldier's shield", (decimal)(10 * equipmentQuality), equipmentQuality)},
                {DefensiveEquipment.Helmet, new NaturalHeadArmor("Human head")},
                {DefensiveEquipment.ChestArmor, new ChestPiece("Roman hauberk", (decimal)(10 * equipmentQuality), equipmentQuality)}
            };
            items = new List<Item>()
            {
                weapon,
                defensiveItems[DefensiveEquipment.Shield],
                defensiveItems[DefensiveEquipment.ChestArmor]
            };
        }
    }
}
