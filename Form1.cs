namespace OtelYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowUserControl(UserControl control)
        {
            for (int i = pnlAnaSayfa.Controls.Count - 1; i >= 0; i--)
            {
                if (pnlAnaSayfa.Controls[i] is UserControl)
                {
                    pnlAnaSayfa.Controls.RemoveAt(i);
                }
            }
            pnlUst.Visible = false;
            btnRezervasyon.Visible = false;
            btnOdalar.Visible = false;
            btnMisafirler.Visible = false;
            btnPersonel.Visible = false;
            btnCikis.Visible = false;

            control.Dock = DockStyle.Fill;
            pnlAnaSayfa.Controls.Add(control);
            control.BringToFront();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyonCtrl = new Rezervasyon();
            ShowUserControl(rezervasyonCtrl);
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            Odalar odalarCtrl = new Odalar();
            ShowUserControl(odalarCtrl);
        }

        private void btnMisafirler_Click(object sender, EventArgs e)
        {
            Misafirler musteriCtrl = new Misafirler();
            ShowUserControl(musteriCtrl);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            Personeller personelCtrl = new Personeller();
            ShowUserControl(personelCtrl);
        }
        public void GoToHomePage()
        {
            if (pnlAnaSayfa != null)
            {
                for (int i = pnlAnaSayfa.Controls.Count - 1; i >= 0; i--)
                {
                    if (pnlAnaSayfa.Controls[i] is UserControl)
                    {
                        pnlAnaSayfa.Controls.RemoveAt(i);

                    }
                }

                pnlUst.Visible = true;
                btnRezervasyon.Visible = true;
                btnOdalar.Visible = true;
                btnMisafirler.Visible = true;
                btnPersonel.Visible = true;
                btnCikis.Visible = true;


            }
        }
    }
}
