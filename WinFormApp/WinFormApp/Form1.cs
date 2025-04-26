namespace WinFormApp
{
    public partial class Form1 : Form
    {
        string adiniz = "";
        string soyadiniz = "";
        string gozRengi = "";
        string kulakSekil = "";
        string burunTip = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void adiniz_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            adiniz = txtAdiniz.Text;
            soyadiniz = txtSoyadiniz.Text;
            
            lblSonuc.Text = "Randevu alan kişinin adı: " + adiniz + " "+ "soyadınız : " + soyadiniz + "Göz Rengi : " + gozRengi + "kulağı: " + kulakSekil +"burnu. " + burunTip;
             


        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbGozRengi_SelectedIndexChanged(object sender, EventArgs e)
        {

            // ilgili comboboxtan seçili olan elemanı bize  verir.
            gozRengi = cmbGozRengi.SelectedItem.ToString();
        }

        private void cmbKulak_SelectedIndexChanged(object sender, EventArgs e)
        {
            kulakSekil = cmbKulak.SelectedItem.ToString();
        }

        private void cmbBurun_SelectedIndexChanged(object sender, EventArgs e)
        {
           burunTip = cmbBurun.SelectedItem.ToString();
        }
    }
}
