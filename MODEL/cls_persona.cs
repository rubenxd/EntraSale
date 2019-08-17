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
    public class cls_persona
    {
        //instancias
        cls_conexion cls_cn = new cls_conexion();
        cls_datos cls_datos = new cls_datos();

        //Variables
        DataTable v_dt;
        string v_query = "";
        SqlParameter[] Parametros;
        bool v_ok;
        public string Buscar { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
   
        private void mtd_asignaParametros()
        {
            Parametros = new SqlParameter[6];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@DNI";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = DNI;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Nombre";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = Nombre;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Apellido";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = Apellido;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Direccion";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].SqlValue = Direccion;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Celular";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = Celular;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Email";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = Email;
        }
        public Boolean mtd_registrar()
        {
            v_query = " INSERT INTO Persona (DNI,Nombre,Apellido,Direccion,Celular,Email) " +
                      " VALUES (@DNI,@Nombre,@Apellido,@Direccion,@Celular,@Email) ";

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_registrar(Parametros, v_query);
            return v_ok;
        }
        public DataTable mtd_consultar()
        {
            v_query = " SELECT * FROM Persona WHERE DNI LIKE '"+Buscar+ "%' OR CONCAT(Nombre,' ',Apellido) LIKE '" + Buscar + "%' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
        public Boolean mtd_Editar()
        {
            v_query = " UPDATE Persona SET DNI = @DNI,Nombre = @Nombre,Apellido = @Apellido,Direccion = @Direccion,  " +
                      " Celular = @Celular,Email = @Email " +
                      " WHERE DNI = " + Buscar;

            mtd_asignaParametros();
            v_ok = cls_datos.mtd_editar(Parametros, v_query);
            return v_ok;
        }
        public DataTable mtd_consultar_DNI()
        {
            v_query = " SELECT COUNT(*) CN FROM Persona WHERE DNI = '"+DNI+"' ";
            v_dt = cls_datos.mtd_consultar(v_query);
            return v_dt;
        }
    }
}
