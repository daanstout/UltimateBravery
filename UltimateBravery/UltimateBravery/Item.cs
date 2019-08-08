using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBravery.Properties;

namespace UltimateBravery {
    public class Item {
        #region Static
        /// <summary>
        /// A list of every item registered
        /// </summary>
        public static Dictionary<string, Item> itemList { get; } = new Dictionary<string, Item>();

        /// <summary>
        /// Initializes the item list
        /// </summary>
        public static void InitItemList() {
            #region A
            Item Abyssal_Mask = new Item("Abyssal Mask", Resources.Abyssal_Mask, 3000);
            Abyssal_Mask.Register();

            Item Adaptive_Helmet = new Item("Adaptive Helmet", Resources.Adaptive_Helmet, 2800);
            Adaptive_Helmet.Register();

            Item Archangels_Staff = new Item("Archangel's Staff", Resources.Archangels_Staff, 3200);
            Archangels_Staff.Register();

            Item Ardent_Censer = new Item("Ardent Censer", Resources.Ardent_Censer, 2300);
            Ardent_Censer.Register();

            Item Athenes_Unholy_Grail = new Item("Athene's Unholy Grail", Resources.Athenes_Unholy_Grail, 2100);
            Athenes_Unholy_Grail.Register();
            #endregion
            #region B
            Item Banshees_Veil = new Item("Banshee's Veil", Resources.Banshees_Veil, 3000);
            Banshees_Veil.Register();

            Item Berserkers_Greaves = new Item("Berserker's Greaves", Resources.Berserkers_Greaves, 1100);
            Berserkers_Greaves.isBoot = true;
            Berserkers_Greaves.Register();

            Item Blade_of_the_Ruined_King = new Item("Blade of the Ruined King", Resources.Blade_of_the_Ruined_King, 3300);
            Blade_of_the_Ruined_King.Register();

            Item Boots_of_Mobility = new Item("Boots of Mobility", Resources.Boots_of_Mobility, 900);
            Boots_of_Mobility.isBoot = true;
            Boots_of_Mobility.Register();

            Item Boots_of_Swiftness = new Item("Boots of Swiftness", Resources.Boots_of_Swiftness, 900);
            Boots_of_Swiftness.isBoot = true;
            Boots_of_Swiftness.Register();
            #endregion
            #region D
            Item Dead_Mans_Plate = new Item("Dead Man's Plate", Resources.Dead_Mans_Plate, 2900);
            Dead_Mans_Plate.Register();

            Item Deaths_Dance = new Item("Death's Dance", Resources.Deaths_Dance, 3500);
            Deaths_Dance.Register();

            Item Duskblade_of_Draktharr = new Item("Duskblade of Draktharr", Resources.Duskblade_of_Draktharr, 2900);
            Duskblade_of_Draktharr.Register();
            #endregion
            #region E
            Item Edge_of_Night = new Item("Edge of Night", Resources.Edge_of_Night, 3000);
            Edge_of_Night.Register();

            Item Essence_Reaver = new Item("Essence Reaver", Resources.Essence_Reaver, 3300);
            Essence_Reaver.Register();
            #endregion
            #region F
            Item Frozen_Heart = new Item("Frozen Heart", Resources.Frozen_Heart, 2700);
            Frozen_Heart.Register();

            Item Frozen_Mallot = new Item("Frozen Mallot", Resources.Frozen_Mallot, 3100);
            Frozen_Mallot.Register();
            #endregion
            #region G
            Item Gargoyle_Stoneplate = new Item("Gargoyle Stoneplate", Resources.Gargoyle_Stoneplate, 2500);
            Gargoyle_Stoneplate.Register();

            Item Guardian_Angel = new Item("Guardian Angel", Resources.Guardian_Angel, 2800);
            Guardian_Angel.Register();

            Item Guinsoos_Rageblade = new Item("Guinsoo's Rageblade", Resources.Guinsoos_Rageblade, 3100);
            Guinsoos_Rageblade.Register();
            #endregion
            #region H
            Item Hextech_GLP800 = new Item("Hextech GLP-800", Resources.Hextech_GLP_800, 2800);
            Hextech_GLP800.Register();

            Item Hextech_Gunblade = new Item("Hextech Gunblade", Resources.Hextech_Gunblade, 3400);
            Hextech_Gunblade.Register();

            Item Hextech_Protobelt01 = new Item("Hextech Protobelt-01", Resources.Hextech_Protobelt_01, 2500);
            Hextech_Protobelt01.Register();
            #endregion
            #region I
            Item Iceborn_Gauntlet = new Item("Iceborn Gauntlet", Resources.Iceborn_Gauntlet, 2700);
            Iceborn_Gauntlet.Register();

            Item Infinity_Edge = new Item("Infinity Edge", Resources.Infinity_Edge, 3400);
            Infinity_Edge.Register();

            Item Ionian_Boots_of_lucidity = new Item("Ionian Boots of Lucidity", Resources.Ionian_Boots_of_Lucidity, 900);
            Ionian_Boots_of_lucidity.isBoot = true;
            Ionian_Boots_of_lucidity.Register();
            #endregion
            #region K
            Item Knights_Vow = new Item("Knight's Vow", Resources.Knights_Vow, 2200);
            Knights_Vow.Register();
            #endregion
            #region L
            Item Liandrys_Torment = new Item("Liandry's Torment", Resources.Liandrys_Torment, 3100);
            Liandrys_Torment.Register();

            Item Lich_Bane = new Item("Lich Bane", Resources.Lich_Bane, 3200);
            Lich_Bane.Register();

            Item Locket_of_the_Iron_Solari = new Item("Locket of the Iron Solari", Resources.Locket_of_the_Iron_Solari, 2200);
            Locket_of_the_Iron_Solari.Register();

            Item Lord_Dominiks_Regards = new Item("Lord Dominik's Regards", Resources.Lord_Dominiks_Regards, 2800);
            Lord_Dominiks_Regards.Register();

            Item Ludens_Echo = new Item("Luden's Echo", Resources.Ludens_Echo, 3200);
            Ludens_Echo.Register();
            #endregion
            #region M
            Item Manamune = new Item("Manamune", Resources.Manamune, 2400);
            Manamune.Register();

            Item Maw_of_Malmortius = new Item("Maw of Malmortius", Resources.Maw_of_Malmortius, 3250);
            Maw_of_Malmortius.Register();

            Item Mejais_Soulstealer = new Item("Mejai's Soulstealer", Resources.Mejais_Soulstealer, 1400);
            Mejais_Soulstealer.Register();

            Item Mercurial_Scimitar = new Item("Mercurial Scimitar", Resources.Mercurial_Scimitar, 3400);
            Mercurial_Scimitar.Register();

            Item Mercurys_Treads = new Item("Mercury's Treads", Resources.Mercurys_Treads, 1100);
            Mercurys_Treads.isBoot = true;
            Mercurys_Treads.Register();

            Item Mikaels_Crucible = new Item("Mikael's Crucible", Resources.Mikaels_Crucible, 2100);
            Mikaels_Crucible.Register();

            Item Morellonomicon = new Item("Morellonomicon", Resources.Morellonomicon, 3000);
            Morellonomicon.Register();

            Item Mortal_Reminder = new Item("Mortal Reminder", Resources.Mortal_Reminder, 2800);
            Mortal_Reminder.Register();
            #endregion
            #region N
            Item Nashors_Tooth = new Item("Nashor's Tooth", Resources.Nashors_Tooth, 3000);
            Nashors_Tooth.Register();

            Item Ninja_Tabi = new Item("Ninja Tabi", Resources.Ninja_Tabi, 1100);
            Ninja_Tabi.isBoot = true;
            Ninja_Tabi.Register();
            #endregion
            #region O
            Item Ohmwrecker = new Item("Ohmwrecker", Resources.Ohmwrecker, 2650);
            Ohmwrecker.Register();
            #endregion
            #region P
            Item Phantom_Dancer = new Item("Phantom Dancer", Resources.Phantom_Dancer, 2600);
            Phantom_Dancer.Register();
            #endregion
            #region R
            Item Rabadons_Deathcap = new Item("Rabadon's Deathcap", Resources.Rabadons_Deathcap, 3600);
            Rabadons_Deathcap.Register();

            Item Randuins_Omen = new Item("Randuin's Omen", Resources.Randuins_Omen, 2900);
            Randuins_Omen.Register();

            Item Rapid_Fire_Cannon = new Item("Rapid Fire Cannon", Resources.Rapid_Fire_Cannon, 2600);
            Rapid_Fire_Cannon.Register();

            Item Ravenous_Hydra = new Item("Ravenous Hydra", Resources.Ravenous_Hydra, 3500);
            Ravenous_Hydra.Register();

            Item Redemption = new Item("Redemption", Resources.Redemption, 2100);
            Redemption.Register();

            Item Remnant_of_the_Ascended = new Item("Remnant of the Ascended", Resources.Remnant_of_the_Ascended, 1500);
            Remnant_of_the_Ascended.isGoldItem = true;
            Remnant_of_the_Ascended.Register();

            Item Remnant_of_the_Aspect = new Item("Remnant of the Aspect", Resources.Remnant_of_the_Aspect, 1800);
            Remnant_of_the_Aspect.isGoldItem = true;
            Remnant_of_the_Aspect.Register();

            Item Remnant_of_the_Watchers = new Item("Remnant of the Watchers", Resources.Remnant_of_the_Watchers, 1800);
            Remnant_of_the_Watchers.isGoldItem = true;
            Remnant_of_the_Watchers.Register();

            Item Righteous_Glory = new Item("Righteous Glory", Resources.Righteous_Glory, 2650);
            Righteous_Glory.Register();

            Item Rod_of_Ages = new Item("Rod of Ages", Resources.Rod_of_Ages, 2600);
            Rod_of_Ages.Register();

            Item Runaans_Hurricane = new Item("Runaan's Hurricane", Resources.Runaans_Hurricane, 2600);
            Runaans_Hurricane.Register();

            Item Rylais_Crystal_Scepter = new Item("Rylai's Crystal Scepter", Resources.Rylais_Crystal_Scepter, 2600);
            Rylais_Crystal_Scepter.Register();
            #endregion
            #region S
            Item Shurelyas_Reverie = new Item("Shurelya's Reverie", Resources.Shurelyas_Reverie, 2250);
            Shurelyas_Reverie.Register();

            Item Sorcerers_Shoes = new Item("Sorcerer's Shoes", Resources.Sorcerers_Shoes, 1100);
            Sorcerers_Shoes.isBoot = true;
            Sorcerers_Shoes.Register();

            Item Spear_of_Shojin = new Item("Spear of Shojin", Resources.Spear_of_Shojin, 3400);
            Spear_of_Shojin.Register();

            Item Spellbinder = new Item("Spellbinder", Resources.Spellbinder, 2900);
            Spellbinder.Register();

            Item Spirit_Visage = new Item("Spirit Visage", Resources.Spirit_Visage, 2800);
            Spirit_Visage.Register();

            Item Statikk_Shiv = new Item("Statikk Shiv", Resources.Statikk_Shiv, 2600);
            Statikk_Shiv.Register();

            Item Steraks_Gage = new Item("Sterak's Gage", Resources.Steraks_Gage, 3200);
            Steraks_Gage.Register();

            Item Stormrazor = new Item("Stormrazor", Resources.Stormrazor, 3100);
            Stormrazor.Register();

            Item Sunfire_Cape = new Item("Sunfire Cape", Resources.Sunfire_Cape, 2750);
            Sunfire_Cape.Register();
            #endregion
            #region T
            Item The_Black_Cleaver = new Item("The Black Cleaver", Resources.The_Black_Cleaver, 3000);
            The_Black_Cleaver.Register();

            Item The_Bloodthirster = new Item("The Bloodthirster", Resources.The_Bloodthirster, 3500);
            The_Bloodthirster.Register();

            Item Thornmail = new Item("Thornmail", Resources.Thornmail, 2900);
            Thornmail.Register();

            Item Titanic_Hydra = new Item("Titanic Hydra", Resources.Titanic_Hydra, 3500);
            Titanic_Hydra.Register();

            Item Trinity_Force = new Item("Trinity Force", Resources.Trinity_Force, 3733);
            Trinity_Force.Register();

            Item Twin_Shadows = new Item("Twin Shadows", Resources.Twin_Shadows, 2400);
            Twin_Shadows.Register();
            #endregion
            #region V
            Item Void_Staff = new Item("Void Staff", Resources.Void_Staff, 2650);
            Void_Staff.Register();
            #endregion
            #region W
            Item Warmogs_Armor = new Item("Warmog's Armor", Resources.Warmogs_Armor, 2850);
            Warmogs_Armor.Register();

            Item Wits_End = new Item("Wit's End", Resources.Wits_End, 2900);
            Wits_End.Register();
            #endregion
            #region Y
            Item Youmuus_Ghostblade = new Item("Youmuu's Ghostblade", Resources.Youmuus_Ghostblade, 2900);
            Youmuus_Ghostblade.Register();
            #endregion
            #region Z
            Item Zekes_Convergence = new Item("Zeke's Convergence", Resources.Zekes_Convergence, 2250);
            Zekes_Convergence.Register();

            Item Zhonyas_Hourglass = new Item("Zhonya's Hourglass", Resources.Zhonyas_Hourglass, 2900);
            Zhonyas_Hourglass.Register();

            Item Zzrot_Portal = new Item("Zz'Rot Portal", Resources.Zzrot_Portal, 2700);
            Zzrot_Portal.Register();
            #endregion

            InitFilters();
        }

