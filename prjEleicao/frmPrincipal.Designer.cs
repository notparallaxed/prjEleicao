namespace prjEleicao
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnAtualUser = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.mnuEleitor = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.mnuUrnas = new System.Windows.Forms.Button();
            this.mnuCargo = new System.Windows.Forms.Button();
            this.mnuPartidos = new System.Windows.Forms.Button();
            this.mnuCandidatos = new System.Windows.Forms.Button();
            this.mnuEleicao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTopBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFechar.Location = new System.Drawing.Point(1180, 0);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(127)))), ((int)(((byte)(23)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(64)))));
            this.btnMaximizar.Location = new System.Drawing.Point(1150, 0);
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnMinimizar.Location = new System.Drawing.Point(1120, 0);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Size = new System.Drawing.Size(1210, 30);
            // 
            // btnAtualUser
            // 
            this.btnAtualUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtualUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnAtualUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualUser.FlatAppearance.BorderSize = 0;
            this.btnAtualUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAtualUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAtualUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualUser.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.btnAtualUser.ForeColor = System.Drawing.Color.White;
            this.btnAtualUser.Location = new System.Drawing.Point(41, 639);
            this.btnAtualUser.Name = "btnAtualUser";
            this.btnAtualUser.Size = new System.Drawing.Size(159, 40);
            this.btnAtualUser.TabIndex = 13;
            this.btnAtualUser.UseVisualStyleBackColor = false;
            this.btnAtualUser.Click += new System.EventHandler(this.btnAtualUser_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pnlMenu.Controls.Add(this.mnuEleitor);
            this.pnlMenu.Controls.Add(this.pnlTop);
            this.pnlMenu.Controls.Add(this.btnAtualUser);
            this.pnlMenu.Controls.Add(this.btnLogOff);
            this.pnlMenu.Controls.Add(this.mnuUrnas);
            this.pnlMenu.Controls.Add(this.mnuCargo);
            this.pnlMenu.Controls.Add(this.mnuPartidos);
            this.pnlMenu.Controls.Add(this.mnuCandidatos);
            this.pnlMenu.Controls.Add(this.mnuEleicao);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 26);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 680);
            this.pnlMenu.TabIndex = 11;
            // 
            // mnuEleitor
            // 
            this.mnuEleitor.BackColor = System.Drawing.Color.Gainsboro;
            this.mnuEleitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuEleitor.Enabled = false;
            this.mnuEleitor.FlatAppearance.BorderSize = 0;
            this.mnuEleitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.mnuEleitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.mnuEleitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuEleitor.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.mnuEleitor.ForeColor = System.Drawing.Color.White;
            this.mnuEleitor.Location = new System.Drawing.Point(0, 325);
            this.mnuEleitor.Name = "mnuEleitor";
            this.mnuEleitor.Size = new System.Drawing.Size(190, 40);
            this.mnuEleitor.TabIndex = 16;
            this.mnuEleitor.Tag = "";
            this.mnuEleitor.Text = "ELEITOR";
            this.mnuEleitor.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Location = new System.Drawing.Point(199, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1011, 52);
            this.pnlTop.TabIndex = 15;
            // 
            // btnLogOff
            // 
            this.btnLogOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnLogOff.BackgroundImage = global::prjEleicao.Properties.Resources.back;
            this.btnLogOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogOff.FlatAppearance.BorderSize = 0;
            this.btnLogOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnLogOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOff.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.btnLogOff.ForeColor = System.Drawing.Color.White;
            this.btnLogOff.Location = new System.Drawing.Point(0, 639);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(40, 40);
            this.btnLogOff.TabIndex = 12;
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // mnuUrnas
            // 
            this.mnuUrnas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.mnuUrnas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuUrnas.Enabled = false;
            this.mnuUrnas.FlatAppearance.BorderSize = 0;
            this.mnuUrnas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.mnuUrnas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.mnuUrnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuUrnas.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.mnuUrnas.ForeColor = System.Drawing.Color.White;
            this.mnuUrnas.Location = new System.Drawing.Point(0, 283);
            this.mnuUrnas.Name = "mnuUrnas";
            this.mnuUrnas.Size = new System.Drawing.Size(190, 40);
            this.mnuUrnas.TabIndex = 11;
            this.mnuUrnas.Tag = "btnMenu";
            this.mnuUrnas.Text = "URNAS";
            this.mnuUrnas.UseVisualStyleBackColor = false;
            this.mnuUrnas.Click += new System.EventHandler(this.btnUrnas_Click);
            // 
            // mnuCargo
            // 
            this.mnuCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.mnuCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuCargo.Enabled = false;
            this.mnuCargo.FlatAppearance.BorderSize = 0;
            this.mnuCargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.mnuCargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.mnuCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuCargo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.mnuCargo.ForeColor = System.Drawing.Color.White;
            this.mnuCargo.Location = new System.Drawing.Point(0, 241);
            this.mnuCargo.Name = "mnuCargo";
            this.mnuCargo.Size = new System.Drawing.Size(190, 40);
            this.mnuCargo.TabIndex = 10;
            this.mnuCargo.Tag = "btnMenu";
            this.mnuCargo.Text = "CARGOS";
            this.mnuCargo.UseVisualStyleBackColor = false;
            this.mnuCargo.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // mnuPartidos
            // 
            this.mnuPartidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.mnuPartidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuPartidos.Enabled = false;
            this.mnuPartidos.FlatAppearance.BorderSize = 0;
            this.mnuPartidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.mnuPartidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.mnuPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuPartidos.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.mnuPartidos.ForeColor = System.Drawing.Color.White;
            this.mnuPartidos.Location = new System.Drawing.Point(0, 199);
            this.mnuPartidos.Name = "mnuPartidos";
            this.mnuPartidos.Size = new System.Drawing.Size(190, 40);
            this.mnuPartidos.TabIndex = 9;
            this.mnuPartidos.Tag = "btnMenu";
            this.mnuPartidos.Text = "PARTIDOS";
            this.mnuPartidos.UseVisualStyleBackColor = false;
            this.mnuPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // mnuCandidatos
            // 
            this.mnuCandidatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.mnuCandidatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuCandidatos.Enabled = false;
            this.mnuCandidatos.FlatAppearance.BorderSize = 0;
            this.mnuCandidatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.mnuCandidatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.mnuCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuCandidatos.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.mnuCandidatos.ForeColor = System.Drawing.Color.White;
            this.mnuCandidatos.Location = new System.Drawing.Point(0, 157);
            this.mnuCandidatos.Name = "mnuCandidatos";
            this.mnuCandidatos.Size = new System.Drawing.Size(190, 40);
            this.mnuCandidatos.TabIndex = 8;
            this.mnuCandidatos.Tag = "btnMenu";
            this.mnuCandidatos.Text = "CANDIDATOS";
            this.mnuCandidatos.UseVisualStyleBackColor = false;
            this.mnuCandidatos.Click += new System.EventHandler(this.btnCandidatos_Click);
            // 
            // mnuEleicao
            // 
            this.mnuEleicao.BackColor = System.Drawing.Color.Gainsboro;
            this.mnuEleicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuEleicao.Enabled = false;
            this.mnuEleicao.FlatAppearance.BorderSize = 0;
            this.mnuEleicao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.mnuEleicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.mnuEleicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuEleicao.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.mnuEleicao.ForeColor = System.Drawing.Color.White;
            this.mnuEleicao.Location = new System.Drawing.Point(0, 115);
            this.mnuEleicao.Name = "mnuEleicao";
            this.mnuEleicao.Size = new System.Drawing.Size(190, 40);
            this.mnuEleicao.TabIndex = 7;
            this.mnuEleicao.Tag = "";
            this.mnuEleicao.Text = "ELEIÇÕES";
            this.mnuEleicao.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjEleicao.Properties.Resources.logowhite;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1210, 706);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "ElectSis - ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.TextChanged += new System.EventHandler(this.frmPrincipal_TextChanged);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.pnlTopBar, 0);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnAtualUser;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel pnlMenu;
        public System.Windows.Forms.Button mnuUrnas;
        public System.Windows.Forms.Button mnuCargo;
        public System.Windows.Forms.Button mnuPartidos;
        public System.Windows.Forms.Button mnuCandidatos;
        public System.Windows.Forms.Button mnuEleicao;
        public System.Windows.Forms.Button mnuEleitor;
    }
}