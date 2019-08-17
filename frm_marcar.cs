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
    public partial class frm_marcar : Form
    {
        cls_movimiento movi = new cls_movimiento();
        DataTable v_dt;
        bool ok;
        int validado = 0;
        public frm_marcar()
        {
            InitializeComponent();
        }
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            mtd_Cargar_persona();
        }

        private void mtd_Cargar_persona()
        {
            errorProvider1.Clear();
            validado = 0;
            if (txt_buscar.Text != "")
            {
                movi.Buscar = txt_buscar.Text;
                v_dt = movi.mtd_consultar();
                if (v_dt.Rows.Count > 0)
                {
                    DataRow rows = v_dt.Rows[0];
                    txt_persona.Text = rows["Nombre"].ToString() + " " + rows["Apellido"];
                    txt_estado.Text = rows["Accion"].ToString();
                    if (rows["Accion"].ToString() == "Laborando")
                    {
                        btn_salida.Enabled = true;
                        btn_entrada.Enabled = false;
                    }
                    else
                    {
                        btn_entrada.Enabled = true;
                        btn_salida.Enabled = false;
                    }
                }
                else
                {
                    errorProvider1.SetError(txt_buscar, "Persona NO existe");
                    txt_persona.Text = "";
                    txt_estado.Text = "";
                    txt_Detalle.Text = "";
                    btn_entrada.Enabled = false;
                    btn_salida.Enabled = false;
                    validado++;
                }
            }       
        }

        private void Btn_entrada_Click(object sender, EventArgs e)
        {
            movi.DNI = txt_buscar.Text;      
            movi.Accion = "Laborando";         
            movi.Detalle = txt_Detalle.Text;
            ok = movi.mtd_registrar();
            if (ok)
            {
                MessageBox.Show("Correcto","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
            }    
        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            mtd_Cargar_persona();
        }

        private void Btn_salida_Click(object sender, EventArgs e)
        {
            movi.DNI = txt_buscar.Text;
            movi.Accion = "Descanso";
            movi.Detalle = txt_Detalle.Text;
            ok = movi.mtd_registrar();
            if (ok)
            {
                MessageBox.Show("Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