        /// <summary>
        /// Initiates the filters
        /// </summary>
        public static void InitFilters() {
            manaItemFilter = new List<Item>() { GetItem("Archangel's Staff"),
                GetItem("Manamune")
            };

            apItemFilter = new List<Item>() { GetItem("Archangel's Staff"),
                GetItem("Ardent Censer"),
                GetItem("Athene's Unholy Grail"),
                GetItem("Banshee's Veil"),
                GetItem("Hextech GLP-800"),
                GetItem("Hextech Protobelt-01"),
                GetItem("Liandry's Torment"),
                GetItem("Lich Bane"),
                GetItem("Luden's Echo"),
                GetItem("Mejai's Soulstealer"),
                GetItem("Morellonomicon"),
                GetItem("Nashor's Tooth"),
                GetItem("Rabadon's Deathcap"),
                GetItem("Rod of Ages"),
                GetItem("Rylai's Crystal Scepter"),
                GetItem("Shurelya's Reverie"),
                GetItem("Sorcerer's Shoes"),
                GetItem("Spellbinder"),
                GetItem("Twin Shadows"),
                GetItem("Void Staff"),
                GetItem("Zhonya's Hourglass")
            };

            rangedItemFilter = new List<Item>() { GetItem("Runaan's Hurricane") };

            meleeItemFilter = new List<Item>() { GetItem("Ravenous Hydra"),
                GetItem("Titanic Hydra"),
                GetItem("Sterak's Gage")
            };

            bootsItemFilter = new List<Item>() {   GetItem("Berserker's Greaves"),
                GetItem("Boots of Mobility"),
                GetItem("Boots of Swiftness"),
                GetItem("Ionian Boots of Lucidity"),
                GetItem("Mercury's Treads"),
                GetItem("Ninja Tabi"),
                GetItem("Sorcerer's Shoes")
            };
        }

