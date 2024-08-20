namespace tehtava4
{
    public partial class Ikalaskuri : Form
    {
        public Ikalaskuri()
        {
            InitializeComponent();
        }

        private void Ikälaskuri_Load(object sender, EventArgs e)
        {

        }

        private void LaskeikaBT_Click(object sender, EventArgs e)
        {
            DateTime synttarit = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttarit).TotalDays);
            VuosinaLB.Text = Math.Ceiling(erotus / 365.25) + "vuotta"; //pyöristäminen lähimpään kokonaislukuun
            KuukausinaLB.Text = Math.Ceiling(erotus * 12) + "kuukautta";//Pyöristäminen lähimpään kokonaislukuun
            PaivinaLB.Text = erotus + "päivää";
            TunteinaLB.Text = (erotus * 24) + "tuntia";
            MinuutteinaLB.Text = (erotus * 24 * 60) + "minuutteina";
            SekunteinaLB.Text = (erotus * 24 * 60 * 60) + "sekuntia";

            VuosinaLB.Visible = true;
            KuukausinaLB.Visible = true;
            PaivinaLB.Visible = true;
            TunteinaLB.Visible = true;
            MinuutteinaLB.Visible = true;
            SekunteinaLB.Visible = true;

        }
    }
}
