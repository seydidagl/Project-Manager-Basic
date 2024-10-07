using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecttManager.Forms
{
    public partial class MainForm : Form
    {
        public enum ProjeDurumu
        {
            OnayBekliyor,
            DevamEdiyor,
            Tamamlandi,
            // Diğer durumlar ekleyeniliriz...
        }

        // Kullanıcı sınıfı
        public class Kullanici
        {
            public string Ad { get; set; }
            // Diğer kullanıcı özellikleri...
        }


        public class Proje
        {
            public string ProjeAdi { get; set; }
            public string StratejikEtki { get; set; }
            public string ProjeNo { get; set; } = "PRJ" + Guid.NewGuid().ToString().Substring(0, 8);
           
            public Kullanici ProjeYurutucu { get; set; }
            public string Amac { get; set; }
            public string ProblemTanimi { get; set; }
            public string Kapsam { get; set; }
            public DateTime KayitTarihi { get; set; }
            public DateTime ProjeBaslangici { get; set; }
            public DateTime ProjeBitisi { get; set; }
            public DateTime TahminiBaslangic { get; set; }
            public DateTime TahminiBitis { get; set; }
            public ProjeDurumu Durumu { get; set; }
            public decimal ParasalGetirisi { get; set; }
            public string ParasalGetiriTipi { get; set; }
            public List<Kullanici> ProjeEkip { get; set; }
            public List<string> ProjeDokumanlari { get; set; }
            public string ProjeTipi { get; set; }
            public Dictionary<string, List<string>> KilometreTaslariGorevleri { get; set; } = new Dictionary<string, List<string>>();
        }

        public MainForm()
        {

            InitializeComponent();
            // Proje sınıfından bir örnek oluşturduk
            Proje myProject = new Proje
            {
                ProjeAdi = "Örnek Proje",
                StratejikEtki = "Stratejik Etki Açıklaması",
                ProjeNo = "PRJ" + Guid.NewGuid().ToString().Substring(0, 8), // Örnek bir Proje No oluştur
                ProjeYurutucu = new Kullanici { Ad = "Proje Yürütücü Adı" },
                Amac = "Proje Amacı",
                ProblemTanimi = "Proje Problem Tanımı",
                Kapsam = "Proje Kapsamı",
                KayitTarihi = DateTime.Now,
                ProjeBaslangici = DateTime.Now,
                ProjeBitisi = DateTime.Now.AddDays(30),
                TahminiBaslangic = DateTime.Now.AddDays(15),
                TahminiBitis = DateTime.Now.AddDays(45),
                Durumu = ProjeDurumu.OnayBekliyor,
                ParasalGetirisi = 100000.00m,
                ParasalGetiriTipi = "Aylık",
                ProjeEkip = new List<Kullanici>
                {
                    new Kullanici { Ad = "Ekip Üyesi 1" },
                    new Kullanici { Ad = "Ekip Üyesi 2" }
                },
                ProjeDokumanlari = new List<string> { "proje_dokuman1.docx", "proje_dokuman2.pdf" },
                ProjeTipi = "Yurtdışı",
                KilometreTaslariGorevleri = new Dictionary<string, List<string>>
                {
                    { "KMT1", new List<string> { "Görev1", "Görev2" } },
                    { "KMT2", new List<string> { "Görev3", "Görev4" } }
                }
            };
            
            // MainForm kontrol elemanlarına değerleri ata
            txtProjeAdi.Text = myProject.ProjeAdi;
            txtStratejikEtki.Text = myProject.StratejikEtki;
            txtProjeNo.Text = myProject.ProjeNo;
            txtProjeYurutucu.Text = myProject.ProjeYurutucu.Ad;
            txtAmac.Text = myProject.Amac;
            txtProblemTanimi.Text = myProject.ProblemTanimi;
            txtKapsam.Text = myProject.Kapsam;
            dtpKayitTarihi.Value = myProject.KayitTarihi;
            dtpProjeBaslangici.Value = myProject.ProjeBaslangici;
            dtpProjeBitisi.Value = myProject.ProjeBitisi;
            dtpTahminiBaslangic.Value = myProject.TahminiBaslangic;
            dtpTahminiBitis.Value = myProject.TahminiBitis;
            cmbProjeDurumu.Items.AddRange(Enum.GetValues(typeof(ProjeDurumu)).Cast<object>().ToArray());

            // ComboBox'ın seçili öğesini belirle
            cmbProjeDurumu.SelectedItem = myProject.Durumu;
            cmbProjeDurumu.SelectedIndex = (int)myProject.Durumu;
            numericParasalGetiri.Value = myProject.ParasalGetirisi;
            txtParasalGetiriTipi.Text = myProject.ParasalGetiriTipi;
            lbProjeEkip.Items.AddRange(myProject.ProjeEkip.ToArray());
            lbProjeDokumanlari.Items.AddRange(myProject.ProjeDokumanlari.ToArray());
            cmbProjeTipi.Text = myProject.ProjeTipi;

            // Proje Kilometre Taşları ve Görevleri TreeView'e ekle
            foreach (var kmTask in myProject.KilometreTaslariGorevleri)
            {
                TreeNode kmTaskNode = new TreeNode(kmTask.Key);
                foreach (var task in kmTask.Value)
                {
                    kmTaskNode.Nodes.Add(task);
                }
                tvKilometreTaslariGorevleri.Nodes.Add(kmTaskNode);
            }
        }



        private void btn_ProjeDurumClick(object sender, EventArgs e)
        {
            ProjeDurumuForm projeDurumuForm = new ProjeDurumuForm();
            projeDurumuForm.Show();

            // bu formu gizle
            this.Hide();
        }

        private void btnProjeTipiClick(object sender, EventArgs e)
        {
            ProjeTipiForm projeTipiForm = new ProjeTipiForm();
            projeTipiForm.Show();

            // bu formu gizle
            this.Hide();
        }
    }
}
