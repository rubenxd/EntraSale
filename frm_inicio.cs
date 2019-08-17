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
    public partial class frm_inicio : Form
    {
        Form formul = new Form();
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void Btn_personal_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_personal f_p = new frm_personal();
            ColoresBotones("btn_personal");
            AbrirFormularioEnPanel(f_p);
            btn_personal.BackColor = Color.LightGray;
        }

        public void AbrirFormularioEnPanel(object FormularioHijo)
        {
            if (this.pnl_contenido.Controls.Count > 0)
                this.pnl_contenido.Controls.RemoveAt(0);
            //Form formul;  
            formul = FormularioHijo as Form;
            formul.TopLevel = false;
            formul.Dock = DockStyle.Fill;
            this.pnl_contenido.Controls.Add(formul);
            this.pnl_contenido.Tag = formul;
            formul.Show();
        }

        private void ColoresBotones(string Boton)
        {
            if (Boton != "btn_personal")
            {
                btn_personal.BackColor = Color.White;
            }
            if (Boton != "btn_entraSale")
            {
                btn_entraSale.BackColor = Color.White;
            }
        }

        private void Btn_entraSale_Click(object sender, EventArgs e)
        {
            formul.Dispose();
            frm_entra_sale EnSl = new frm_entra_sale();
            ColoresBotones("btn_entraSale");
            AbrirFormularioEnPanel(EnSl);
            btn_entraSale.BackColor = Color.LightGray;
        }
    }
}
