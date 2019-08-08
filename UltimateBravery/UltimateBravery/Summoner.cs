using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBravery.Properties;

namespace UltimateBravery {
    public class Summoner {
        public static Dictionary<string, Summoner> summonerSpellList { get; } = new Dictionary<string, Summoner>();

        public static void InitSummonerSpellList() {
            Summoner Heal = new Summoner("Heal", Resources.Heal);
            Heal.Register();

            Summoner Ghost = new Summoner("Ghost", Resources.Ghost);
            Ghost.Register();

            Summoner Barrier = new Summoner("Barrier", Resources.Barrier);
            Barrier.Register();

            Summoner Exhaust = new Summoner("Exhaust", Resources.Exhaust);
            Exhaust.Register();

            Summoner Clarity = new Summoner("Clarity", Resources.Clarity);
            Clarity.Register();

            Summoner Flash = new Summoner("Flash", Resources.Flash);
            Flash.Register();

            Summoner Teleport = new Summoner("Teleport", Resources.Teleport);
            Teleport.Register();

            Summoner Smite = new Summoner("Smite", Resources.Smite);
            Smite.Register();

            Summoner Cleanse = new Summoner("Cleanse", Resources.Cleanse);
            Cleanse.Register();

            Summoner Ignite = new Summoner("Ignite", Resources.Ignite);
            Ignite.Register();
        }

        public static Summoner GetSummoner(String summoner) => summonerSpellList.ContainsKey(summoner) ? summonerSpellList[summoner] : null;

        public string name { get; private set; }

        public Bitmap sprite { get; private set; }

        private Summoner(string name, Bitmap sprite) {
            this.name = name;
            this.sprite = sprite;
        }

        public void Register() => summonerSpellList.Add(name, this);
    }
}
