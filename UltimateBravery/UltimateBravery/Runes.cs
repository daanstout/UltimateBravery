using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBravery.Properties;

namespace UltimateBravery {
    public class Runes {
        public static Dictionary<string, Runes> runePaths { get; } = new Dictionary<string, Runes>();
        public static Dictionary<string, Shard> shards { get; } = new Dictionary<string, Shard>();

        public static void InitRunes() {
            #region Precision
            Runes Precision = new Runes("Precision");

            Precision.keystones.Add(new Rune("Press the Attack", Resources.Press_The_Attack));
            Precision.keystones.Add(new Rune("Lethal Tempo", Resources.Lethal_Tempo));
            Precision.keystones.Add(new Rune("Fleet Footwork", Resources.Fleet_Footwork));
            Precision.keystones.Add(new Rune("Conqueror", Resources.Conquerer));

            Precision.firstRow.Add(new Rune("Overheal", Resources.Overheal));
            Precision.firstRow.Add(new Rune("Triumph", Resources.Triumph));
            Precision.firstRow.Add(new Rune("Presence of Mind", Resources.Presence_of_Mind));

            Precision.secondRow.Add(new Rune("Legend: Alacrity", Resources.Legend_Alacrity));
            Precision.secondRow.Add(new Rune("Legend: Tenacity", Resources.Legend_Tenacity));
            Precision.secondRow.Add(new Rune("Legend: Bloodline", Resources.Legend_Bloodline));

            Precision.thirdRow.Add(new Rune("Coup de Grace", Resources.Coup_de_Grace));
            Precision.thirdRow.Add(new Rune("Cut Down", Resources.Cut_Down));
            Precision.thirdRow.Add(new Rune("Last Stand", Resources.Last_Stand));

            Precision.Register();
            #endregion
            #region Domination
            Runes Domination = new Runes("Domination");

            Domination.keystones.Add(new Rune("Electrocute", Resources.Electrocute));
            Domination.keystones.Add(new Rune("Predator", Resources.Predator));
            Domination.keystones.Add(new Rune("Dark Harvest", Resources.Dark_Harvest));
            Domination.keystones.Add(new Rune("Hail of Blades", Resources.Hail_of_Blades));

            Domination.firstRow.Add(new Rune("Cheap Shot", Resources.Cheap_Shot));
            Domination.firstRow.Add(new Rune("Taste of Blood", Resources.Taste_of_Blood));
            Domination.firstRow.Add(new Rune("Sudden Impact", Resources.Sudden_Impact));

            Domination.secondRow.Add(new Rune("Zombie Ward", Resources.Zombie_Ward));
            Domination.secondRow.Add(new Rune("Ghost Poro", Resources.Ghost_Poro));
            Domination.secondRow.Add(new Rune("Eyeball Collection", Resources.Eyeball_Collection));

            Domination.thirdRow.Add(new Rune("Ravenous Hunter", Resources.Ravenous_Hunter));
            Domination.thirdRow.Add(new Rune("Ingenious Hunter", Resources.Ingenious_Hunter));
            Domination.thirdRow.Add(new Rune("Relentless Hunter", Resources.Relentless_Hunter));
            Domination.thirdRow.Add(new Rune("Ultimate Hunter", Resources.Ultimate_Hunter));

            Domination.Register();
            #endregion
            #region Sorcery
            Runes Sorcery = new Runes("Sorcery");

            Sorcery.keystones.Add(new Rune("Summon Aery", Resources.Summon_Aery));
            Sorcery.keystones.Add(new Rune("Arcane Comet", Resources.Arcane_Comet));
            Sorcery.keystones.Add(new Rune("Phase Rush", Resources.Phase_Rush));

            Sorcery.firstRow.Add(new Rune("Nullifying Orb", Resources.Nullifying_Orb));
            Sorcery.firstRow.Add(new Rune("Manaflow Band", Resources.Manaflow_Band));
            Sorcery.firstRow.Add(new Rune("Nimbus Cloak", Resources.Nimbus_Cloak));

            Sorcery.secondRow.Add(new Rune("Transcendence", Resources.Transcendence));
            Sorcery.secondRow.Add(new Rune("Celerity", Resources.Celerity));
            Sorcery.secondRow.Add(new Rune("Absolute Focus", Resources.Absolute_Focus));

            Sorcery.thirdRow.Add(new Rune("Scorch", Resources.Scorch));
            Sorcery.thirdRow.Add(new Rune("Waterwalking", Resources.Waterwalking));
            Sorcery.thirdRow.Add(new Rune("Gathering Storm", Resources.Gathering_Storm));

            Sorcery.Register();
            #endregion
            #region Resolve
            Runes Resolve = new Runes("Resolve");

            Resolve.keystones.Add(new Rune("Grasp of the Undying", Resources.Grasp_of_the_Undying));
            Resolve.keystones.Add(new Rune("Aftershock", Resources.Aftershock));
            Resolve.keystones.Add(new Rune("Guardian", Resources.Guardian));

            Resolve.firstRow.Add(new Rune("Demolish", Resources.Demolish));
            Resolve.firstRow.Add(new Rune("Font of Life", Resources.Font_of_Life));
            Resolve.firstRow.Add(new Rune("Shield Bash", Resources.Shield_Bash));

            Resolve.secondRow.Add(new Rune("Conditioning", Resources.Conditioning));
            Resolve.secondRow.Add(new Rune("Second Wind", Resources.Second_Wind));
            Resolve.secondRow.Add(new Rune("Bone Plating", Resources.Bone_Plating));

            Resolve.thirdRow.Add(new Rune("Overgrowth", Resources.Overgrowth));
            Resolve.thirdRow.Add(new Rune("Revitalize", Resources.Revitalize));
            Resolve.thirdRow.Add(new Rune("Unflinching", Resources.Unflinching));

            Resolve.Register();
            #endregion
            #region Inspiration
            Runes Inspiration = new Runes("Inspiration");

            Inspiration.keystones.Add(new Rune("Glacial Augment", Resources.Glacial_Augment_Alt));
            Inspiration.keystones.Add(new Rune("Kleptomancy", Resources.Kleptomancy));
            Inspiration.keystones.Add(new Rune("Unsealed Spellbook", Resources.Unsealed_Spellbook));

            Inspiration.firstRow.Add(new Rune("Hextech Flashtraption", Resources.Hextech_Flashtraption));
            Inspiration.firstRow.Add(new Rune("Magical Footwear", Resources.Magical_Footwear));
            Inspiration.firstRow.Add(new Rune("Perfect Timing", Resources.Perfect_Timing));

            Inspiration.secondRow.Add(new Rune("Future's Market", Resources.Future_s_Market));
            Inspiration.secondRow.Add(new Rune("Minion Dematerializer", Resources.Minion_Dematerializer));
            Inspiration.secondRow.Add(new Rune("Biscuit Delivery", Resources.Biscuit_Delivery));

            Inspiration.thirdRow.Add(new Rune("Cosmic Insight", Resources.Cosmic_Insight));
            Inspiration.thirdRow.Add(new Rune("Approach Velocity", Resources.Approach_Velocity));
            Inspiration.thirdRow.Add(new Rune("Time Warp Tonic", Resources.Time_Warp_Tonic));

            Inspiration.Register();
            #endregion
            #region Shards
            Shard Adaptive_Forge = new Shard("Adaptive Force", Resources.Adaptive_Force);
            Adaptive_Forge.Register();

            Shard Attack_Speed = new Shard("Attack Speed", Resources.Attack_Speed);
            Attack_Speed.Register();

            Shard Cooldown_Reduction = new Shard("Cooldown Reduction", Resources.Cooldown_Reduction);
            Cooldown_Reduction.Register();

            Shard Armor = new Shard("Armor", Resources.Armor);
            Armor.Register();

            Shard Magic_Resist = new Shard("Magic Resist", Resources.Magic_Resistance);
            Magic_Resist.Register();

            Shard Health = new Shard("Health", Resources.Health);
            Health.Register();
            #endregion
        }

