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
    public partial class frm_registro_persona : Form
    {
        int v_validado = 0;
        cls_persona persona = new cls_persona();
        bool v_ok;
        DataTable dt;
        public bool Registro { get; set; }
        public string dniValidador { get; set; }
        public frm_registro_persona()
        {
            InitializeComponent();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            mtd_validar();
            if (v_validado == 0)
            {
                persona.Buscar = txt_dni.Text;
                persona.DNI = txt_dni.Text;
                persona.Nombre = txt_nombre.Text;
                persona.Apellido = txt_apellido.Text;
                persona.Direccion = txt_direccion.Text;
                persona.Celular = txt_celular.Text;
                persona.Email = txt_email.Text;
                this.Enabled = false;
                Cursor = Cursors.WaitCursor;
                //verificar existencia DNI
                dt = persona.mtd_consultar_DNI();
                DataRow rows = dt.Rows[0];
                if (Registro == true)
                {                 
                    if (Convert.ToInt32(rows["CN"]) > 0)
                    {
                        MessageBox.Show("Persona Ya existe", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        v_ok = false;
                    }
                    else
                    {
                        v_ok = persona.mtd_registrar();
                    }
                }
                else
                {
                    if (dniValidador != txt_dni.Text)
                    {
                        if (Convert.ToInt32(rows["CN"]) > 0)
                        {
                            MessageBox.Show("Persona Ya existe", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            v_ok = false;
                        }
                    }                   
                    else
                    {
                        v_ok = persona.mtd_Editar();
                    }
                    
                }
                
                this.Enabled = true;
                Cursor = Cursors.Default;
                if (v_ok == true)
                {
                    if (Registro == true)
                    {
                        MessageBox.Show("Persona registrada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtd_limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Persona Editada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtd_limpiar();
                        this.Close();
                    }    
                }
            }
        }

        private void mtd_validar()
        {
            v_validado = 0;
            errorProvider1.Clear();
            if (txt_dni.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_dni,"Ingrese DNI");
                v_validado++;
            }
            if (txt_nombre.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_nombre, "Ingrese Nombre");
                v_validado++;
            }
        }

        private void mtd_limpiar()
        {
            txt_dni.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_direccion.Text = "";
            txt_celular.Text = "";
            txt_email.Text = "";
        }
    }
}
