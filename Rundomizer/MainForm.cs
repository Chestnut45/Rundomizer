namespace Rundomizer
{
    public partial class MainForm : Form
    {
        public struct PeglinRun
        {
            public List<string> Orbs;
            public List<string> Relics;

            public PeglinRun(List<string> Orbs, List<string> Relics)
            {
                this.Orbs = Orbs;
                this.Relics = Relics;
            }
        }

        public static readonly List<string> ORBS = new List<string>
        {
            "Allorbnothing",
            "Ball Lightning",
            "Bob-Orb",
            "Bouldorb",
            "Bramball",
            "Concentrication",
            "Critiball",
            "Daggorb",
            "Darkness Eterball",
            "Doctorb",
            "Echorb",
            "Etherwheel",
            "Extra-Orbinary",
            "Icircle",
            "Infernorb",
            "Jack-Orb-Lantern",
            "Matryorbshka",
            "Memorb",
            "Morbidorb",
            "Necorbmancer",
            "Nosforbatu",
            "Ohmygorb!",
            "Omegorb",
            "Orbelisk",
            "Orbsium",
            "Poltorbgeist",
            "Refreshorb",
            "Reorbanizer",
            "Rubborb",
            "Sphear",
            "Splatorb",
            "Stone",
            "Swoltorb",
            "Sworb",
        };

        public List<string> RELICS = new List<string>
        {
            "Alchemist's Cookbook",
            "Ambidextionary",
            "Ambiguous Amulet",
            "An Apple A Day",
            "Bad Cheese",
            "Basic Blade",
            "Betsy's Hedge",
            "Bomb Baton",
            "Bombulet",
            "Complex Claw",
            "Consuming Chalice",
            "Cookie",
            "Critsomallos Fleece",
            "Cursed Mask",
            "Decoy Orb",
            "Dumb Bell",
            "Echo Chamber",
            "Electropegnet",
            "Enhanced Gunpowder",
            "Eye of Turtle",
            "Fresh Bandana",
            "Gardener's Gloves",
            "Gift That Keeps Giving",
            "Glorious SuffeRing",
            "Grabby Hand",
            "Haglin's Satchel",
            "Heavy Shaft Potion",
            "Improved Catalyst",
            "Inconspicuous Ring",
            "Infernal Ingot",
            "Intentional Oboe",
            "Kinetic Meteorite",
            "Knife's Edge",
            "Light Shaft Potion",
            "Lucky Penny",
            "Matryoshka Shell",
            "Mental Mantle",
            "Monster Training",
            "Overwhammer",
            "PegBag",
            "Perfected Reactant",
            "Pocket Sand",
            "Pocketwatch",
            "Popping Corn",
            "Powder Collector",
            "Power Glove",
            "Pumpkin Pi",
            "Puppet",
            "Rallying Heart",
            "Recombombulator",
            "Refillibuster",
            "Refresher Course",
            "Refreshield",
            "Refreshing Punch",
            "Refreshiv",
            "Ring of Indignation",
            "Ring of Reuse",
            "Round Guard",
            "Safety Net",
            "Salt Shaker",
            "Sand Arrows",
            "Sapper Sack",
            "Sealed Conviction",
            "Short Fuse",
            "Short Stack",
            "Shrewd Scales",
            "Smoke Mod",
            "Special Button",
            "Spiral Slayer",
            "Strange Brew",
            "Suffer the Sling",
            "Super Boots",
            "Tactical Treat",
            "The Cake",
            "Unicorn Horn",
            "Unpretentious Pendant",
            "Wall Chicken",
            "Wand of Skulltimate Power",
            "Weaponized Envy",
            "Weighted Chip",
            "Well-Done Steak",
        };

        public MainForm()
        {
            InitializeComponent();

            LoadAssets();
        }

        private void LoadAssets()
        {
            // Initialize the imagelists for the listviews

            // ORBS
            OrbListView.SmallImageList = new ImageList();
            OrbListView.SmallImageList.ImageSize = new Size(60, 60);
            OrbListView.SmallImageList.ColorDepth = ColorDepth.Depth24Bit;

            foreach (string orbName in ORBS)
            {
                OrbListView.SmallImageList.Images.Add(Image.FromFile("Orbs/" + orbName + ".png"));
            }

            // RELICS
            RelicListView.SmallImageList = new ImageList();
            RelicListView.SmallImageList.ImageSize = new Size(60, 60);
            RelicListView.SmallImageList.ColorDepth = ColorDepth.Depth24Bit;

            foreach (string relicName in RELICS)
            {
                RelicListView.SmallImageList.Images.Add(Image.FromFile("Relics/" + relicName + ".png"));
            }

            // Drop Down for run type default value
            RunTypeDropDown.SelectedIndex = 0;

            Panel P = new Panel();
            P.BackColor = OrbListView.BackColor;
            P.Location = OrbListView.Location;
            P.Size = OrbListView.Size;
            P.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            P.BorderStyle = OrbListView.BorderStyle;
            OrbListView.BorderStyle = BorderStyle.None;
            OrbListView.Parent = P;
            OrbListView.Dock = DockStyle.Fill;
            Controls.Add(P);

            Panel P2 = new Panel();
            P2.BackColor = RelicListView.BackColor;
            P2.Location = RelicListView.Location;
            P2.Size = RelicListView.Size;
            P2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            P2.BorderStyle = RelicListView.BorderStyle;
            RelicListView.BorderStyle = BorderStyle.None;
            RelicListView.Parent = P2;
            RelicListView.Dock = DockStyle.Fill;
            Controls.Add(P2);
        }

        private void GenerateRunButton_Click(object sender, EventArgs e)
        {
            //Fix border
            OrbListView.Focus();

            // Clear listviews
            OrbListView.Items.Clear();
            RelicListView.Items.Clear();

            // Generate the orbs and relics
            PeglinRun run = GenerateRun();

            // Update the orb listview
            foreach (string orb in run.Orbs)
            {
                ListViewItem item = new ListViewItem(orb, ORBS.IndexOf(orb));
                OrbListView.Items.Add(item);
            }

            // Update the relic listview

            foreach (string relic in run.Relics)
            {
                ListViewItem item = new ListViewItem(relic, RELICS.IndexOf(relic));
                RelicListView.Items.Add(item);
            }
        }

        private PeglinRun GenerateRun()
        {
            // Initialize lists and random number generator
            List<string> orbs = new List<string>();
            List<string> relics = new List<string>();

            Random rng = new Random();

            // Choose how many orbs / relics
            switch (RunTypeDropDown.SelectedIndex)
            {
                case 0:

                    for (int i = 0; i < 4; i++)
                    {
                        orbs.Add(ORBS[rng.Next(ORBS.Count)]);
                    }

                    break;

                case 1:

                    orbs.Add(ORBS[rng.Next(ORBS.Count)]);
                    relics.Add(RELICS[rng.Next(RELICS.Count)]);

                    break;

                case 2:
                    int numOrbs = rng.Next(5) + 6;

                    for (int i = 0; i < numOrbs; i++)
                    {
                        orbs.Add(ORBS[rng.Next(ORBS.Count)]);
                    }

                    break;
            }

            return new PeglinRun(orbs, relics);
        }

        private void RunTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RunTypeDropDown.SelectedIndex)
            {
                case 0:

                    RunTypeDescription.Text = "4 random orbs, no extra starting relics.";

                    break;

                case 1:

                    RunTypeDescription.Text = "1 random orb only, 1 extra starting relic.";

                    break;

                case 2:

                    RunTypeDescription.Text = "6-10 random orbs, no extra starting relics.";

                    break;
            }
        }
    }
}