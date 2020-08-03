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
    public partial class frmCatMetodoPago : Form
    {
        public frmCatMetodoPago()
        {
            InitializeComponent();
            CargaMetodoPago();
        }

        private void CargaMetodoPago()
        {

            BindingSource dbMetodoPago = new BindingSource();
            CatalogosSat_Ctl objCatalogos = new CatalogosSat_Ctl();
            dbMetodoPago.DataSource = objCatalogos.catalogoMetodoPago();

            fgMetodoPago.DataSource = dbMetodoPago;
            fgMetodoPago.Cols[0].Visible = false;
            fgMetodoPago.AutoSizeCols();

        }

    }

}
