﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBCRijekaKantridaRegistar.GUI
{
    public partial class OsnovniPodaci : Form
    {
        public OsnovniPodaci()
        {
            InitializeComponent();
        }

        private void btnDaljeOsnovniPodaci_Click(object sender, EventArgs e)
        {
            unos.Ime = txtOsnovnipodatciIme1.Text;
            unos.Prezime = txtOsnovnipodatciPrezime.Text;
            unos.ImeOca = txtOsnovnipodatciImeoca.Text;
            unos.ImeMajke = txtOsnovnipodatciImemajke.Text;
            unos.Adresa = txtOsnovnipodatciAdresa.Text;
            unos.DatumRodenja = Convert.ToDateTime(txtOsnovnipodatciDatumrođenja.Text);
            unos.Spol = txtOsnovnipodatciSpol.Text;


        }
    }
}