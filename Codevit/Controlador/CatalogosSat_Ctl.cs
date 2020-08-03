using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codevit.Modelo.Logica;
using Codevit.Modelo.Clases;

namespace Codevit.Controlador
{

    public class CatalogosSat_Ctl
    {

        CatalogosSat_Log objCatalogosSat = new CatalogosSat_Log();

        #region "Selecciona"

        #region "Catalogo Completo"

        public List<CatAduanas_Cls> CatalogoAduanas()
        {
            return objCatalogosSat.CatalogoAduanas();
        }

        public List<CatFormaPago_Cls> CatalogoFormaPago()
        {
            return objCatalogosSat.CatalogoFormaPago();
        }

        public List<CatMetodoPago_Cls> catalogoMetodoPago()
        {
            return objCatalogosSat.catalogoMetodoPago();
        }

        public List<CatMoneda_Cls> CatalogoMoneda()
        {
            return objCatalogosSat.CatalogoMoneda();
        }

        public List<CatProdServ_Cls> CatalogoProductoServicio()
        {
            return objCatalogosSat.CatalogoProductoServicio();
        }

        public List<CatRegimenFiscal_Cls> CatalogoRegimenFiscal()
        {
            return objCatalogosSat.CatalogoRegimenFiscal();
        }

        public List<CatTipoRelacion_Cls> CatalogoTipoRelacion()
        {
            return objCatalogosSat.CatalogoTipoRelacion();
        }

        public List<CatUsoCfdi_Cls> CatalogoUsoCfdi()
        {
            return objCatalogosSat.CatalogoUsoCfdi();
        }

        #endregion

        #region "Dato"

        public List<CatAduanas_Cls> CatalogoAduanas(int Id)
        {
            return objCatalogosSat.CatalogoAduanas(Id);
        }

        public List<CatFormaPago_Cls> CatalogoFormaPago(int Id)
        {
            return objCatalogosSat.CatalogoFormaPago(Id);
        }

        public List<CatMetodoPago_Cls> catalogoMetodoPago(int Id)
        {
            return objCatalogosSat.catalogoMetodoPago(Id);
        }

        public List<CatMoneda_Cls> CatalogoMoneda(int Id)
        {
            return objCatalogosSat.CatalogoMoneda(Id);
        }

        public List<CatProdServ_Cls> CatalogoProductoServicio(int Id)
        {
            return objCatalogosSat.CatalogoProductoServicio(Id);
        }

        public List<CatRegimenFiscal_Cls> CatalogoRegimenFiscal(int Id)
        {
            return objCatalogosSat.CatalogoRegimenFiscal(Id);
        }

        public List<CatTipoRelacion_Cls> CatalogoTipoRelacion(int Id)
        {
            return objCatalogosSat.CatalogoTipoRelacion(Id);
        }

        public List<CatUsoCfdi_Cls> CatalogoUsoCfdi(int Id)
        {
            return objCatalogosSat.CatalogoUsoCfdi(Id);
        }

        #endregion

        #endregion

    }

}