        /// <summary>
        /// Gets an Item from the Dictionary
        /// </summary>
        /// <param name="itemName">The item name</param>
        /// <returns>The item in the dictionary</returns>
        public static Item GetItem(string itemName) => itemList.ContainsKey(itemName) ? itemList[itemName] : null;

        /// <summary>
        /// A list of all items that primarily focus on giving mana
        /// </summary>
        public static List<Item> manaItemFilter;

        /// <summary>
        /// A list of all items that primarily focus on giving AP (or give AP as one of its main points)
        /// </summary>
        public static List<Item> apItemFilter;

        /// <summary>
        /// A list of all ranged only items
        /// </summary>
        public static List<Item> rangedItemFilter;

        /// <summary>
        /// A list of all melee only items
        /// </summary>
        public static List<Item> meleeItemFilter;

        /// <summary>
        /// A list of all boots
        /// </summary>
        public static List<Item> bootsItemFilter;
        #endregion

        /// <summary>
        /// The name of the Item
        /// </summary>
        public string name { get; private set; }
        /// <summary>
        /// The gold cost of the Item
        /// </summary>
        public int goldCost { get; private set; }

        /// <summary>
        /// The sprite for the Item
        /// </summary>
        public Bitmap sprite { get; private set; }

        /// <summary>
        /// Indicates whether the item are boots
        /// </summary>
        public bool isBoot { get; private set; } = false;
        /// <summary>
        /// Indicates whether the item is a gold item
        /// </summary>
        public bool isGoldItem { get; private set; } = false;

        /// <summary>
        /// Initializes a new Item
        /// </summary>
        /// <param name="name">The name of the Item</param>
        /// <param name="sprite">The sprite for the Item</param>
        /// <param name="goldCost">The gold cost of the Item</param>
        private Item(string name, Bitmap sprite, int goldCost) {
            this.name = name;
            this.sprite = sprite;
            this.goldCost = goldCost;
        }

        /// <summary>
        /// Creates a string with the gold cost of the item, followed by the name of the item
        /// </summary>
        /// <returns>The string of this Item</returns>
        public override string ToString() => goldCost + "\t" + (goldCost < 1000 ? "\t" : "") + name; // we add another tab if the goldcost is less than a thousand so everything lines up nicely

        public void Register() => itemList.Add(name, this);
    }
}
