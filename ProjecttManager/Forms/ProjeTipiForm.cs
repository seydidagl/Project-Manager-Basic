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
    public partial class ProjeTipiForm : Form
    {
        public string SecilenProjeTipi { get; private set; }
        public ProjeTipiForm()
        {
            InitializeComponent();

            cmbProjeTipleri.Items.Add("Yurtdışı");
            cmbProjeTipleri.Items.Add("Tübitak");
            // Diğer proje tiplerini ekleyin...

            cmbProjeTipleri.SelectedIndex = 0; // Varsayılan olarak ilk proje tipini seç
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Seçilen proje tipini al
            SecilenProjeTipi = cmbProjeTipleri.SelectedItem.ToString();


        }
    }
}
