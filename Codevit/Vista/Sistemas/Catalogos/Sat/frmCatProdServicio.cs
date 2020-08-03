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
    public partial class frmCatProdServicio : Form
    {
        public frmCatProdServicio()
        {
            InitializeComponent();
            CargaProdServicio();
        }

        public void CargaProdServicio()
        {

            BindingSource dbProdServicio = new BindingSource();
            CatalogosSat_Ctl objCatalogos = new CatalogosSat_Ctl();
            dbProdServicio.DataSource = objCatalogos.CatalogoProductoServicio();

            fgProdServicio.DataSource = dbProdServicio;
            fgProdServicio.Cols[0].Visible = false;
            fgProdServicio.AutoSizeCols();

        }

    }

}
