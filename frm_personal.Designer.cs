namespace EntraSale
{
    partial class frm_personal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_personal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_opciones = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dtg_persona = new System.Windows.Forms.DataGridView();
            this.cl_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_persona)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_opciones
            // 
            this.pnl_opciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_opciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_opciones.Controls.Add(this.btn_editar);
            this.pnl_opciones.Controls.Add(this.txt_buscar);
            this.pnl_opciones.Controls.Add(this.btn_buscar);
            this.pnl_opciones.Controls.Add(this.btn_add);
            this.pnl_opciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_opciones.Location = new System.Drawing.Point(0, 0);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(800, 45);
            this.pnl_opciones.TabIndex = 0;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(44, 7);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(25, 25);
            this.btn_editar.TabIndex = 16;
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Location = new System.Drawing.Point(542, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(208, 20);
            this.txt_buscar.TabIndex = 15;
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_buscar_KeyUp);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(760, 7);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(25, 25);
            this.btn_buscar.TabIndex = 14;
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(11, 7);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(25, 25);
            this.btn_add.TabIndex = 13;
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // dtg_persona
            // 
            this.dtg_persona.AllowUserToAddRows = false;
            this.dtg_persona.AllowUserToDeleteRows = false;
            this.dtg_persona.AllowUserToOrderColumns = true;
            this.dtg_persona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_persona.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_persona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_persona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_dni,
            this.cl_Nombre,
            this.cl_apellido,
            this.cl_direccion,
            this.cl_celular,
            this.cl_email});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_persona.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_persona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_persona.Location = new System.Drawing.Point(0, 45);
            this.dtg_persona.Name = "dtg_persona";
            this.dtg_persona.ReadOnly = true;
            this.dtg_persona.Size = new System.Drawing.Size(800, 405);
            this.dtg_persona.TabIndex = 1;
            // 
            // cl_dni
            // 
            this.cl_dni.HeaderText = "DNI";
            this.cl_dni.Name = "cl_dni";
            this.cl_dni.ReadOnly = true;
            // 
            // cl_Nombre
            // 
            this.cl_Nombre.HeaderText = "Nombres";
            this.cl_Nombre.Name = "cl_Nombre";
            this.cl_Nombre.ReadOnly = true;
            // 
            // cl_apellido
            // 
            this.cl_apellido.HeaderText = "Apellidos";
            this.cl_apellido.Name = "cl_apellido";
            this.cl_apellido.ReadOnly = true;
            // 
            // cl_direccion
            // 
            this.cl_direccion.HeaderText = "Direccion";
            this.cl_direccion.Name = "cl_direccion";
            this.cl_direccion.ReadOnly = true;
            // 
            // cl_celular
            // 
            this.cl_celular.HeaderText = "Celular";
            this.cl_celular.Name = "cl_celular";
            this.cl_celular.ReadOnly = true;
            // 
            // cl_email
            // 
            this.cl_email.HeaderText = "Email";
            this.cl_email.Name = "cl_email";
            this.cl_email.ReadOnly = true;
            // 
            // frm_personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtg_persona);
            this.Controls.Add(this.pnl_opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_personal";
            this.Text = "frm_personal";
            this.pnl_opciones.ResumeLayout(false);
            this.pnl_opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_persona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_opciones;
        private System.Windows.Forms.DataGridView dtg_persona;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_email;
    }
}