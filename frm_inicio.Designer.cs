namespace EntraSale
{
    partial class frm_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pnl_contenido = new System.Windows.Forms.Panel();
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_entraSale = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_menu.Controls.Add(this.btn_entraSale);
            this.pnl_menu.Controls.Add(this.btn_personal);
            this.pnl_menu.Controls.Add(this.panel1);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(141, 476);
            this.pnl_menu.TabIndex = 0;
            // 
            // pnl_contenido
            // 
            this.pnl_contenido.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_contenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenido.Location = new System.Drawing.Point(141, 0);
            this.pnl_contenido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_contenido.Name = "pnl_contenido";
            this.pnl_contenido.Size = new System.Drawing.Size(717, 476);
            this.pnl_contenido.TabIndex = 1;
            // 
            // btn_personal
            // 
            this.btn_personal.BackColor = System.Drawing.SystemColors.Window;
            this.btn_personal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_personal.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_personal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personal.Image = ((System.Drawing.Image)(resources.GetObject("btn_personal.Image")));
            this.btn_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personal.Location = new System.Drawing.Point(2, 54);
            this.btn_personal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(136, 40);
            this.btn_personal.TabIndex = 2;
            this.btn_personal.Text = "  Personal";
            this.btn_personal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_personal.UseVisualStyleBackColor = false;
            this.btn_personal.Click += new System.EventHandler(this.Btn_personal_Click);
            // 
            // btn_entraSale
            // 
            this.btn_entraSale.BackColor = System.Drawing.SystemColors.Window;
            this.btn_entraSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entraSale.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_entraSale.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_entraSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entraSale.Image = ((System.Drawing.Image)(resources.GetObject("btn_entraSale.Image")));
            this.btn_entraSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_entraSale.Location = new System.Drawing.Point(2, 96);
            this.btn_entraSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_entraSale.Name = "btn_entraSale";
            this.btn_entraSale.Size = new System.Drawing.Size(136, 40);
            this.btn_entraSale.TabIndex = 3;
            this.btn_entraSale.Text = "  Entrada y Salida";
            this.btn_entraSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_entraSale.UseVisualStyleBackColor = false;
            this.btn_entraSale.Click += new System.EventHandler(this.Btn_entraSale_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 52);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 476);
            this.Controls.Add(this.pnl_contenido);
            this.Controls.Add(this.pnl_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas y salidas -- FamiAseo";
            this.pnl_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_contenido;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_entraSale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}