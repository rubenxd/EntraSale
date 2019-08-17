namespace EntraSale
{
    partial class frm_marcar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_marcar));
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_persona = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Detalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_entrada = new System.Windows.Forms.Button();
            this.btn_salida = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Location = new System.Drawing.Point(63, 12);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(212, 20);
            this.txt_buscar.TabIndex = 19;
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_buscar_KeyUp);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(294, 9);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(25, 25);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // txt_estado
            // 
            this.txt_estado.Enabled = false;
            this.txt_estado.Location = new System.Drawing.Point(63, 69);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(256, 20);
            this.txt_estado.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Estado";
            // 
            // txt_persona
            // 
            this.txt_persona.Enabled = false;
            this.txt_persona.Location = new System.Drawing.Point(63, 42);
            this.txt_persona.Name = "txt_persona";
            this.txt_persona.Size = new System.Drawing.Size(256, 20);
            this.txt_persona.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Persona";
            // 
            // txt_Detalle
            // 
            this.txt_Detalle.Location = new System.Drawing.Point(63, 95);
            this.txt_Detalle.Multiline = true;
            this.txt_Detalle.Name = "txt_Detalle";
            this.txt_Detalle.Size = new System.Drawing.Size(256, 52);
            this.txt_Detalle.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Detalle";
            // 
            // btn_entrada
            // 
            this.btn_entrada.BackColor = System.Drawing.SystemColors.Window;
            this.btn_entrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrada.Enabled = false;
            this.btn_entrada.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_entrada.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrada.Image = ((System.Drawing.Image)(resources.GetObject("btn_entrada.Image")));
            this.btn_entrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_entrada.Location = new System.Drawing.Point(79, 154);
            this.btn_entrada.Margin = new System.Windows.Forms.Padding(4);
            this.btn_entrada.Name = "btn_entrada";
            this.btn_entrada.Size = new System.Drawing.Size(85, 40);
            this.btn_entrada.TabIndex = 26;
            this.btn_entrada.Text = " Trabajar";
            this.btn_entrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_entrada.UseVisualStyleBackColor = false;
            this.btn_entrada.Click += new System.EventHandler(this.Btn_entrada_Click);
            // 
            // btn_salida
            // 
            this.btn_salida.BackColor = System.Drawing.SystemColors.Window;
            this.btn_salida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salida.Enabled = false;
            this.btn_salida.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_salida.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_salida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salida.Image = ((System.Drawing.Image)(resources.GetObject("btn_salida.Image")));
            this.btn_salida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salida.Location = new System.Drawing.Point(172, 154);
            this.btn_salida.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salida.Name = "btn_salida";
            this.btn_salida.Size = new System.Drawing.Size(81, 40);
            this.btn_salida.TabIndex = 27;
            this.btn_salida.Text = "  Salida";
            this.btn_salida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salida.UseVisualStyleBackColor = false;
            this.btn_salida.Click += new System.EventHandler(this.Btn_salida_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_marcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(331, 206);
            this.Controls.Add(this.btn_salida);
            this.Controls.Add(this.btn_entrada);
            this.Controls.Add(this.txt_Detalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_persona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_marcar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcar";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_persona;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Detalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_entrada;
        private System.Windows.Forms.Button btn_salida;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}