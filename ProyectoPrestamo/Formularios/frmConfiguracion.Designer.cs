namespace ProyectoPrestamo.Formularios
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.label1 = new System.Windows.Forms.Label();
            this.btnmisdatos = new FontAwesome.Sharp.IconButton();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btntipomoneda = new FontAwesome.Sharp.IconButton();
            this.btnvolver = new FontAwesome.Sharp.IconButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbltitulo = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 517);
            this.label1.TabIndex = 91;
            // 
            // btnmisdatos
            // 
            this.btnmisdatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnmisdatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmisdatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmisdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmisdatos.ForeColor = System.Drawing.Color.White;
            this.btnmisdatos.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnmisdatos.IconColor = System.Drawing.Color.White;
            this.btnmisdatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmisdatos.IconSize = 30;
            this.btnmisdatos.Location = new System.Drawing.Point(24, 79);
            this.btnmisdatos.Name = "btnmisdatos";
            this.btnmisdatos.Size = new System.Drawing.Size(103, 48);
            this.btnmisdatos.TabIndex = 95;
            this.btnmisdatos.Text = "Mis Datos";
            this.btnmisdatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmisdatos.UseVisualStyleBackColor = false;
            this.btnmisdatos.Click += new System.EventHandler(this.btnmisdatos_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contenedor.Location = new System.Drawing.Point(24, 163);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(600, 387);
            this.contenedor.TabIndex = 97;
            // 
            // btntipomoneda
            // 
            this.btntipomoneda.BackColor = System.Drawing.Color.White;
            this.btntipomoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntipomoneda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntipomoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntipomoneda.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btntipomoneda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btntipomoneda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btntipomoneda.IconSize = 30;
            this.btntipomoneda.Location = new System.Drawing.Point(126, 79);
            this.btntipomoneda.Name = "btntipomoneda";
            this.btntipomoneda.Size = new System.Drawing.Size(103, 48);
            this.btntipomoneda.TabIndex = 95;
            this.btntipomoneda.Text = "Tipo Moneda";
            this.btntipomoneda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntipomoneda.UseVisualStyleBackColor = false;
            this.btntipomoneda.Click += new System.EventHandler(this.btntipomoneda_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.btnvolver.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnvolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnvolver.IconSize = 30;
            this.btnvolver.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnvolver.Location = new System.Drawing.Point(521, 79);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(103, 40);
            this.btnvolver.TabIndex = 98;
            this.btnvolver.Text = "Volver";
            this.btnvolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 30;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.lbltitulo);
            this.bunifuPanel2.Location = new System.Drawing.Point(24, 125);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(600, 41);
            this.bunifuPanel2.TabIndex = 135;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AllowParentOverrides = false;
            this.lbltitulo.AutoEllipsis = false;
            this.lbltitulo.AutoSize = false;
            this.lbltitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbltitulo.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(-88, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbltitulo.Size = new System.Drawing.Size(432, 39);
            this.lbltitulo.TabIndex = 65;
            this.lbltitulo.Text = "Mi Datos";
            this.lbltitulo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltitulo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Location = new System.Drawing.Point(1, -2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(638, 61);
            this.bunifuPanel1.TabIndex = 136;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(-92, 14);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(432, 39);
            this.bunifuLabel1.TabIndex = 65;
            this.bunifuLabel1.Text = "Configuraciones";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 617);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.btntipomoneda);
            this.Controls.Add(this.btnmisdatos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnmisdatos;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconButton btntipomoneda;
        private FontAwesome.Sharp.IconButton btnvolver;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel lbltitulo;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}