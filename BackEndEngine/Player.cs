using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Player class
    /// </summary>
    public class Player : Creature
    {
        /// <summary>
        /// Player's funds
        /// </summary>
        private decimal _funds;

        /// <summary>
        /// Access to player's funds
        /// </summary>
        public decimal Funds { get => _funds; set => _funds = value; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Player's name</param>
        /// <param name="funds">Player's initial funds</param>
        /// <param name="maximumHealthPoints">Player's initial health points and maximum health points</param>
        /// <param name="level">Initial player's level</param>
        /// <param name="strength">Initial player's strength parameter</param>
        /// <param name="agility">Initial player's agility parameter</param>
        /// <param name="toughness">Initial player's toughness parameter</param>
        public Player(string name, decimal funds = 100, double maximumHealthPoints = 200, int level = 1, int strength = 1, int agility = 1, int toughness = 1) : base(name, maximumHealthPoints, level, strength, agility, toughness)
        {
            _funds = funds;
            weapon = new NaturalWeapon("Bare hands");
            defensiveItems = new Dictionary<DefensiveEquipment, DefensiveItem>(){
                {DefensiveEquipment.Shield, new NaturalBlockItem("Bare hands")},
                {DefensiveEquipment.Helmet, new NaturalHeadArmor("Human head")},
                {DefensiveEquipment.ChestArmor, new NaturalChestArmor("Human chest")}
            };
            items = new List<Item>();
        }

        /// <summary>
        /// Checks if player will level up after fight
        /// </summary>
        public bool CheckLevelUp()
        {
            if(creatureAttributes.Experiance > creatureAttributes.NextLevelExperiance)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Allows to choose atttribute to level up
        /// </summary>
        public void SelectLevelUp(AttributesSelection attributesSelection)
        {
            creatureAttributes.Experiance -= creatureAttributes.NextLevelExperiance;
            creatureAttributes.NextLevelExperiance = (int)(creatureAttributes.NextLevelExperiance * 2.5);
            creatureAttributes.MaximumHealthPoints *= 1.5;
            creatureAttributes.Level++;

            switch (attributesSelection)
            {
                case AttributesSelection.Strength:
                    creatureAttributes.Strength++;
                    break;
                case AttributesSelection.Agility:
                    creatureAttributes.Agility++;
                    break;
                case AttributesSelection.Toughness:
                    creatureAttributes.Toughness++;
                    break;
            }
        }

        /// <summary>
        /// Changes used weapon
        /// </summary>
        /// <param name="weapon">New weapon</param>
        public void ChangeWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }

        /// <summary>
        /// Changes defensive item
        /// </summary>
        /// <param name="defensiveItem">New defensive item</param>
        /// <param name="defensiveEquipment">Equipment selection</param>
        public void ChangeDefensiveItem(DefensiveItem defensiveItem , DefensiveEquipment defensiveEquipment)
        {
            this.defensiveItems[defensiveEquipment] = defensiveItem;
        }

        /// <summary>
        /// Allows player to rename his character
        /// </summary>
        /// <param name="name">New name for character</param>
        public void Rename(string name)
        {
            Name = name;
        }
    }
}
