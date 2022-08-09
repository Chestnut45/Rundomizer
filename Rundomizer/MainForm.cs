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

        public List<string> ORBS = new List<string>
        {
            "Stone",
            "Daggorb",
            "Sworb",
            "Sphear",
            "Bramball",
            "Rubborb",
            "Splatorb",
            "Orbsium",
            "Bouldorb",
            "Orbelisk",
            "Swoltorb",
            "Omegorb",
            "Matryorbshka",
            "Reorbanizer",
            "Allorbnothing",
            "Infernorb",
            "Icircle",
            "Ball Lightning",
            "Darkness Eterball",
            "Poltorbgeist",
            "Echorb",
            "Refreshorb",
            "Critiball",
            "Ohmygorb!",
            "Extra-Orbinary",
            "Bob-Orb",
            "Concentrication",
            "Doctorb",
            "Nosforbatu",
            "Necorbmancer",
            "Morbidorb",
            "Memorb",
            "Jack-Orb-Lantern",
            "Etherwheel",
        };

        public MainForm()
        {
            InitializeComponent();

            Task.Run(() => LoadAssets());
        }

        private void LoadAssets()
        {
            // Initialize image formatting
            OrbListView.SmallImageList = new ImageList();
            OrbListView.SmallImageList.ImageSize = new Size(60, 60);
            OrbListView.SmallImageList.ColorDepth = ColorDepth.Depth24Bit;

            OrbListView.SmallImageList.Images.Add(Image.FromFile("Orbs/Sworb.png"));
        }

        private async void GenerateRunButton_Click(object sender, EventArgs e)
        {
            // Generate the orbs and relics
            PeglinRun run = await Task.Run(() => GenerateRun());

            // Then update the form fields
            ListViewItem item = new ListViewItem(run.Orbs[0], 0);
            OrbListView.Items.Add(item);

            
        }

        private PeglinRun GenerateRun()
        {
            // Initialize lists and random number generator
            List<string> orbs = new List<string>();
            List<string> relics = new List<string>();

            Random rng = new Random();

            // Choose how many orbs / relics
            orbs.Add("testington");

            return new PeglinRun(orbs, relics);
        }
    }
}