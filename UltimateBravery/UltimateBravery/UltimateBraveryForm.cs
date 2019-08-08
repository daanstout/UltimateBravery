using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UltimateBravery.Properties;

namespace UltimateBravery {
    public partial class UltimateBraveryForm : Form {
        /// <summary>
        /// The current bravery roll
        /// </summary>
        BraveryRoll braveryRoll;

        /// <summary>
        /// Initializes a new Ultimate Bravery Form
        /// </summary>
        public UltimateBraveryForm() {
            InitializeComponent();

            // Init the items and champions
            Item.InitItemList();
            Champion.InitChampionList();
            Summoner.InitSummonerSpellList();
            Runes.InitRunes();

            // Clear the champion combo box
            championComboBox.Items.Clear();
            championComboBox.Items.Add("Any");

            // Get the list of every champion's name and put them in the combo box
            championComboBox.Items.AddRange(Champion.championList.Values.ToList().ConvertAll(champ => champ.name).ToArray());
            championComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Allows the user to drag the window
        /// </summary>
        /// <param name="sender">The sender of the Event</param>
        /// <param name="e">The MouseEventArgs of the event</param>
        private void BannerPanel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                HandleWindowDrag();
        }

        private void HandleWindowDrag() {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HT_CAPTION = 0x2;

            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        /// <summary>
        /// Sends a message to the system
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "return")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "3")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "2")]
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        /// <summary>
        /// Releases the capture of the window
        /// </summary>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass")]
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();

        /// <summary>
        /// Rolls a random bravery roll and shows it to the user
        /// </summary>
        /// <param name="sender">The sender of the Event</param>
        /// <param name="e">The EventArgs of the event</param>
        private void RollBraveryButton_Click(object sender, EventArgs e) {
            braveryRoll = new BraveryRoll();

            braveryRoll.Roll(championComboBox.SelectedItem as string,
                guaranteeBootsCheckbox.Checked,
                preventDuplicateItemsCheckbox.Checked,
                useBlacklistCheckbox.Checked,
                guaranteeFlashCheckbox.Checked,
                maxRFirstCheckbox.Checked);

            rollPanel.Invalidate();
        }

        /// <summary>
        /// Shows the current bravery roll to the user
        /// </summary>
        /// <param name="sender">The sender of the Event</param>
        /// <param name="e">The PaintEventArgs of the Event</param>
        private void RollPanel_Paint(object sender, PaintEventArgs e) {
            // If there is no bravery roll, there is nothing to show
            if (braveryRoll == null)
                return;

            // The variables we use to draw the champion name and sprite
            Font championFont = new Font((sender as Panel).Font.FontFamily, 15);
            Point championNameLocation = new Point(10, 10);
            Point championSpriteLocation = new Point(10, 40);
            Size championSpriteSize = new Size(90, 90);

            // Draw the name with the image next to it
            e.Graphics.DrawString(braveryRoll.rolledChampion.name, championFont, Brushes.White, championNameLocation);
            e.Graphics.DrawImage(braveryRoll.rolledChampion.sprite, new Rectangle(championSpriteLocation, championSpriteSize));

            // The variables we use to draw the item name and size
            Point itemLocation = new Point(10, 150);
            Size itemSpriteSize = new Size(40, 40);
            Point itemNameOffset = new Point(0, 50);
            Font itemFont = new Font(championFont.FontFamily, 10);
            int itemNameMaxWidth = 105;

            // Draw every item
            for(int i = 0; i < 6; i++) {
                // Get the rolled item for the nth index
                Item rolledItem = braveryRoll.GetRolledItems()[i];
                // Draw the image
                // Some magic happens here, but it is quite simple
                // We calculate the x-pos by taking the item x-pos.
                // We then calculate an offset by taking the difference between the max item name width and the item sprite width, subtracting a small bit to align it better with shorter names
                // And then half it as it needs to offset on both sides
                e.Graphics.DrawImage(rolledItem.sprite, new Rectangle(new Point(itemLocation.X + ((itemNameMaxWidth - itemSpriteSize.Width - 35) / 2), itemLocation.Y), itemSpriteSize));
                // The Rectangle in which we draw the item name. It auto-fits the string to this rectangle, making sure it doesn't go past it
                // We use a large value for the height of it so we always have space for the item name
                Rectangle layoutRectangle = new Rectangle(new Point(itemLocation.X + itemNameOffset.X, itemLocation.Y + itemNameOffset.Y), new Size(itemNameMaxWidth, 100));
                e.Graphics.DrawString(rolledItem.name, itemFont, Brushes.White, layoutRectangle);

                // Update the item location to align the items next to each other
                itemLocation = new Point(itemLocation.X + itemNameMaxWidth, itemLocation.Y);
            }

            // The variables we use to draw the skills
            Point skillLocation = new Point(120, 10);
            Size skillSize = new Size(20, 20);

            // Draw the skills in max order
            for(int i = 0; i < 4; i++) {
                char skill = braveryRoll.GetSkillOrder()[i];

                e.Graphics.DrawRectangle(Pens.White, new Rectangle(skillLocation, skillSize));

                SizeF charSize = e.Graphics.MeasureString(skill.ToString(), itemFont);

                Point charLocationOffset = new Point((int)(skillSize.Width - charSize.Width) / 2, (int)(skillSize.Height - charSize.Height) / 2);

                e.Graphics.DrawString(skill.ToString(), itemFont, Brushes.White, new Point(skillLocation.X + charLocationOffset.X, skillLocation.Y + charLocationOffset.Y));

                skillLocation = new Point(skillLocation.X, skillLocation.Y + (int)(skillSize.Height * 1.25));
            }

            Point summonerLocation = new Point(150, 10);
            Size summonerSize = new Size(45, 45);

            for(int i = 0; i < 2; i++) {
                Summoner summoner = braveryRoll.GetRolledSummoners()[i];

                e.Graphics.DrawImage(summoner.sprite, new Rectangle(summonerLocation, summonerSize));

                summonerLocation = new Point(summonerLocation.X, summonerLocation.Y + summonerSize.Height + 5);
            }

            Point runeLocation = new Point(210, 10);
            Size runeSize = new Size(45, 45);

            for(int i = 0; i < 4; i++) {
                Rune rune = braveryRoll.GetFirstTree()[i];

                e.Graphics.DrawImage(rune.sprite, new Rectangle(runeLocation, runeSize));

                runeLocation = new Point(runeLocation.X + (int)(runeSize.Width * 1.25), runeLocation.Y);
            }

            runeLocation = new Point(210, 70);

            for(int i = 0; i < 2; i++) {
                Rune rune = braveryRoll.GetSecondTree()[i];

                e.Graphics.DrawImage(rune.sprite, new Rectangle(runeLocation, new Size((int)(runeSize.Width * 0.8), (int)(runeSize.Height * 0.8))));

                runeLocation = new Point(runeLocation.X + (int)(runeSize.Width), runeLocation.Y);
            }

            for(int i = 0; i < 3; i++) {
                Shard shard = braveryRoll.GetShards()[i];

                e.Graphics.DrawImage(shard.sprite, new Rectangle(runeLocation, new Size((int)(runeSize.Width * 0.6), (int)(runeSize.Height * 0.6))));

                runeLocation = new Point(runeLocation.X + (int)(runeSize.Width * 0.8), runeLocation.Y);
            }

            // The variables we use to draw the gold amount
            Point goldSpriteLocation = new Point(120, 115);
            Point goldAmountLocation = new Point(140, 115);

            // Draw the gold icon and the total gold cost of the build
            e.Graphics.DrawImage(Resources.Gold, goldSpriteLocation);
            e.Graphics.DrawString(braveryRoll.totalGoldCost.ToString(), itemFont, Brushes.Gold, goldAmountLocation);
        }

        /// <summary>
        /// Draws the title of the program to the user
        /// </summary>
        /// <param name="sender">The sender of the Event</param>
        /// <param name="e">The PaintEventArgs of the Event</param>
        private void BannerPanel_Paint(object sender, PaintEventArgs e) => e.Graphics.DrawString("Ultimate Bravery for 9.15", new Font((sender as Panel).Font.FontFamily, 12), Brushes.White, new Point(1, 1));

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender">The sender of the Event</param>
        /// <param name="e">The EventArgs of the Event</param>
        private void closeButton_Click(object sender, EventArgs e) => Close();
    }

    public class BraveryRoll {
        /// <summary>
        /// The rolled Champion
        /// </summary>
        public Champion rolledChampion { get; private set; }

        /// <summary>
        /// The rolled items
        /// </summary>
        private Item[] rolledItems = new Item[6];

        /// <summary>
        /// The rolled items
        /// </summary>
        public Item[] GetRolledItems() => rolledItems;

        /// <summary>
        /// The total gold cost of all the items
        /// </summary>
        public int totalGoldCost => GetRolledItems().Sum(item => item.goldCost);

        /// <summary>
        /// The skill order
        /// </summary>
        private char[] skillOrder = new char[4];

        /// <summary>
        /// The skill order
        /// </summary>
        public char[] GetSkillOrder() => skillOrder;

        /// <summary>
        /// The rolled summoner spells
        /// </summary>
        private Summoner[] rolledSummoners = new Summoner[2];

        /// <summary>
        /// The rolled summoner spells
        /// </summary>
        public Summoner[] GetRolledSummoners() => rolledSummoners;

        private Rune[] firstTree = new Rune[4];
        private Rune[] secondTree = new Rune[2];
        private Shard[] shards = new Shard[3];

        public Rune[] GetFirstTree() => firstTree;
        public Rune[] GetSecondTree() => secondTree;
        public Shard[] GetShards() => shards;

        /// <summary>
        /// Rolls for the champion and items
        /// </summary>
        /// <param name="guaranteeBoots">If true, guarantees that there are boots present at slot 1</param>
        /// <param name="preventDuplicates">If true, prevents the occurence of duplicate items</param>
        /// <param name="useBlacklist">If true, uses the blacklist of champions to make sure it doesn't get items that are straight up bad with it</param>
        public void Roll(string champion, bool guaranteeBoots, bool preventDuplicates, bool useBlacklist, bool guaranteeFlash, bool maxRFirst) {
            Random rand = new Random();

            RollChampion(rand, champion);

            RollSummonerSpells(rand, guaranteeFlash);

            RollItems(rand, guaranteeBoots, useBlacklist, preventDuplicates);

            RollSkills(rand, maxRFirst);

            RollRunes(rand);
        }

        private void RollChampion(Random rand, string champion) {
            if (champion.Equals("Any"))
                // Gets a random champion
                rolledChampion = Champion.championList.Values.ToList()[rand.Next(0, Champion.championList.Values.Count)];
            else
                rolledChampion = Champion.championList[champion];
        }

        private void RollItems(Random rand, bool guaranteeBoots, bool useBlacklist, bool preventDuplicates) {
            // Some indicators to make sure we don't give an invalid item build (like two boots or two gold items etc.)
            bool containsBoots = false;
            bool containsGoldItem = false;

            // If we guarantee boots, fill the first slot with boots
            // We are also making a special case that we do not do this with Cassiopeia, as she cannot purchase boots at all
            if (guaranteeBoots && !rolledChampion.name.Equals("Cassiopeia")) {
                // Get the boots
                Item boot = Item.bootsItemFilter[rand.Next(0, Item.bootsItemFilter.Count)];

                // Make sure it's not null, mainly used when not all the boots have been implemented yet
                while (boot == null)
                    boot = Item.bootsItemFilter[rand.Next(0, Item.bootsItemFilter.Count)];

                // Set the first slot to the rolled boots and set containsBoots to true
                rolledItems[0] = boot;
                containsBoots = true;
            }

            // Gets 6 random items, starts at index 1 if we guarantee boots as the 0th index contain the boots
            for (int i = containsBoots ? 1 : 0; i < 6; i++) {
                // Get a random item
                Item rolledItem = Item.itemList.Values.ToList()[rand.Next(0, Item.itemList.Values.Count)];

                // While the random item is blacklisted, or it is a boot item and we already have those, get a new item
                while ((useBlacklist && rolledChampion.itemIsBlacklisted(rolledItem)) ||
                    (rolledItem.isBoot && containsBoots) ||
                    (rolledItem.isGoldItem && containsGoldItem) ||
                    (preventDuplicates && rolledItems.Contains(rolledItem)))
                    rolledItem = Item.itemList.Values.ToList()[rand.Next(0, Item.itemList.Values.Count)];

                // This sets containsBoots to true if either containsBoots or the rolled item is true
                containsBoots |= rolledItem.isBoot;
                containsGoldItem |= rolledItem.isGoldItem;

                rolledItems[i] = rolledItem;
            }
        }

        private void RollSkills(Random rand, bool maxRFirst) {
            List<char> skills = new List<char>() {
                'Q',
                'W',
                'E'
            };

            if (maxRFirst) {
                skillOrder[0] = 'R';
            } else {
                skills.Add('R');
            }

            int currentIndex = skills.Count == 3 ? 1 : 0;
            while (skills.Count > 0) {
                int index = rand.Next(0, skills.Count);
                skillOrder[currentIndex] = skills[index];
                skills.RemoveAt(index);
                currentIndex++;
            }
        }

        private void RollSummonerSpells(Random rand, bool guaranteeFlash) {
            if (guaranteeFlash)
                rolledSummoners[0] = Summoner.GetSummoner("Flash");

            int currentSummonerIndex = guaranteeFlash ? 1 : 0;

            while (currentSummonerIndex < 2) {
                Summoner summoner = Summoner.summonerSpellList.Values.ToList()[rand.Next(0, Summoner.summonerSpellList.Values.Count)];

                if (currentSummonerIndex == 1 && summoner.Equals(rolledSummoners[0]))
                    continue;

                rolledSummoners[currentSummonerIndex] = summoner;

                currentSummonerIndex++;
            }
        }

        private void RollRunes(Random rand) {
            Runes firstPath = Runes.runePaths.Values.ToList()[rand.Next(0, Runes.runePaths.Values.Count)];

            firstTree[0] = firstPath.keystones[rand.Next(0, firstPath.keystones.Count)];
            firstTree[1] = firstPath.firstRow[rand.Next(0, firstPath.firstRow.Count)];
            firstTree[2] = firstPath.secondRow[rand.Next(0, firstPath.secondRow.Count)];
            firstTree[3] = firstPath.thirdRow[rand.Next(0, firstPath.thirdRow.Count)];

            Runes secondPath = Runes.runePaths.Values.ToList()[rand.Next(0, Runes.runePaths.Values.Count)];

            while(secondPath.name.Equals(firstPath.name))
                secondPath = Runes.runePaths.Values.ToList()[rand.Next(0, Runes.runePaths.Values.Count)];

            int firstRow = rand.Next(0, 3);

            switch (firstRow) {
                case 0:
                    secondTree[0] = secondPath.firstRow[rand.Next(0, secondPath.firstRow.Count)];
                    break;
                case 1:
                    secondTree[0] = secondPath.secondRow[rand.Next(0, secondPath.secondRow.Count)];
                    break;
                case 2:
                    secondTree[0] = secondPath.thirdRow[rand.Next(0, secondPath.thirdRow.Count)];
                    break;
            }

            int secondRow = rand.Next(0, 3);

            while(firstRow == secondRow)
                secondRow = rand.Next(0, 3);

            switch (secondRow) {
                case 0:
                    secondTree[1] = secondPath.firstRow[rand.Next(0, secondPath.firstRow.Count)];
                    break;
                case 1:
                    secondTree[1] = secondPath.secondRow[rand.Next(0, secondPath.secondRow.Count)];
                    break;
                case 2:
                    secondTree[1] = secondPath.thirdRow[rand.Next(0, secondPath.thirdRow.Count)];
                    break;
            }

            shards[0] = Shard.GetFirstRow()[rand.Next(0, Shard.GetFirstRow().Length)];
            shards[1] = Shard.GetSecondRow()[rand.Next(0, Shard.GetSecondRow().Length)];
            shards[2] = Shard.GetThirdRow()[rand.Next(0, Shard.GetThirdRow().Length)];
        }
    }
}
