using System;
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
    public partial class frmCatFormaPago : Form
    {
        public frmCatFormaPago()
        {
            InitializeComponent();
            CargaFormaPago();
        }

        private void CargaFormaPago()
        {

            BindingSource dbFormaPago = new BindingSource();
            CatalogosSat_Ctl objCatalogos = new CatalogosSat_Ctl();

            dbFormaPago.DataSource = objCatalogos.CatalogoFormaPago();

            fgFormaPago.DataSource = dbFormaPago;
            fgFormaPago.Cols[0].Visible = false;
            fgFormaPago.AutoSizeCols();

        }

    }
   
}
