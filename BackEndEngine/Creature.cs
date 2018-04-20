using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Class that represents creatures
    /// </summary>
    public abstract class Creature
    {
        /// <summary>
        /// Player's name
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Image name (used in image selection)
        /// </summary>
        public string ImageName { get; protected set; }

        /// <summary>
        /// Used weapon
        /// </summary>
        protected Weapon weapon;

        /// <summary>
        /// List of defencive items
        /// </summary>
        protected Dictionary<DefensiveEquipment, DefensiveItem> defensiveItems;

        /// <summary>
        /// List of items
        /// </summary>
        protected List<Item> items;

        /// <summary>
        /// Creatures attributes such as Health, Experience, Level, Strength etc.
        /// </summary>
        public CreatureAttributes creatureAttributes;

        /// <summary>
        /// Last damage received by this creature
        /// </summary>
        public string LastReceivedDamage { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Name of the creature</param>
        /// <param name="maximumHealthPoints">Maximum Health Points</param>
        /// <param name="level">Creature's level</param>
        /// <param name="strength">Initial creature's strength parameter</param>
        /// <param name="agility">Initial creature's agility parameter</param>
        /// <param name="toughness">Initial creature's toughness parameter</param>
        public Creature(string name, double maximumHealthPoints = 100, int level = 1, int strength = 1, int agility = 1, int toughness = 1)
        {
            Name = name;
            creatureAttributes.Experiance = 0;
            creatureAttributes.NextLevelExperiance = 100 * level + (int)(0.25 * (level - 1));
            creatureAttributes.Level = level;
            creatureAttributes.MaximumHealthPoints = maximumHealthPoints * (0.5 + level/2);
            creatureAttributes.HealthPoints = creatureAttributes.MaximumHealthPoints;
            creatureAttributes.Strength = strength * level;
            creatureAttributes.Agility = agility * level;
            creatureAttributes.Toughness = toughness * level;
        }

        /// <summary>
        /// Gives copy of used weapon
        /// </summary>
        /// <returns>Currently used weapon</returns>
        public Weapon GetWeapon()
        {
            return weapon;
        }

        /// <summary>
        ///  Gives copy of used defensive item
        /// </summary>
        /// <param name="defensiveEquipment">Equipment selection</param>
        /// <returns>Currently use defensive item</returns>
        public DefensiveItem GetDefensiveItem(DefensiveEquipment defensiveEquipment)
        {
            return defensiveItems[defensiveEquipment];
        }

        /// <summary>
        /// Virtual method for fighting
        /// </summary>
        /// <param name="creature">Creature to fight with</param>
        public int Fight(Creature creature, ValiableTargets valiableTargets = ValiableTargets.Torso)
        {
            Random random = new Random();
            switch (valiableTargets)
            {
                case ValiableTargets.Head:
                    if(random.Next(0, 100) > 20)
                    {
                        if (random.Next(0, 200) > (creature.defensiveItems[DefensiveEquipment.Shield].defensiveParameters.BlockChance + creature.defensiveItems[DefensiveEquipment.Helmet].defensiveParameters.BlockChance))
                        {
                            double attackValue = (0.9 + this.creatureAttributes.Strength * 0.1) * weapon.weaponParameters.AttackValue; // sets attack value
                            double EnemiesDefenceValue = (0.9 + creature.creatureAttributes.Toughness * 0.1) * 0.1 * (creature.defensiveItems[DefensiveEquipment.Shield].defensiveParameters.DefenceValue + creature.defensiveItems[DefensiveEquipment.Helmet].defensiveParameters.DefenceValue);
                            double DamageMitigation = EnemiesDefenceValue > this.weapon.weaponParameters.ArmorPiercing ? EnemiesDefenceValue - this.weapon.weaponParameters.ArmorPiercing : 0;
                            creature.creatureAttributes.HealthPoints -= (attackValue - DamageMitigation);
                        }
                    } 
                    break;

                case ValiableTargets.Torso:
                    if (random.Next(0, 200) > (creature.defensiveItems[DefensiveEquipment.Shield].defensiveParameters.BlockChance + creature.defensiveItems[DefensiveEquipment.ChestArmor].defensiveParameters.BlockChance))
                    {
                        double attackValue = (0.9 + this.creatureAttributes.Strength * 0.1) * weapon.weaponParameters.AttackValue; // sets attack value
                        double EnemiesDefenceValue = (0.9 + creature.creatureAttributes.Toughness * 0.1) * 0.1 * (creature.defensiveItems[DefensiveEquipment.Shield].defensiveParameters.DefenceValue + creature.defensiveItems[DefensiveEquipment.ChestArmor].defensiveParameters.DefenceValue);
                        double DamageMitigation = EnemiesDefenceValue > this.weapon.weaponParameters.ArmorPiercing ? EnemiesDefenceValue - this.weapon.weaponParameters.ArmorPiercing : 0;
                        creature.creatureAttributes.HealthPoints -= (attackValue - DamageMitigation);
                    }
                    break;
            }
            return this.weapon.weaponParameters.Recharge;
        }
    }
}
