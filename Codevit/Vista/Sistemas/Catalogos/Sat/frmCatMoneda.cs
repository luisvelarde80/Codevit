﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codevit.Controlador;

namespace Codevit.Vista.Sistemas.Catalogos.Sat
{
    public partial class frmCatMoneda : Form
    {
        public frmCatMoneda()
        {
            InitializeComponent();
            CargaMoneda();
        }

        private void CargaMoneda()
        {

            BindingSource dbMoneda = new BindingSource();
            CatalogosSat_Ctl objCatalogos = new CatalogosSat_Ctl();
            dbMoneda.DataSource = objCatalogos.CatalogoMoneda();

            fgMoneda.DataSource = dbMoneda;
            fgMoneda.Cols[0].Visible = false;
            fgMoneda.AutoSizeCols();

        }

    }

}
