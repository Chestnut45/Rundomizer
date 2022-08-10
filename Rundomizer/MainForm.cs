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

        public static readonly List<string> RELICS = new List<string>
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

        // Orb Categories
        public static readonly List<string> SINGLETARGETORBS = new List<string>
        {
            "Stone",
            "Daggorb",
            "Sworb",
            "Rubborb",
            "Splatorb",
            "Orbsium",
            "Swoltorb",
            "Omegorb",
            "Matryorbshka",
            "Reorbanizer",
            "Allorbnothing",
            "Infernorb",
            "Darkness Eterball",
            "Refreshorb",
            "Critiball",
            "Extra-Orbinary",
            "Concentrication",
            "Necorbmancer",
            "Morbidorb",
            "Memorb",
            "Jack-Orb-Lantern",
            "Etherwheel",
        };

        public static readonly List<string> AOEORBS = new List<string>
        {
            "Sphear",
            "Bramball",
            "Bouldorb",
            "Orbelisk",
            "Icircle",
            "Ball Lightning",
            "Poltorbgeist",
            "Echorb",
            "Ohmygorb!",
            "Bob-Orb",
            "Nosforbatu",
        };


        // Relic Categories
        public static readonly List<string> BOMBRELICS = new List<string>
        {
            "Bombulet",
            "Bomb Baton",
            "Enhanced Gunpowder",
            "Short Fuse",
            "Powder Collector",
            "Improved Catalyst",
            "Perfected Reactant",
            "Alchemist's Cookbook",
            "Recombombulator",
            "Sapper Sack",
            "Smoke Mod",
        };

        public static readonly List<string> CRITRELICS = new List<string>
        {
            "Complex Claw",
            "Special Button",
            "Short Stack",
            "Betsy's Hedge",
            "Critsomallos Fleece",
            "Lucky Penny",
            "Light Shaft Potion",
            "Heavy Shaft Potion",
            "Consuming Chalice",
            "Strange Brew",
        };

        public static readonly List<string> REFRESHRELICS = new List<string>
        {
            "Light Shaft Potion",
            "Heavy Shaft Potion",
            "Fresh Bandana",
            "Refillibuster",
            "Cookie",
            "Tactical Treat",
            "Refresher Course",
            "Refreshield",
            "PegBag",
            "Refreshing Punch",
            "Refreshiv",
            "Strange Brew",
        };

        
        public static readonly List<string> RELOADRELICS = new List<string>
        {
            "Round Guard",
            "Decoy Orb",
            "Bad Cheese",
            "Refreshield",
            "Dumb Bell",
            "Well-Done Steak",
            "Shrewd Scales",
            "Ambidextionary",
        };

        public static readonly List<string> HEALTHRELICS = new List<string>
        {
            "Cookie",
            "An Apple A Day",
            "The Cake",
            "Rallying Heart",
            "Wall Chicken",
            "Well-Done Steak",
            "Popping Corn",
            "Infernal Ingot",
            "Super Boots",
            "Intentional Oboe",
            "Puppet",
        };

        public static readonly List<string> BOARDRELICS = new List<string>
        {
            "Light Shaft Potion",
            "Heavy Shaft Potion",
            "Weighted Chip",
            "Tactical Treat",
            "Refreshing Punch",
            "Kinetic Meteorite",
            "Strange Brew",
            "Unicorn Horn",
            "Gift That Keeps Giving",
            "Pumpkin Pi",
            "Fresh Bandana",
            "PegBag",
            "Special Button",
            "Lucky Penny",
            "Powder Collector",
        };

        public static readonly List<string> DAMAGERELICS = new List<string>
        {
            "Weaponized Envy",
            "Mental Mantle",
            "Ring of Indignation",
            "Ambiguous Amulet",
            "Refillibuster",
            "Echo Chamber",
            "Inconspicuous Ring",
            "Safety Net",
            "Wand of Skulltimate Power",
            "Basic Blade",
            "Bad Cheese",
            "Complex Claw",
            "Dumb Bell",
            "Gardener's Gloves",
            "Salt Shaker",
            "Grabby Hand",
            "Suffer the Sling",
            "Spiral Slayer",
            "Knife's Edge",
            "Monster Training",
            "Overwhammer",
            "Pocketwatch",
            "Power Glove",
            "Shrewd Scales",
            "Cursed Mask",
            "Glorious SuffeRing",
            "Sealed Conviction",
        };

        public static readonly List<string> WEIRDRELICS = new List<string>
        {
            "Betsy's Hedge",
            "Weighted Chip",
            "Kinetic Meteorite",
            "Infernal Ingot",
            "Unicorn Horn",
            "Wand of Skulltimate Power",
            "Eye of Turtle",
            "Gardener's Gloves",
            "Salt Shaker",
            "Grabby Hand",
            "Knife's Edge",
            "Monster Training",
            "Ring of Reuse",
            "Short Stack",
            "Pumpkin Pi",
            "Consuming Chalice",
            "Cursed Mask",
            "Glorious SuffeRing",
            "Haglin's Satchel", // Doesn't work yet as of latest experimental patch 0.7.45
            "Electropegnet",
            "Matryoshka Shell",
            "Sealed Conviction",
            "Unpretentious Pendant",
        };

        public MainForm()
        {
            InitializeComponent();

            LoadAssets();

            Icon = Properties.Resources.PeglinRundomizerIcon;
        }

        private void LoadAssets()
        {
            // Focus a label so no highlighting
            OrbsLabel.Focus();
            OrbsLabel.Select();

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
            OrbsLabel.Focus();
            OrbsLabel.Select();

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

                    // Standard Reshuffled
                    for (int i = 0; i < 4; i++)
                    {
                        orbs.Add(ORBS[rng.Next(ORBS.Count)]);
                    }

                    break;

                case 1:

                    // Ol' Reliable
                    orbs.Add(ORBS[rng.Next(ORBS.Count)]);
                    relics.Add(RELICS[rng.Next(RELICS.Count)]);

                    break;

                case 2:

                    // Oh Boy, Twins!
                    int index = rng.Next(ORBS.Count);
                    orbs.Add(ORBS[index]);
                    orbs.Add(ORBS[index]);

                    break;

                case 3:

                    // Three's Company
                    for (int i = 0; i < 3; i++)
                    {
                        orbs.Add(ORBS[rng.Next(ORBS.Count)]);
                    }

                    break;

                case 4:

                    // Let's Bounce!
                    for (int i = 0; i < 3; i++)
                    {
                        index = rng.Next(3);
                        if (index == 0)
                        {
                            orbs.Add("Splatorb");
                        } else if (index == 1)
                        {
                            orbs.Add("Rubborb");
                        } else
                        {
                            orbs.Add("Infernorb");
                        }
                    }

                    break;

                case 5:

                    // Why Are You Hitting Yourself
                    for (int i = 0; i < 3; i++)
                    {
                        index = rng.Next(3);
                        if (index == 0)
                        {
                            orbs.Add("Infernorb");
                        }
                        else if (index == 1)
                        {
                            orbs.Add("Nosforbatu");
                        }
                        else
                        {
                            orbs.Add("Omegorb");
                        }
                    }

                    break;

                case 6:

                    // Stoned
                    for (int i = 0; i < 6; i++)
                    {
                        index = rng.Next(3);
                        if (index == 0)
                        {
                            orbs.Add("Stone");
                        }
                        else if (index == 1)
                        {
                            orbs.Add("Bouldorb");
                        }
                        else
                        {
                            orbs.Add("Orbelisk");
                        }
                    }

                    break;

                case 7:

                    // Phat Deck
                    int numOrbs = rng.Next(5) + 6;

                    for (int i = 0; i < numOrbs; i++)
                    {
                        orbs.Add(ORBS[rng.Next(ORBS.Count)]);
                    }

                    break;

                case 8:

                    // Over 9000
                    for (int i = 0; i < 2; i++)
                    {
                        orbs.Add(SINGLETARGETORBS[rng.Next(SINGLETARGETORBS.Count)]);
                        relics.Add(DAMAGERELICS[rng.Next(DAMAGERELICS.Count)]);
                    }

                    break;

                case 9:

                    // Knife To A Gunfight
                    for (int i = 0; i < 2; i++)
                    {
                        index = rng.Next(4);
                        if (index == 0)
                        {
                            orbs.Add("Sphear");
                        }
                        else if (index == 1)
                        {
                            orbs.Add("Sworb");
                        }
                        else if (index == 2)
                        {
                            orbs.Add("Daggorb");
                        } else
                        {
                            orbs.Add("Extra-Orbinary");
                        }
                    }

                    break;

                case 10:

                    // Glass Cannon
                    orbs.Add(AOEORBS[rng.Next(AOEORBS.Count)]);
                    relics.Add(CRITRELICS[rng.Next(CRITRELICS.Count)]);

                    break;
            }

            return new PeglinRun(orbs, relics);
        }

        private void RunTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrbsLabel.Focus();
            OrbsLabel.Select();

            switch (RunTypeDropDown.SelectedIndex)
            {
                case 0:

                    RunTypeDescription.Text = "4 random orbs, no extra relics.";

                    break;

                case 1:

                    RunTypeDescription.Text = "1 random orb, 1 extra relic.";

                    break;

                case 2:

                    RunTypeDescription.Text = "2 identical random orbs, no extra relics.";

                    break;

                case 3:

                    RunTypeDescription.Text = "3 random orbs, no extra relics.";

                    break;

                case 4:

                    RunTypeDescription.Text = "3 random bouncy orbs, no extra relics.";

                    break;

                case 5:

                    RunTypeDescription.Text = "3 random painful orbs, no extra relics.";

                    break;

                case 6:

                    RunTypeDescription.Text = "6 random rocks, no extra relics.";

                    break;

                case 7:

                    RunTypeDescription.Text = "6-10 random orbs, no extra relics.";

                    break;

                case 8:

                    RunTypeDescription.Text = "2 random single target orbs, 2 random damage relics.";

                    break;

                case 9:

                    RunTypeDescription.Text = "2 random sharp orbs, no extra relics.";

                    break;

                case 10:

                    RunTypeDescription.Text = "1 random AOE orb, 1 random crit relic.";

                    break;
            }
        }
    }
}