using EntraSale.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntraSale.MODEL
{
    public class cls_movimiento
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        SqlParameter[] Parametros;
        bool v_ok;

        public string DNI { get; set; }
        public string fecha { get; set; }
        public string Accion { get; set; }
        public string Detalle { get; set; }
        public string Buscar { get; set; }
        public string FecIni { get; set; }
        public string FecFin { get; set; }

        public DataTable mtd_consultar()
        {
            v_query = " EXECUTE SP_BUSCAR_PERSONAS '"+Buscar+"' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public DataTable mtd_consultar_movimientos()
        {
            v_query = " SELECT *,(SELECT Nombre +' '+Apellido FROM Persona WHERE DNI = m.DNIPersona) Persona FROM MOVIMIENTO m " +
                      " WHERE CONVERT(date, m.FechaRegistro) BETWEEN '" + FecIni + "' AND '"+ FecFin + "' AND (m.DNIPersona LIKE '"+ Buscar + "%') " +
                      " ORDER BY m.DNIPersona,m.FechaRegistro DESC ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[4];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@DNIPersona";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = DNI;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@FechaRegistro";
            Parametros[1].SqlDbType = SqlDbType.DateTime;
            Parametros[1].SqlValue = DateTime.Now;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Accion";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = Accion;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Detalle";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].SqlValue = Detalle;        
        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO Movimiento (DNIPersona,FechaRegistro,Accion,Detalle) " +
                      " VALUES (@DNIPersona,@FechaRegistro,@Accion,@Detalle) ";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
    }
}
