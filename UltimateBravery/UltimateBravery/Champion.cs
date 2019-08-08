using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBravery.Properties;

namespace UltimateBravery {
    /// <summary>
    /// A champion that can be picked
    /// </summary>
    public class Champion {
        /// <summary>
        /// A list of every champion registered
        /// </summary>
        public static Dictionary<string, Champion> championList = new Dictionary<string, Champion>();

        /// <summary>
        /// Initializes the list of champions
        /// </summary>
        public static void InitChampionList() {
            #region A
            Champion Aatrox = new Champion("Aatrox", Resources.Aatrox);
            Aatrox.BlacklistItems(Item.apItemFilter);
            Aatrox.BlacklistItems(Item.manaItemFilter);
            Aatrox.BlacklistItems(Item.rangedItemFilter);
            Aatrox.Register();

            Champion Ahri = new Champion("Ahri", Resources.Ahri);
            Ahri.BlacklistItems(Item.meleeItemFilter);
            Ahri.Register();

            Champion Akali = new Champion("Akali", Resources.Akali);
            Akali.BlacklistItems(Item.manaItemFilter);
            Akali.BlacklistItems(Item.rangedItemFilter);
            Akali.Register();

            Champion Alistar = new Champion("Alistar", Resources.Alistar);
            Alistar.BlacklistItems(Item.rangedItemFilter);
            Alistar.Register();

            Champion Amumu = new Champion("Amumu", Resources.Amumu);
            Amumu.BlacklistItems(Item.rangedItemFilter);
            Amumu.Register();

            Champion Anivia = new Champion("Anivia", Resources.Anivia);
            Anivia.BlacklistItems(Item.meleeItemFilter);
            Anivia.Register();

            Champion Annie = new Champion("Annie", Resources.Annie);
            Annie.BlacklistItems(Item.meleeItemFilter);
            Annie.Register();

            Champion Ashe = new Champion("Ashe", Resources.Ashe);
            Ashe.BlacklistItems(Item.meleeItemFilter);
            Ashe.Register();

            Champion Aurelion_Sol = new Champion("Aurelion Sol", Resources.Aurelion_Sol);
            Aurelion_Sol.BlacklistItems(Item.meleeItemFilter);
            Aurelion_Sol.Register();

            Champion Azir = new Champion("Azir", Resources.Azir);
            Azir.BlacklistItems(Item.meleeItemFilter);
            Azir.Register();
            #endregion
            #region B
            Champion Bard = new Champion("Bard", Resources.Bard);
            Bard.BlacklistItems(Item.meleeItemFilter);
            Bard.Register();

            Champion Blitzcrank = new Champion("Blitzcrank", Resources.Blitzcrank);
            Blitzcrank.BlacklistItems(Item.rangedItemFilter);
            Blitzcrank.Register();

            Champion Brand = new Champion("Brand", Resources.Brand);
            Brand.BlacklistItems(Item.meleeItemFilter);
            Brand.Register();

            Champion Braum = new Champion("Braum", Resources.Braum);
            Braum.BlacklistItems(Item.rangedItemFilter);
            Braum.Register();
            #endregion
            #region C
            Champion Caitlyn = new Champion("Caitlyn", Resources.Caitlyn);
            Caitlyn.BlacklistItems(Item.meleeItemFilter);
            Caitlyn.Register();

            Champion Camille = new Champion("Camille", Resources.Camille);
            Camille.BlacklistItems(Item.rangedItemFilter);
            Camille.BlacklistItems(Item.apItemFilter);
            Camille.Register();

            Champion Cassiopeia = new Champion("Cassiopeia", Resources.Cassiopeia);
            Cassiopeia.BlacklistItems(Item.meleeItemFilter);
            Cassiopeia.BlacklistItems(Item.bootsItemFilter);
            Cassiopeia.Register();

            Champion ChoGath = new Champion("Cho'Gath", Resources.ChoGath);
            ChoGath.BlacklistItems(Item.rangedItemFilter);
            ChoGath.Register();

            Champion Corki = new Champion("Corki", Resources.Corki);
            Corki.BlacklistItems(Item.meleeItemFilter);
            Corki.Register();
            #endregion
            #region D
            Champion Darius = new Champion("Darius", Resources.Darius);
            Darius.BlacklistItems(Item.rangedItemFilter);
            Darius.BlacklistItems(Item.apItemFilter);
            Darius.Register();

            Champion Diana = new Champion("Diana", Resources.Diana);
            Diana.BlacklistItems(Item.rangedItemFilter);
            Diana.Register();

            Champion Dr_Mundo = new Champion("Dr. Mundo", Resources.Dr_Mundo);
            Dr_Mundo.BlacklistItems(Item.rangedItemFilter);
            Dr_Mundo.BlacklistItems(Item.manaItemFilter);
            Dr_Mundo.Register();

            Champion Draven = new Champion("Draven", Resources.Draven);
            Draven.BlacklistItems(Item.meleeItemFilter);
            Draven.BlacklistItems(Item.apItemFilter);
            Draven.Register();
            #endregion
            #region E
            Champion Ekko = new Champion("Ekko", Resources.Ekko);
            Ekko.BlacklistItems(Item.rangedItemFilter);
            Ekko.Register();

            Champion Elise = new Champion("Elise", Resources.Elise);
            Elise.Register();

            Champion Evelynn = new Champion("Evelynn", Resources.Evelynn);
            Evelynn.BlacklistItems(Item.rangedItemFilter);
            Evelynn.Register();

            Champion Ezreal = new Champion("Ezreal", Resources.Ezreal);
            Ezreal.BlacklistItems(Item.meleeItemFilter);
            Ezreal.Register();
            #endregion E
            #region F
            Champion Fiddlesticks = new Champion("Fiddlesticks", Resources.Fiddlesticks);
            Fiddlesticks.BlacklistItems(Item.meleeItemFilter);
            Fiddlesticks.Register();

            Champion Fiora = new Champion("Fiora", Resources.Fiora);
            Fiora.BlacklistItems(Item.rangedItemFilter);
            Fiora.Register();

            Champion Fizz = new Champion("Fizz", Resources.Fizz);
            Fizz.BlacklistItems(Item.rangedItemFilter);
            Fizz.Register();
            #endregion
            #region G
            Champion Galio = new Champion("Galio", Resources.Galio);
            Galio.BlacklistItems(Item.rangedItemFilter);
            Galio.Register();

            Champion Gangplank = new Champion("Gangplank", Resources.Gangplank);
            Gangplank.BlacklistItems(Item.rangedItemFilter);
            Gangplank.Register();

            Champion Garen = new Champion("Garen", Resources.Garen);
            Garen.BlacklistItems(Item.rangedItemFilter);
            Garen.BlacklistItems(Item.manaItemFilter);
            Garen.BlacklistItems(Item.apItemFilter);
            Garen.Register();

            Champion Gnar = new Champion("Gnar", Resources.Gnar);
            Gnar.BlacklistItems(Item.manaItemFilter);
            Gnar.Register();

            Champion Gragas = new Champion("Gragas", Resources.Gragas);
            Gragas.BlacklistItems(Item.rangedItemFilter);
            Gragas.Register();

            Champion Graves = new Champion("Graves", Resources.Graves);
            Graves.BlacklistItems(Item.meleeItemFilter);
            Graves.Register();
            #endregion
            #region H
            Champion Hecarim = new Champion("Hecarim", Resources.Hecarim);
            Hecarim.BlacklistItems(Item.rangedItemFilter);
            Hecarim.Register();

            Champion Heimerdinger = new Champion("Heimerdinger", Resources.Heimerdinger);
            Heimerdinger.BlacklistItems(Item.meleeItemFilter);
            Heimerdinger.Register();
            #endregion
            #region I
            Champion Illaoi = new Champion("Illaoi", Resources.Illaoi);
            Illaoi.BlacklistItems(Item.rangedItemFilter);
            Illaoi.Register();

            Champion Irelia = new Champion("Irelia", Resources.Irelia);
            Irelia.BlacklistItems(Item.rangedItemFilter);
            Irelia.Register();

            Champion Ivern = new Champion("Ivern", Resources.Ivern);
            Ivern.BlacklistItems(Item.rangedItemFilter);
            Ivern.Register();
            #endregion
            #region J
            Champion Janna = new Champion("Janna", Resources.Janna);
            Janna.BlacklistItems(Item.meleeItemFilter);
            Janna.Register();

            Champion Jarvan_IV = new Champion("Jarvan IV", Resources.Jarvan);
            Jarvan_IV.BlacklistItems(Item.rangedItemFilter);
            Jarvan_IV.Register();

            Champion Jax = new Champion("Jax", Resources.Jax);
            Jax.BlacklistItems(Item.rangedItemFilter);
            Jax.Register();

            Champion Jayce = new Champion("Jayce", Resources.Jayce);
            Jayce.Register();

            Champion Jhin = new Champion("Jhin", Resources.Jhin);
            Jhin.BlacklistItems(Item.meleeItemFilter);
            Jhin.Register();

            Champion Jinx = new Champion("Jinx", Resources.Jinx);
            Jinx.BlacklistItems(Item.meleeItemFilter);
            Jinx.Register();
            #endregion
            #region K
            Champion KaiSa = new Champion("Kai'Sa", Resources.KaiSa);
            KaiSa.BlacklistItems(Item.meleeItemFilter);
            KaiSa.Register();

            Champion Kalista = new Champion("Kalista", Resources.Kalista);
            Kalista.BlacklistItems(Item.meleeItemFilter);
            Kalista.BlacklistItems(Item.apItemFilter);
            Kalista.Register();

            Champion Karma = new Champion("Karma", Resources.Karma);
            Karma.BlacklistItems(Item.meleeItemFilter);
            Karma.Register();

            Champion Karthus = new Champion("Karthus", Resources.Karthus);
            Karthus.BlacklistItems(Item.meleeItemFilter);
            Karthus.Register();

            Champion Kassadin = new Champion("Kassadin", Resources.Kassadin);
            Kassadin.BlacklistItems(Item.rangedItemFilter);
            Kassadin.Register();

            Champion Katarina = new Champion("Katarina", Resources.Katarina);
            Katarina.BlacklistItems(Item.rangedItemFilter);
            Katarina.Register();

            Champion Kayle = new Champion("Kayle", Resources.Kayle);
            Kayle.BlacklistItems(Item.meleeItemFilter);
            Kayle.Register();

            Champion Kayn = new Champion("Kayn", Resources.Kayn);
            Kayn.BlacklistItems(Item.rangedItemFilter);
            Kayn.BlacklistItems(Item.apItemFilter);
            Kayn.Register();

            Champion Kennen = new Champion("Kennen", Resources.Kennen);
            Kennen.BlacklistItems(Item.meleeItemFilter);
            Kennen.BlacklistItems(Item.manaItemFilter);
            Kennen.Register();

            Champion KhaZis = new Champion("Kha'Zix", Resources.KhaZix);
            KhaZis.BlacklistItems(Item.rangedItemFilter);
            KhaZis.Register();

            Champion Kindred = new Champion("Kindred", Resources.Kindred);
            Kindred.BlacklistItems(Item.meleeItemFilter);
            Kindred.BlacklistItems(Item.apItemFilter);
            Kindred.Register();

            Champion Kled = new Champion("Kled", Resources.Kled);
            Kled.BlacklistItems(Item.apItemFilter);
            Kled.BlacklistItems(Item.rangedItemFilter);
            Kled.BlacklistItems(Item.manaItemFilter);
            Kled.Register();

            Champion KogMaw = new Champion("Kog'Maw", Resources.KogMaw);
            KogMaw.BlacklistItems(Item.meleeItemFilter);
            KogMaw.Register();
            #endregion
            #region L
            Champion LeBlanc = new Champion("LeBlanc", Resources.Leblanc);
            LeBlanc.BlacklistItems(Item.meleeItemFilter);
            LeBlanc.Register();

            Champion Lee_Sin = new Champion("Lee Sin", Resources.Lee_Sin);
            Lee_Sin.BlacklistItems(Item.rangedItemFilter);
            Lee_Sin.BlacklistItems(Item.manaItemFilter);
            Lee_Sin.Register();

            Champion Leona = new Champion("Leona", Resources.Leona);
            Leona.BlacklistItems(Item.rangedItemFilter);
            Leona.Register();

            Champion Lissandra = new Champion("Lissandra", Resources.Lissandra);
            Lissandra.BlacklistItems(Item.meleeItemFilter);
            Lissandra.Register();

            Champion Lucian = new Champion("Lucian", Resources.Lucian);
            Lucian.BlacklistItems(Item.meleeItemFilter);
            Lucian.Register();

            Champion Lulu = new Champion("Lulu", Resources.Lulu);
            Lulu.BlacklistItems(Item.meleeItemFilter);
            Lulu.Register();

            Champion Lux = new Champion("Lux", Resources.Lux);
            Lux.BlacklistItems(Item.meleeItemFilter);
            Lux.Register();
            #endregion
            #region M
            Champion Malphite = new Champion("Malphite", Resources.Malphite);
            Malphite.BlacklistItems(Item.rangedItemFilter);
            Malphite.Register();

            Champion Malzahar = new Champion("Malzahar", Resources.Malzahar);
            Malzahar.BlacklistItems(Item.meleeItemFilter);
            Malzahar.Register();

            Champion Maokai = new Champion("Maokai", Resources.Maokai);
            Maokai.BlacklistItems(Item.rangedItemFilter);
            Maokai.Register();

            Champion Master_Yi = new Champion("Master Yi", Resources.Master_Yi);
            Master_Yi.BlacklistItems(Item.rangedItemFilter);
            Master_Yi.Register();

            Champion Miss_Fortune = new Champion("Miss Fortune", Resources.Miss_Fortune);
            Miss_Fortune.BlacklistItems(Item.meleeItemFilter);
            Miss_Fortune.Register();

            Champion Mordekaiser = new Champion("Mordekaiser", Resources.Mordekaiser);
            Mordekaiser.BlacklistItems(Item.rangedItemFilter);
            Mordekaiser.BlacklistItems(Item.manaItemFilter);
            Mordekaiser.Register();

            Champion Morgana = new Champion("Morgana", Resources.Morgana);
            Morgana.BlacklistItems(Item.meleeItemFilter);
            Morgana.Register();
            #endregion
            #region N
            Champion Nami = new Champion("Nami", Resources.Nami);
            Nami.BlacklistItems(Item.meleeItemFilter);
            Nami.Register();

            Champion Nasus = new Champion("Nasus", Resources.Nasus);
            Nasus.BlacklistItems(Item.rangedItemFilter);
            Nasus.Register();

            Champion Nautilus = new Champion("Nautilus", Resources.Nautilus);
            Nautilus.BlacklistItems(Item.rangedItemFilter);
            Nautilus.Register();

            Champion Neeko = new Champion("Neeko", Resources.Neeko);
            Neeko.BlacklistItems(Item.meleeItemFilter);
            Neeko.Register();

            Champion Nidalee = new Champion("Nidalee", Resources.Nidalee);
            Nidalee.Register();

            Champion Nocturne = new Champion("Nocturne", Resources.Nocturne);
            Nocturne.BlacklistItems(Item.rangedItemFilter);
            Nocturne.Register();

            Champion Nunu = new Champion("Nunu", Resources.Nunu);
            Nunu.BlacklistItems(Item.rangedItemFilter);
            Nunu.Register();
            #endregion
            #region O
            Champion Olaf = new Champion("Olaf", Resources.Olaf);
            Olaf.BlacklistItems(Item.rangedItemFilter);
            Olaf.BlacklistItems(Item.apItemFilter);
            Olaf.Register();

            Champion Orianna = new Champion("Orianna", Resources.Orianna);
            Orianna.BlacklistItems(Item.meleeItemFilter);
            Orianna.Register();

            Champion Ornn = new Champion("Ornn", Resources.Ornn);
            Ornn.BlacklistItems(Item.rangedItemFilter);
            Ornn.Register();
            #endregion
            #region P
            Champion Pantheon = new Champion("Pantheon", Resources.Pantheon);
            Pantheon.BlacklistItems(Item.rangedItemFilter);
            Pantheon.Register();

            Champion Poppy = new Champion("Poppy", Resources.Poppy);
            Poppy.BlacklistItems(Item.rangedItemFilter);
            Poppy.Register();

            Champion Pyke = new Champion("Pyke", Resources.Pyke);
            Pyke.BlacklistItems(Item.rangedItemFilter);
            Pyke.BlacklistItems(Item.apItemFilter);
            Pyke.Register();
            #endregion
            #region Q
            Champion Qiyana = new Champion("Qiyana", Resources.Qiyana);
            Qiyana.BlacklistItems(Item.rangedItemFilter);
            Qiyana.Register();

            Champion Quinn = new Champion("Quinn", Resources.Quinn);
            Quinn.BlacklistItems(Item.meleeItemFilter);
            Quinn.Register();
            #endregion
            #region R
            Champion Rakan = new Champion("Rakan", Resources.Rakan);
            Rakan.BlacklistItems(Item.meleeItemFilter);
            Rakan.Register();

            Champion Rammus = new Champion("Rammus", Resources.Rammus);
            Rammus.BlacklistItems(Item.rangedItemFilter);
            Rammus.Register();

            Champion RekSai = new Champion("Rek'Sai", Resources.RekSai);
            RekSai.BlacklistItems(Item.rangedItemFilter);
            RekSai.BlacklistItems(Item.manaItemFilter);
            RekSai.Register();

            Champion Renekton = new Champion("Renekton", Resources.Renekton);
            Renekton.BlacklistItems(Item.rangedItemFilter);
            RekSai.BlacklistItems(Item.manaItemFilter);
            Renekton.Register();

            Champion Rengar = new Champion("Rengar", Resources.Rengar);
            Rengar.BlacklistItems(Item.rangedItemFilter);
            Rengar.BlacklistItems(Item.manaItemFilter);
            Rengar.Register();

            Champion Riven = new Champion("Riven", Resources.Riven);
            Riven.BlacklistItems(Item.rangedItemFilter);
            Riven.BlacklistItems(Item.manaItemFilter);
            Riven.BlacklistItems(Item.apItemFilter);
            Riven.Register();

            Champion Rumble = new Champion("Rumble", Resources.Rumble);
            Rumble.BlacklistItems(Item.rangedItemFilter);
            Rumble.BlacklistItems(Item.manaItemFilter);
            Rumble.Register();

            Champion Ryze = new Champion("Ryze", Resources.Ryze);
            Ryze.BlacklistItems(Item.meleeItemFilter);
            Ryze.Register();
            #endregion
            #region S
            Champion Sejuani = new Champion("Sejuani", Resources.Sejuani);
            Sejuani.BlacklistItems(Item.rangedItemFilter);
            Sejuani.Register();

            Champion Shaco = new Champion("Shaco", Resources.Shaco);
            Shaco.BlacklistItems(Item.rangedItemFilter);
            Shaco.Register();

            Champion Shen = new Champion("Shen", Resources.Shen);
            Shen.BlacklistItems(Item.rangedItemFilter);
            Shen.BlacklistItems(Item.manaItemFilter);
            Shen.Register();

            Champion Shyvanna = new Champion("Shyvanna", Resources.Shyvana);
            Shyvanna.BlacklistItems(Item.rangedItemFilter);
            Shyvanna.BlacklistItems(Item.manaItemFilter);
            Shyvanna.Register();

            Champion Singed = new Champion("Singed", Resources.Singed);
            Singed.BlacklistItems(Item.rangedItemFilter);
            Singed.Register();

            Champion Sion = new Champion("Sion", Resources.Sion);
            Sion.BlacklistItems(Item.rangedItemFilter);
            Sion.Register();

            Champion Sivir = new Champion("Sivir", Resources.Sivir);
            Sivir.BlacklistItems(Item.meleeItemFilter);
            Sivir.Register();

            Champion Skarner = new Champion("Skarner", Resources.Skarner);
            Skarner.BlacklistItems(Item.rangedItemFilter);
            Skarner.Register();

            Champion Sona = new Champion("Sona", Resources.Sona);
            Sona.BlacklistItems(Item.meleeItemFilter);
            Sona.Register();

            Champion Soraka = new Champion("Soraka", Resources.Soraka);
            Soraka.BlacklistItems(Item.meleeItemFilter);
            Soraka.Register();

            Champion Swain = new Champion("Swain", Resources.Swain);
            Swain.BlacklistItems(Item.meleeItemFilter);
            Swain.Register();

            Champion Sylas = new Champion("Sylas", Resources.Sylas);
            Sylas.BlacklistItems(Item.rangedItemFilter);
            Sylas.Register();

            Champion Syndra = new Champion("Syndra", Resources.Syndra);
            Syndra.BlacklistItems(Item.meleeItemFilter);
            Syndra.Register();
            #endregion
            #region T
            Champion Tahm_Kench = new Champion("Tahm Kench", Resources.Tahm_Kench);
            Tahm_Kench.BlacklistItems(Item.rangedItemFilter);
            Tahm_Kench.Register();

            Champion Taliyah = new Champion("Taliyah", Resources.Taliyah);
            Taliyah.BlacklistItems(Item.meleeItemFilter);
            Taliyah.Register();

            Champion Talon = new Champion("Talon", Resources.Talon);
            Talon.BlacklistItems(Item.rangedItemFilter);
            Talon.BlacklistItems(Item.apItemFilter);
            Talon.Register();

            Champion Taric = new Champion("Taric", Resources.Taric);
            Taric.BlacklistItems(Item.rangedItemFilter);
            Taric.Register();

            Champion Teemo = new Champion("Teemo", Resources.Teemo);
            Teemo.BlacklistItems(Item.meleeItemFilter);
            Teemo.Register();

            Champion Thresh = new Champion("Thresh", Resources.Thresh);
            Thresh.BlacklistItems(Item.meleeItemFilter);
            Thresh.Register();

            Champion Tristana = new Champion("Tristana", Resources.Tristana);
            Tristana.BlacklistItems(Item.meleeItemFilter);
            Tristana.Register();

            Champion Trundle = new Champion("Trundle", Resources.Trundle);
            Trundle.BlacklistItems(Item.rangedItemFilter);
            Trundle.Register();

            Champion Tryndamere = new Champion("Tryndamere", Resources.Tryndamere);
            Tryndamere.BlacklistItems(Item.rangedItemFilter);
            Tryndamere.BlacklistItems(Item.manaItemFilter);
            Tryndamere.Register();

            Champion Twisted_Fate = new Champion("Twisted Fate", Resources.Twisted_Fate);
            Twisted_Fate.BlacklistItems(Item.meleeItemFilter);
            Twisted_Fate.Register();

            Champion Twitch = new Champion("Twitch", Resources.Twitch);
            Twitch.BlacklistItems(Item.meleeItemFilter);
            Twitch.Register();
            #endregion
            #region U
            Champion Udyr = new Champion("Udyr", Resources.Udyr);
            Udyr.BlacklistItems(Item.rangedItemFilter);
            Udyr.Register();

            Champion Urgot = new Champion("Urgot", Resources.Urgot);
            Urgot.BlacklistItems(Item.meleeItemFilter);
            Urgot.BlacklistItems(Item.apItemFilter);
            Urgot.Register();
            #endregion
            #region V
            Champion Varus = new Champion("Varus", Resources.Varus);
            Varus.BlacklistItems(Item.meleeItemFilter);
            Varus.Register();

            Champion Vayne = new Champion("Vayne", Resources.Vayne);
            Vayne.BlacklistItems(Item.meleeItemFilter);
            Vayne.BlacklistItems(Item.apItemFilter);
            Vayne.Register();

            Champion Veigar = new Champion("Veigar", Resources.Veigar);
            Veigar.BlacklistItems(Item.meleeItemFilter);
            Veigar.Register();

            Champion VelKoz = new Champion("Vel'Koz", Resources.VelKoz);
            VelKoz.BlacklistItems(Item.meleeItemFilter);
            VelKoz.Register();

            Champion Vi = new Champion("Vi", Resources.Vi);
            Vi.BlacklistItems(Item.rangedItemFilter);
            Vi.Register();

            Champion Viktor = new Champion("Viktor", Resources.Viktor);
            Viktor.BlacklistItems(Item.meleeItemFilter);
            Viktor.Register();

            Champion Vladimir = new Champion("Vladimir", Resources.Vladimir);
            Vladimir.BlacklistItems(Item.meleeItemFilter);
            Vladimir.BlacklistItems(Item.manaItemFilter);
            Vladimir.Register();

            Champion Volibear = new Champion("Volibear", Resources.Volibear);
            Volibear.BlacklistItems(Item.rangedItemFilter);
            Volibear.Register();
            #endregion
            #region W
            Champion Warwick = new Champion("Warwick", Resources.Warwick);
            Warwick.BlacklistItems(Item.rangedItemFilter);
            Warwick.Register();

            Champion Wukong = new Champion("Wukong", Resources.Wukong);
            Wukong.BlacklistItems(Item.rangedItemFilter);
            Wukong.Register();
            #endregion
            #region X
            Champion Xayah = new Champion("Xayah", Resources.Xayah);
            Xayah.BlacklistItems(Item.meleeItemFilter);
            Xayah.BlacklistItems(Item.apItemFilter);
            Xayah.Register();

            Champion Xerath = new Champion("Xerath", Resources.Xerath);
            Xerath.BlacklistItems(Item.meleeItemFilter);
            Xerath.Register();

            Champion Xin_Zhao = new Champion("Xin Zhao", Resources.Xin_Zhao);
            Xin_Zhao.BlacklistItems(Item.rangedItemFilter);
            Xin_Zhao.Register();
            #endregion
            #region Y
            Champion Yasuo = new Champion("Yasuo", Resources.Yasuo);
            Yasuo.BlacklistItems(Item.rangedItemFilter);
            Yasuo.BlacklistItems(Item.manaItemFilter);
            Yasuo.Register();

            Champion Yorick = new Champion("Yorick", Resources.Yorick);
            Yorick.BlacklistItems(Item.rangedItemFilter);
            Yorick.Register();

            Champion Yuumi = new Champion("Yuumi", Resources.Yuumi);
            Yuumi.BlacklistItems(Item.meleeItemFilter);
            Yuumi.Register();
            #endregion
            #region Z
            Champion Zac = new Champion("Zac", Resources.Zac);
            Zac.BlacklistItems(Item.rangedItemFilter);
            Zac.BlacklistItems(Item.manaItemFilter);
            Zac.Register();

            Champion Zed = new Champion("Zed", Resources.Zed);
            Zed.BlacklistItems(Item.rangedItemFilter);
            Zed.BlacklistItems(Item.apItemFilter);
            Zed.BlacklistItems(Item.manaItemFilter);
            Zed.Register();

            Champion Ziggs = new Champion("Ziggs", Resources.Ziggs);
            Ziggs.BlacklistItems(Item.meleeItemFilter);
            Ziggs.Register();

            Champion Zilean = new Champion("Zilean", Resources.Zilean);
            Zilean.BlacklistItems(Item.meleeItemFilter);
            Zilean.Register();

            Champion Zoey = new Champion("Zoey", Resources.Zoey);
            Zoey.BlacklistItems(Item.meleeItemFilter);
            Zoey.Register();

            Champion Zyra = new Champion("Zyra", Resources.Zyra);
            Zyra.BlacklistItems(Item.meleeItemFilter);
            Zyra.Register();
            #endregion
        }

