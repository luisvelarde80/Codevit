using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codevit.Modelo.Clases;
using MySql.Data.MySqlClient;

namespace Codevit.Modelo.Logica
{
    public class CatalogosSat_Log
    {

        Conexion_Log objConexion = new Conexion_Log();

        #region "Selecciona"

        #region "Catalogo Completo"

        public List<CatAduanas_Cls> CatalogoAduanas()
        {

            List<CatAduanas_Cls> ListaAduanas = new List<CatAduanas_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_aduana, ";
                    strSql += "aduana ";
                    strSql += "FROM ";
                    strSql += "cat_aduanas";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();
                    while (rdrObj.Read())
                    {

                        CatAduanas_Cls objAduana = new CatAduanas_Cls();

                        objAduana.id_aduana = Convert.ToInt32(rdrObj[0].ToString());
                        objAduana.aduana = rdrObj[1].ToString();

                        ListaAduanas.Add(objAduana);

                    }

                    rdrObj.Close();

                }

            }

            return ListaAduanas;

        }

        public List<CatFormaPago_Cls> CatalogoFormaPago()
        {

            List<CatFormaPago_Cls> ListaFormaPago = new List<CatFormaPago_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_forma_pago, ";
                    strSql += "forma_pago ";
                    strSql += "FROM ";
                    strSql += "cat_forma_pago";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatFormaPago_Cls objFormaPago = new CatFormaPago_Cls();

                        objFormaPago.id_forma_pago = Convert.ToInt32(rdrObj[0].ToString());
                        objFormaPago.forma_pago = rdrObj[1].ToString();

                        ListaFormaPago.Add(objFormaPago);

                    }

                    rdrObj.Close();

                }

            }


            return ListaFormaPago;
        }

        public List<CatMetodoPago_Cls> catalogoMetodoPago()
        {

            List<CatMetodoPago_Cls> ListaMetodoPago = new List<CatMetodoPago_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_metodo_pago, ";
                    strSql += "metodo_pago, ";
                    strSql += "descripcion ";
                    strSql += "FROM ";
                    strSql += "cat_metodo_pago";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatMetodoPago_Cls objMetodoPago = new CatMetodoPago_Cls();

                        objMetodoPago.id_metodo_pago = Convert.ToInt32(rdrObj[0].ToString());
                        objMetodoPago.metodo_pago = rdrObj[1].ToString();
                        objMetodoPago.descripcion = rdrObj[2].ToString();

                        ListaMetodoPago.Add(objMetodoPago);

                    }

                    rdrObj.Close();

                }

            }

            return ListaMetodoPago;
        }

        public List<CatMoneda_Cls> CatalogoMoneda()
        {

            List<CatMoneda_Cls> ListaCatalogoMoneda = new List<CatMoneda_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_moneda, ";
                    strSql += "moneda, ";
                    strSql += "descripcion ";
                    strSql += "FROM ";
                    strSql += "cat_moneda";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatMoneda_Cls objMoneda = new CatMoneda_Cls();

                        objMoneda.id_moneda = Convert.ToInt32(rdrObj[0].ToString());
                        objMoneda.moneda = rdrObj[1].ToString();
                        objMoneda.descripcion = rdrObj[2].ToString();

                        ListaCatalogoMoneda.Add(objMoneda);

                    }

                    rdrObj.Close();

                }

            }

            return ListaCatalogoMoneda;

        }

        public List<CatProdServ_Cls> CatalogoProductoServicio()
        {

            List<CatProdServ_Cls> ListaCatalogoProductoServicio = new List<CatProdServ_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_prod_serv, ";
                    strSql += "clave, ";
                    strSql += "descripcion ";
                    strSql += "FROM ";
                    strSql += "cat_prod_serv";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatProdServ_Cls objProductoServicio = new CatProdServ_Cls();

                        objProductoServicio.id_prod_serv = Convert.ToInt32(rdrObj[0].ToString());
                        objProductoServicio.clave = rdrObj[1].ToString();
                        objProductoServicio.descripcion = rdrObj[2].ToString();

                        ListaCatalogoProductoServicio.Add(objProductoServicio);

                    }

                    rdrObj.Close();

                }

            }

            return ListaCatalogoProductoServicio;

        }

        public List<CatRegimenFiscal_Cls> CatalogoRegimenFiscal()
        {

            List<CatRegimenFiscal_Cls> ListaCatalogoRegimenFiscal = new List<CatRegimenFiscal_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_regimen_fiscal, ";
                    strSql += "descripcion, ";
                    strSql += "fisica, ";
                    strSql += "moral ";
                    strSql += "FROM ";
                    strSql += "cat_regimen_fiscal";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatRegimenFiscal_Cls objRegimenFiscal = new CatRegimenFiscal_Cls();

                        objRegimenFiscal.id_regimen_fiscal = Convert.ToInt32(rdrObj[0].ToString());
                        objRegimenFiscal.descripcion = rdrObj[1].ToString();
                        objRegimenFiscal.fisica = Convert.ToInt32(rdrObj[2].ToString());
                        objRegimenFiscal.moral = Convert.ToInt32(rdrObj[3].ToString());

                        ListaCatalogoRegimenFiscal.Add(objRegimenFiscal);

                    }

                    rdrObj.Close();

                }

            }

            return ListaCatalogoRegimenFiscal;

        }

        public List<CatTipoRelacion_Cls> CatalogoTipoRelacion()
        {

            List<CatTipoRelacion_Cls> ListaTipoRelacion = new List<CatTipoRelacion_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_tipo_relacion, ";
                    strSql += "descripcion ";
                    strSql += "FROM ";
                    strSql += "cat_tipo_relacion";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatTipoRelacion_Cls objTipoRelacion = new CatTipoRelacion_Cls();

                        objTipoRelacion.id_tipo_relacion = Convert.ToInt32(rdrObj[0].ToString());
                        objTipoRelacion.descripcion = rdrObj[1].ToString();

                        ListaTipoRelacion.Add(objTipoRelacion);

                    }

                    rdrObj.Close();

                }

            }

            return ListaTipoRelacion;

        }

        public List<CatUsoCfdi_Cls> CatalogoUsoCfdi()
        {

            List<CatUsoCfdi_Cls> ListaUsoCfdi = new List<CatUsoCfdi_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_uso_cfdi, ";
                    strSql += "uso_cfdi, ";
                    strSql += "descripcion ";
                    strSql += "FROM ";
                    strSql += "cat_uso_cfdi";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatUsoCfdi_Cls objUsoCfdi = new CatUsoCfdi_Cls();

                        objUsoCfdi.id_uso_cfdi = Convert.ToInt32(rdrObj[0].ToString());
                        objUsoCfdi.descripcion = rdrObj[1].ToString();

                        ListaUsoCfdi.Add(objUsoCfdi);

                    }

                    rdrObj.Close();

                }

            }

            return ListaUsoCfdi;

        }

        #endregion

        #region "Dato"

        public List<CatAduanas_Cls> CatalogoAduanas(int Id)
        {

            List<CatAduanas_Cls> ListaAduanas = new List<CatAduanas_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_aduana, ";
                    strSql += "aduana ";
                    strSql += "FROM ";
                    strSql += "cat_aduanas ";
                    strSql += "WHERE ";
                    strSql += "id_aduana = " + Id + "";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();
                    while (rdrObj.Read())
                    {

                        CatAduanas_Cls objAduana = new CatAduanas_Cls();

                        objAduana.id_aduana = Convert.ToInt32(rdrObj[0].ToString());
                        objAduana.aduana = rdrObj[1].ToString();

                        ListaAduanas.Add(objAduana);

                    }

                    rdrObj.Close();

                }

            }

            return ListaAduanas;

        }

        public List<CatFormaPago_Cls> CatalogoFormaPago(int Id)
        {

            List<CatFormaPago_Cls> ListaFormaPago = new List<CatFormaPago_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_forma_pago, ";
                    strSql += "forma_pago ";
                    strSql += "FROM ";
                    strSql += "cat_forma_pago ";
                    strSql += "WHERE ";
                    strSql += "id_forma_pago = " + Id + "";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatFormaPago_Cls objFormaPago = new CatFormaPago_Cls();

                        objFormaPago.id_forma_pago = Convert.ToInt32(rdrObj[0].ToString());
                        objFormaPago.forma_pago = rdrObj[1].ToString();

                        ListaFormaPago.Add(objFormaPago);

                    }

                    rdrObj.Close();

                }

            }


            return ListaFormaPago;
        }

        public List<CatMetodoPago_Cls> catalogoMetodoPago(int Id)
        {

            List<CatMetodoPago_Cls> ListaMetodoPago = new List<CatMetodoPago_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_metodo_pago, ";
                    strSql += "metodo_pago, ";
                    strSql += "descripcion ";
                    strSql += "FROM ";
                    strSql += "cat_metodo_pago ";
                    strSql += "WHERE ";
                    strSql += "id_metodo_pago = "+ Id +"";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatMetodoPago_Cls objMetodoPago = new CatMetodoPago_Cls();

                        objMetodoPago.id_metodo_pago = Convert.ToInt32(rdrObj[0].ToString());
                        objMetodoPago.metodo_pago = rdrObj[1].ToString();
                        objMetodoPago.descripcion = rdrObj[2].ToString();

                        ListaMetodoPago.Add(objMetodoPago);

                    }

                    rdrObj.Close();

                }

            }

            return ListaMetodoPago;
        }

        public List<CatMoneda_Cls> CatalogoMoneda(int Id)
        {

            List<CatMoneda_Cls> ListaCatalogoMoneda = new List<CatMoneda_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_moneda, ";
                    strSql += "moneda, ";
                    strSql += "descripcion ";
                    strSql += "FROM ";
                    strSql += "cat_moneda ";
                    strSql += "WHERE ";
                    strSql += "id_moneda = " + Id + "";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatMoneda_Cls objMoneda = new CatMoneda_Cls();

                        objMoneda.id_moneda = Convert.ToInt32(rdrObj[0].ToString());
                        objMoneda.moneda = rdrObj[1].ToString();
                        objMoneda.descripcion = rdrObj[2].ToString();

                        ListaCatalogoMoneda.Add(objMoneda);

                    }

                    rdrObj.Close();

                }

            }

            return ListaCatalogoMoneda;

        }

        public List<CatProdServ_Cls> CatalogoProductoServicio(int Id)
        {

            List<CatProdServ_Cls> ListaCatalogoProductoServicio = new List<CatProdServ_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_prod_serv, ";
                    strSql += "clave, ";
                    strSql += "descripcion ";
                    strSql += "FROM ";
                    strSql += "cat_prod_serv ";
                    strSql += "WHERE ";
                    strSql += "id_prod_serv = " + Id + "";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatProdServ_Cls objProductoServicio = new CatProdServ_Cls();

                        objProductoServicio.id_prod_serv = Convert.ToInt32(rdrObj[0].ToString());
                        objProductoServicio.clave = rdrObj[1].ToString();
                        objProductoServicio.descripcion = rdrObj[2].ToString();

                        ListaCatalogoProductoServicio.Add(objProductoServicio);

                    }

                    rdrObj.Close();

                }

            }

            return ListaCatalogoProductoServicio;

        }

        public List<CatRegimenFiscal_Cls> CatalogoRegimenFiscal(int Id)
        {

            List<CatRegimenFiscal_Cls> ListaCatalogoRegimenFiscal = new List<CatRegimenFiscal_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_regimen_fiscal, ";
                    strSql += "descripcion, ";
                    strSql += "fisica, ";
                    strSql += "moral ";
                    strSql += "FROM ";
                    strSql += "cat_regimen_fiscal ";
                    strSql += "WHERE ";
                    strSql += "id_regimen_fiscal = "+ Id +"";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatRegimenFiscal_Cls objRegimenFiscal = new CatRegimenFiscal_Cls();

                        objRegimenFiscal.id_regimen_fiscal = Convert.ToInt32(rdrObj[0].ToString());
                        objRegimenFiscal.descripcion = rdrObj[1].ToString();
                        objRegimenFiscal.fisica = Convert.ToInt32(rdrObj[2].ToString());
                        objRegimenFiscal.moral = Convert.ToInt32(rdrObj[3].ToString());

                        ListaCatalogoRegimenFiscal.Add(objRegimenFiscal);

                    }

                    rdrObj.Close();

                }

            }

            return ListaCatalogoRegimenFiscal;

        }

        public List<CatTipoRelacion_Cls> CatalogoTipoRelacion(int Id)
        {

            List<CatTipoRelacion_Cls> ListaTipoRelacion = new List<CatTipoRelacion_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_tipo_relacion, ";
                    strSql += "descripcion ";
                    strSql += "FROM ";
                    strSql += "cat_tipo_relacion ";
                    strSql += "WHERE ";
                    strSql += "id_tipo_relacion = " + Id + "";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatTipoRelacion_Cls objTipoRelacion = new CatTipoRelacion_Cls();

                        objTipoRelacion.id_tipo_relacion = Convert.ToInt32(rdrObj[0].ToString());
                        objTipoRelacion.descripcion = rdrObj[1].ToString();

                        ListaTipoRelacion.Add(objTipoRelacion);

                    }

                    rdrObj.Close();

                }

            }

            return ListaTipoRelacion;

        }

        public List<CatUsoCfdi_Cls> CatalogoUsoCfdi(int Id)
        {

            List<CatUsoCfdi_Cls> ListaUsoCfdi = new List<CatUsoCfdi_Cls>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    MySqlCommand cmdObj = new MySqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_uso_cfdi, ";
                    strSql += "uso_cfdi, ";
                    strSql += "descripcion ";
                    strSql += "FROM ";
                    strSql += "cat_uso_cfdi ";
                    strSql += "WHERE ";
                    strSql += "id_uso_cfdi = "+ Id +"";

                    cmdObj.CommandText = strSql;
                    MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        CatUsoCfdi_Cls objUsoCfdi = new CatUsoCfdi_Cls();

                        objUsoCfdi.id_uso_cfdi = Convert.ToInt32(rdrObj[0].ToString());
                        objUsoCfdi.descripcion = rdrObj[1].ToString();

                        ListaUsoCfdi.Add(objUsoCfdi);

                    }

                    rdrObj.Close();

                }

            }

            return ListaUsoCfdi;

        }

        #endregion

        #endregion

        #region "Actualiza"

        #endregion

        #region "Nuevo"

        #endregion

    }

}
