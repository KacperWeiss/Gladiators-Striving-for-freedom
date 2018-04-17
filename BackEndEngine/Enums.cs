using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEngine
{
    /// <summary>
    /// Enum for navigation beetween classes of equipment
    /// </summary>
    public enum ItemType
    {
        Sword, Mace, RoundShield, ChestArmor, FullHelmet, LeatherHelmet
    }

    /// <summary>
    /// Enum for navigation beetween shop's equipment quality
    /// </summary>
    public enum ItemQuality
    {
        Poor, Normal, Good, Perfect
    }

    /// <summary>
    /// Enum for selecting defensive equipment
    /// </summary>
    public enum DefensiveEquipment
    {
        Shield, Helmet, ChestArmor
    }

    /// <summary>
    /// Enum for selecting attributes
    /// </summary>
    public enum AttributesSelection
    {
        Strength, Agility, Toughness
    }

    /// <summary>
    /// Fighting targets
    /// </summary>
    public enum ValiableTargets
    {
        Head, Torso
    }

    public enum Rewards
    {
        Low, Normal, Good
    }
}
