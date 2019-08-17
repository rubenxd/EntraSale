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
        public frm_personal()
        {
            InitializeComponent();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            frm_registro_persona fmrp = new frm_registro_persona();
            fmrp.ShowDialog();
        }
    }
}
