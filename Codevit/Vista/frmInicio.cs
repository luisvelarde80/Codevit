using Codevit.Vista.Sistemas.Catalogos.Sat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codevit
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void tsmiSatAduanas_Click(object sender, EventArgs e)
        {

            frmCatAduanas frmcataduanas = new frmCatAduanas();
            frmcataduanas.MdiParent = this;
            frmcataduanas.Show();

        }

        private void tsmiSatFormaPago_Click(object sender, EventArgs e)
        {

            frmCatFormaPago frmcatformapago = new frmCatFormaPago();
            frmcatformapago.MdiParent = this;
            frmcatformapago.Show();

        }

        private void tsmiSatMetodoPago_Click(object sender, EventArgs e)
        {

            frmCatMetodoPago frmcatmetodopago = new frmCatMetodoPago();
            frmcatmetodopago.MdiParent = this;
            frmcatmetodopago.Show();

        }

        private void tsmiSatMoneda_Click(object sender, EventArgs e)
        {

            frmCatMoneda frmcatmoneda = new frmCatMoneda();
            frmcatmoneda.MdiParent = this;
            frmcatmoneda.Show();

        }

        private void tsmiSatProductoServicio_Click(object sender, EventArgs e)
        {

            frmCatProdServicio frmcatprodservicio = new frmCatProdServicio();
            frmcatprodservicio.MdiParent = this;
            frmcatprodservicio.Show();

        }

    }

}
