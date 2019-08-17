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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_personal));
            this.pnl_opciones = new System.Windows.Forms.Panel();
            this.dtg_persona = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.pnl_opciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_opciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_opciones.Controls.Add(this.button1);
            this.pnl_opciones.Controls.Add(this.txt_dni);
            this.pnl_opciones.Controls.Add(this.btn_guardar);
            this.pnl_opciones.Controls.Add(this.btn_add);
            this.pnl_opciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_opciones.Location = new System.Drawing.Point(0, 0);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(800, 45);
            this.pnl_opciones.TabIndex = 0;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_persona.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_persona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_persona.Location = new System.Drawing.Point(0, 45);
            this.dtg_persona.Name = "dtg_persona";
            this.dtg_persona.ReadOnly = true;
            this.dtg_persona.Size = new System.Drawing.Size(800, 405);
            this.dtg_persona.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.Window;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
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
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(760, 7);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(25, 25);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // txt_dni
            // 
            this.txt_dni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dni.Location = new System.Drawing.Point(542, 10);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(208, 20);
            this.txt_dni.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(44, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 16;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_email;
    }
}