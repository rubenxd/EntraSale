using EntraSale.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntraSale
{
    public partial class frm_entra_sale : Form
    {
        cls_movimiento movi = new cls_movimiento();
        DataTable dt;
        int v_contador;
        int v_filas;
        public frm_entra_sale()
        {
            InitializeComponent();
        }
        private void Btn_add_Click(object sender, EventArgs e)
        {
            frm_marcar fr_m = new frm_marcar();
            fr_m.ShowDialog();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_buscar();
        }

        private void mtd_buscar()
        {
            movi.Buscar = txt_buscar.Text;
            movi.FecIni = dateTimePicker1.Text;
            movi.FecFin = dateTimePicker2.Text;
            dt = movi.mtd_consultar_movimientos();
            dtg_persona.Rows.Clear();

            if (dt.Rows.Count > 0)
            {
                v_contador = 0;
                v_filas = dt.Rows.Count;
                dtg_persona.Rows.Add(v_filas);
                foreach (DataRow rows in dt.Rows)
                {
                    dtg_persona.Rows[v_contador].Cells["cl_fecha"].Value = rows["FechaRegistro"];
                    dtg_persona.Rows[v_contador].Cells["cl_accion"].Value = rows["Accion"];
                    dtg_persona.Rows[v_contador].Cells["cl_DNI"].Value = rows["DNIPersona"];
                    dtg_persona.Rows[v_contador].Cells["cl_nombre"].Value = rows["Persona"];
                    dtg_persona.Rows[v_contador].Cells["cl_detalle"].Value = rows["Detalle"];

                    v_contador++;
                }
            }
        }  
        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_buscar();
        }
    }
}
