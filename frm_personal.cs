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
    public partial class frm_personal : Form
    {
        DataTable v_dt;
        int v_contador;
        int v_filas;
        bool v_registro;
        cls_persona persona = new cls_persona();
        frm_registro_persona frm_per = new frm_registro_persona();
        public frm_personal()
        {
            InitializeComponent();
        }
        private void Btn_add_Click(object sender, EventArgs e)
        {
            frm_registro_persona fmrp = new frm_registro_persona();
            fmrp.Registro = true;
            fmrp.ShowDialog();
        }
        private void mtd_Cargar_persona()
        {
          
            persona.Buscar = txt_buscar.Text;
            
           
            v_dt = persona.mtd_consultar();
            dtg_persona.Rows.Clear();
            if (v_dt.Rows.Count > 0)
            {
                v_contador = 0;
                v_filas = v_dt.Rows.Count;
                dtg_persona.Rows.Add(v_filas);
                foreach (DataRow rows in v_dt.Rows)
                {
                    dtg_persona.Rows[v_contador].Cells["cl_dni"].Value = rows["DNI"];
                    dtg_persona.Rows[v_contador].Cells["cl_Nombre"].Value = rows["Nombre"];
                    dtg_persona.Rows[v_contador].Cells["cl_apellido"].Value = rows["Apellido"];
                    dtg_persona.Rows[v_contador].Cells["cl_direccion"].Value = rows["Direccion"];              
                    dtg_persona.Rows[v_contador].Cells["cl_celular"].Value = rows["Celular"];
                    dtg_persona.Rows[v_contador].Cells["cl_email"].Value = rows["Email"];                 
                    v_contador++;
                }
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_Cargar_persona();
        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_Cargar_persona();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dtg_persona.Rows.Count > 0)
            {
                if (dtg_persona.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dtg_persona.SelectedRows)
                    {
                        frm_per.dniValidador = row.Cells["cl_dni"].Value.ToString();
                        frm_per.txt_dni.Text = row.Cells["cl_dni"].Value.ToString();
                        frm_per.txt_nombre.Text = row.Cells["cl_Nombre"].Value.ToString();
                        frm_per.txt_apellido.Text = row.Cells["cl_apellido"].Value.ToString();
                        frm_per.txt_direccion.Text = row.Cells["cl_direccion"].Value.ToString();
                        frm_per.txt_celular.Text = row.Cells["cl_celular"].Value.ToString();
                        frm_per.txt_email.Text = row.Cells["cl_email"].Value.ToString();                    
                    }
                    frm_per.Registro = false;
                    frm_per.ShowDialog();
                }
            }
        }
    }
}
