namespace tehtava4
{
    public partial class Ikalaskuri : Form
    {
        public Ikalaskuri()
        {
            InitializeComponent();
        }

        private void Ik�laskuri_Load(object sender, EventArgs e)
        {

        }

        private void LaskeikaBT_Click(object sender, EventArgs e)
        {
            DateTime synttarit = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttarit).TotalDays);
            VuosinaLB.Text = Math.Ceiling(erotus / 365.25) + "vuotta"; //py�rist�minen l�himp��n kokonaislukuun
            KuukausinaLB.Text = Math.Ceiling(erotus * 12) + "kuukautta";//Py�rist�minen l�himp��n kokonaislukuun
            PaivinaLB.Text = erotus + "p�iv��";
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
