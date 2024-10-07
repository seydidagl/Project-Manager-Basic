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
    public partial class ProjeDurumuForm : Form
    {
        public MainForm.ProjeDurumu SecilenProjeDurumu { get; private set; }
        public ProjeDurumuForm()
        {
            InitializeComponent();
            // Proje durumlarını ComboBox'a ekle
            cmbProjeDurumları.DataSource = Enum.GetValues(typeof(MainForm.ProjeDurumu));

            cmbProjeDurumları.SelectedIndex = 0; // Varsayılan olarak ilk proje durumunu seç
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Seçilen proje durumunu al
            SecilenProjeDurumu = (MainForm.ProjeDurumu)cmbProjeDurumları.SelectedItem;

            // Diğer kaydetme işlemlerini gerçekleştirin...
            // Veritabanına ekleme, güncelleme vb.
        }
    }
}