        /// <summary>
        /// The name of the Champion
        /// </summary>
        public string name { get; private set; }
        /// <summary>
        /// The sprite of the champion
        /// </summary>
        public Bitmap sprite { get; private set; }

        /// <summary>
        /// A list of blacklisted items for the champion. These are items they cannot obtain, or optionally, are just straight up bad for them
        /// <para>Ex: Boots on Cassiopeia or Manamune on Aatrox (sorry Darien)</para>
        /// </summary>
        private List<Item> cblacklistedItems;

        /// <summary>
        /// Initializes a new Champion
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sprite"></param>
        private Champion(string name, Bitmap sprite) {
            this.name = name;
            this.sprite = sprite;

            cblacklistedItems = new List<Item>();
        }

        /// <summary>
        /// Adds a list of items to the blacklist
        /// </summary>
        /// <param name="items">The items to blacklist</param>
        public void BlacklistItems(List<Item> items) {
            if (items == null || items.Count <= 0)
                return;

            foreach (Item item in items) {
                if (item == null)
                    continue;

                if (cblacklistedItems.Contains(item))
                    continue;

                cblacklistedItems.Add(item);
            }
        }

        /// <summary>
        /// Gets whether an Item is blacklisted
        /// </summary>
        /// <param name="item">The item to check for</param>
        /// <returns>True if the item is blacklisted</returns>
        public bool itemIsBlacklisted(Item item) {
            if (item == null)
                return true;

            return cblacklistedItems.Contains(item);
        }

        /// <summary>
        /// Creates a string with the champion name and the list of blacklisted items
        /// </summary>
        /// <returns>The string of this Champion</returns>
        public override string ToString() {
            string returnString = name + "\n";

            foreach (Item item in cblacklistedItems)
                returnString += "\t" + item.ToString();

            return returnString;
        }

        public void Register() => championList.Add(name, this);
    }
}
