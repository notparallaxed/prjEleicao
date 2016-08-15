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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnUrnas = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnCandidatos = new System.Windows.Forms.Button();
            this.btnElicoes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
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
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.pnlTop);
            this.pnlMenu.Controls.Add(this.btnAtualUser);
            this.pnlMenu.Controls.Add(this.btnLogOff);
            this.pnlMenu.Controls.Add(this.btnUrnas);
            this.pnlMenu.Controls.Add(this.btnCargos);
            this.pnlMenu.Controls.Add(this.btnPartidos);
            this.pnlMenu.Controls.Add(this.btnCandidatos);
            this.pnlMenu.Controls.Add(this.btnElicoes);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 26);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 680);
            this.pnlMenu.TabIndex = 11;
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
            // btnUrnas
            // 
            this.btnUrnas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnUrnas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrnas.FlatAppearance.BorderSize = 0;
            this.btnUrnas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnUrnas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.btnUrnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrnas.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.btnUrnas.ForeColor = System.Drawing.Color.White;
            this.btnUrnas.Location = new System.Drawing.Point(0, 283);
            this.btnUrnas.Name = "btnUrnas";
            this.btnUrnas.Size = new System.Drawing.Size(190, 40);
            this.btnUrnas.TabIndex = 11;
            this.btnUrnas.Tag = "btnMenu";
            this.btnUrnas.Text = "URNAS";
            this.btnUrnas.UseVisualStyleBackColor = false;
            this.btnUrnas.Click += new System.EventHandler(this.btnUrnas_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnCargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCargos.FlatAppearance.BorderSize = 0;
            this.btnCargos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnCargos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargos.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.btnCargos.ForeColor = System.Drawing.Color.White;
            this.btnCargos.Location = new System.Drawing.Point(0, 241);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(190, 40);
            this.btnCargos.TabIndex = 10;
            this.btnCargos.Tag = "btnMenu";
            this.btnCargos.Text = "CARGOS";
            this.btnCargos.UseVisualStyleBackColor = false;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnPartidos
            // 
            this.btnPartidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnPartidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnPartidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.btnPartidos.ForeColor = System.Drawing.Color.White;
            this.btnPartidos.Location = new System.Drawing.Point(0, 199);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(190, 40);
            this.btnPartidos.TabIndex = 9;
            this.btnPartidos.Tag = "btnMenu";
            this.btnPartidos.Text = "PARTIDOS";
            this.btnPartidos.UseVisualStyleBackColor = false;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnCandidatos
            // 
            this.btnCandidatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnCandidatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCandidatos.FlatAppearance.BorderSize = 0;
            this.btnCandidatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnCandidatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.btnCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandidatos.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.btnCandidatos.ForeColor = System.Drawing.Color.White;
            this.btnCandidatos.Location = new System.Drawing.Point(0, 157);
            this.btnCandidatos.Name = "btnCandidatos";
            this.btnCandidatos.Size = new System.Drawing.Size(190, 40);
            this.btnCandidatos.TabIndex = 8;
            this.btnCandidatos.Tag = "btnMenu";
            this.btnCandidatos.Text = "CANDIDATOS";
            this.btnCandidatos.UseVisualStyleBackColor = false;
            this.btnCandidatos.Click += new System.EventHandler(this.btnCandidatos_Click);
            // 
            // btnElicoes
            // 
            this.btnElicoes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnElicoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnElicoes.Enabled = false;
            this.btnElicoes.FlatAppearance.BorderSize = 0;
            this.btnElicoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.btnElicoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.btnElicoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElicoes.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.btnElicoes.ForeColor = System.Drawing.Color.White;
            this.btnElicoes.Location = new System.Drawing.Point(0, 115);
            this.btnElicoes.Name = "btnElicoes";
            this.btnElicoes.Size = new System.Drawing.Size(190, 40);
            this.btnElicoes.TabIndex = 7;
            this.btnElicoes.Tag = "";
            this.btnElicoes.Text = "ELEIÇÕES";
            this.btnElicoes.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 40);
            this.button1.TabIndex = 16;
            this.button1.Tag = "";
            this.button1.Text = "ELEITOR";
            this.button1.UseVisualStyleBackColor = false;
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
        public System.Windows.Forms.Button btnUrnas;
        public System.Windows.Forms.Button btnCargos;
        public System.Windows.Forms.Button btnPartidos;
        public System.Windows.Forms.Button btnCandidatos;
        public System.Windows.Forms.Button btnElicoes;
        public System.Windows.Forms.Button button1;
    }
}