using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace SerializationOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void btnSerializeEt_Click(object sender, EventArgs e)
        {
            try
            {
                // böyle yapınca sanki bir constructoru varmış gibi harajet ediyor     Employee employee = new Employee(); nesneyi tanımlama da böyle
                Employee employee = new Employee
                {
                    //burada empolyee classından bir nesne oluştur oluştururken o classın içindeki değişkenlere baştan şu değerleri ata.
                    Name = txtAd.Text,
                    Phone = txtTelefon.Text,
                    Department = txtDepartman.Text,
                    DoB = dtp1.Value,
                    Salary = Convert.ToInt32(txtMaas.Text)
                };
                //constructor burada neyi serileştireceğiz onu belirliyoruz
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                //empoyee tipinde bir obje geldiğinde bunu dönüştür.
                FileStream fileStream = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                //FileStream ile ilgili işlem bittiği zaman bunun RAM'den silinmesi için using kullan
                //garbage collectora gerek kalmadan bu nesne  ile ilgili işlem tamamlamlandığında Ramden bunu temizle anlamına geliyor.
                using (fileStream)
                {
                    //satırı, C# dilinde bir nesneyi XML formatına dönüştürüp bir dosyaya yazmak için kullanılır
                    xmlSerializer.Serialize(fileStream, employee);
                    txtAd.Text = ""; //iki çift tırnak o textbox'un içini temizler.
                    txtDepartman.Text = "";
                    txtMaas.Text = "";
                    txtTelefon.Text = "";
                    MessageBox.Show("Serileştirme tamamlandı.");

                }
            }
            // eğer dosyayı oluşturamazsa
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message.ToString());

            }
        }

        private void btnDeSerializeEt_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                XmlSerializer xmlSeriazer=new XmlSerializer(typeof(Employee));
                FileStream fileStream = FileStream("employee.xml", FileMode.Open,FileAccess.Read, FileShare.None);

                using (fileStream)
                {
                    employee = (Employee)xmlSeriazer.Deserialize(fileStream);
                   
                }
            }
            catch ( Exception ex ) 
            {
                MessageBox.Show("Hata oluştu: " + ex.Message.ToString());

            }
        }

        private FileStream FileStream(string v, FileMode open, FileAccess read, FileShare none)
        {
            throw new NotImplementedException();
        }
    }
}
