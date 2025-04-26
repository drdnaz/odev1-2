using System;
using System.Linq;
using System.Reflection; 
using System.Windows.Forms;


namespace OdemeSistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbOdeme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void btnOde_Click(object sender, EventArgs e)
        {
            if (cmbOdeme.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
                return;
            }

            if (!decimal.TryParse(txtTutar.Text, out decimal tutar))
            {
                MessageBox.Show("Geçerli bir tutar giriniz.");
                return;
            }

            try
            {
                // Seçilen sınıfın ismini bul
                string secilenSinif = cmbOdeme.SelectedItem.ToString();

                // Mevcut assembly içinde sınıfı bul
                var tip = Assembly.GetExecutingAssembly()
                                   .GetTypes()
                                   .FirstOrDefault(t => t.Name == secilenSinif && typeof(IOdemeYontemi).IsAssignableFrom(t));

                if (tip == null)
                {
                    MessageBox.Show("Ödeme yöntemi bulunamadı!");
                    return;
                }

                // Sınıfı yarat (new KrediKarti() gibi)
                IOdemeYontemi odemeYontemi = (IOdemeYontemi)Activator.CreateInstance(tip);

                // Ode metodunu çağır
                string sonuc = odemeYontemi.Ode(tutar);

                lblSonuc.Text = sonuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cmbOdeme.Items.Add("KrediKarti");
            cmbOdeme.Items.Add("Havale");
            cmbOdeme.Items.Add("EFT");
        }
    }
}
