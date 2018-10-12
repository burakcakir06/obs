using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteBilgiSistemi.Model.Domain;

namespace UniversiteBilgiSistemi.WinIO
{
    public partial class OgrenciEkran : Form
    {
        public Ogrenci ogr;
        public OgrenciEkran()
        {
           
            InitializeComponent();
        }

        private void OgrenciEkran_Load(object sender, EventArgs e)
        {
            LblName.Text = ogr.Ogrenci_adi + " " + ogr.Ogrenci_soyadi + " " + ogr.Ogrenci_tc;
            LblSurname.Text = ogr.id +" ";
        }
    }
}
