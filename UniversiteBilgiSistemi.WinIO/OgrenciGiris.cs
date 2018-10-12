using Core.CrossCuttingConcern.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteBilgiSistemi.Business.Abstract;
using UniversiteBilgiSistemi.Business.Conctrete;
using UniversiteBilgiSistemi.DataAccess.Concrete.EntityFramework.repositories;
using UniversiteBilgiSistemi.Model.Domain;

namespace UniversiteBilgiSistemi.WinIO
{
    public partial class OgrenciGiris : Form
    {

        OgrenciBS bs = new OgrenciBS(new EfOgrenciRepository());
        public OgrenciGiris()
        {
            InitializeComponent();
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            // string sifre = CryptoManager.AESEncrypt(txtOgrenciSifre.Text, "mehmet");


            int a = Convert.ToInt32(txtOgrencitc.Text);
            string sifre = txtOgrenciSifre.Text;
            Ogrenci ogrenci = bs.GetByTcAndPassword(a,sifre);
            if (ogrenci != null)
            {
                OgrenciEkran frm = new OgrenciEkran();
                frm.ogr = ogrenci;
                frm.ShowDialog();

               
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");


            }


        }

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {
            
            




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOgrencitc.Text = comboBox1.ValueMember;
        }
    }
}