        public string name { get; private set; }

        public List<Rune> keystones { get; private set; } = new List<Rune>();

        public List<Rune> firstRow { get; private set; } = new List<Rune>();

        public List<Rune> secondRow { get; private set; } = new List<Rune>();

        public List<Rune> thirdRow { get; private set; } = new List<Rune>();

        private Runes(string name) => this.name = name;

        public void Register() => runePaths.Add(name, this);
    }

    public class Rune {
        public string name { get; private set; }
        public Bitmap sprite { get; private set; }

        public Rune(string name, Bitmap sprite) {
            this.name = name;
            this.sprite = sprite;
        }
    }

    public class Shard {
        public string name { get; private set; }
        public Bitmap sprite { get; private set; }

        public Shard(string name, Bitmap sprite) {
            this.name = name;
            this.sprite = sprite;
        }

        public void Register() => Runes.shards.Add(name, this);

        public static Shard[] GetFirstRow() => new Shard[3] { GetShard("Adaptive Force"), GetShard("Attack Speed"), GetShard("Cooldown Reduction") };
        public static Shard[] GetSecondRow() => new Shard[3] { GetShard("Adaptive Force"), GetShard("Armor"), GetShard("Magic Resist") };
        public static Shard[] GetThirdRow() => new Shard[3] { GetShard("Health"), GetShard("Armor"), GetShard("Magic Resist") };

        private static Shard GetShard(string name) => Runes.shards.ContainsKey(name) ? Runes.shards[name] : null;
    }
}
