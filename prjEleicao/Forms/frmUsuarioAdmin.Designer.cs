namespace prjEleicao
{
    partial class frmUsuarioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioAdmin));
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstView = new System.Windows.Forms.ListBox();
            this.pcbStatus = new System.Windows.Forms.PictureBox();
            this.txtNmLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.chkPermissoes = new System.Windows.Forms.CheckedListBox();
            this.asyncConsultar = new System.ComponentModel.BackgroundWorker();
            this.asyncInserir = new System.ComponentModel.BackgroundWorker();
            this.lblPermissoes = new System.Windows.Forms.Label();
            this.asyncExcluir = new System.ComponentModel.BackgroundWorker();
            this.asyncEditar = new System.ComponentModel.BackgroundWorker();
            this.tmPesq = new System.Windows.Forms.Timer(this.components);
            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(341, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 30);
            this.btnSave.TabIndex = 33;
            this.btnSave.Tag = "editable";
            this.btnSave.Text = "SALVAR";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlTopo
            // 
            this.pnlTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopo.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTopo.Controls.Add(this.btnEdit);
            this.pnlTopo.Controls.Add(this.btnSave);
            this.pnlTopo.Controls.Add(this.txtPesq);
            this.pnlTopo.Controls.Add(this.btnExcluir);
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.btnAdd);
            this.pnlTopo.Controls.Add(this.btnCancel);
            this.pnlTopo.Location = new System.Drawing.Point(-1, -1);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1011, 111);
            this.pnlTopo.TabIndex = 58;
            this.pnlTopo.Tag = "editable";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnEdit.BackgroundImage = global::prjEleicao.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(341, 69);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(36, 30);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtPesq
            // 
            this.txtPesq.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesq.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.txtPesq.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPesq.Location = new System.Drawing.Point(26, 74);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(269, 29);
            this.txtPesq.TabIndex = 23;
            this.txtPesq.TextChanged += new System.EventHandler(this.txtPesq_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnExcluir.BackgroundImage = global::prjEleicao.Properties.Resources.excluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(682, 69);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(30, 30);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Tag = "";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 46);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "Usuários";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAdd.BackgroundImage = global::prjEleicao.Properties.Resources.adicionar;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(231, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 30);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(625, 69);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 30);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Tag = "editable";
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(339, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(376, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "NOME DE LOGIN";
            // 
            // lstView
            // 
            this.lstView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView.ForeColor = System.Drawing.Color.DimGray;
            this.lstView.FormattingEnabled = true;
            this.lstView.ItemHeight = 20;
            this.lstView.Location = new System.Drawing.Point(24, 115);
            this.lstView.Name = "lstView";
            this.lstView.ScrollAlwaysVisible = true;
            this.lstView.Size = new System.Drawing.Size(269, 520);
            this.lstView.TabIndex = 59;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.lstView_SelectedIndexChanged);
            // 
            // pcbStatus
            // 
            this.pcbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbStatus.Image = ((System.Drawing.Image)(resources.GetObject("pcbStatus.Image")));
            this.pcbStatus.Location = new System.Drawing.Point(-1, 642);
            this.pcbStatus.Name = "pcbStatus";
            this.pcbStatus.Size = new System.Drawing.Size(1013, 42);
            this.pcbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbStatus.TabIndex = 61;
            this.pcbStatus.TabStop = false;
            this.pcbStatus.Visible = false;
            // 
            // txtNmLogin
            // 
            this.txtNmLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNmLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txtNmLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNmLogin.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.txtNmLogin.ForeColor = System.Drawing.Color.White;
            this.txtNmLogin.Location = new System.Drawing.Point(339, 193);
            this.txtNmLogin.Name = "txtNmLogin";
            this.txtNmLogin.ReadOnly = true;
            this.txtNmLogin.Size = new System.Drawing.Size(372, 32);
            this.txtNmLogin.TabIndex = 63;
            this.txtNmLogin.Tag = "";
            this.txtNmLogin.Text = "- -";
            // 
            // lblSenha
            // 
            this.lblSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.lblSenha.ForeColor = System.Drawing.Color.DimGray;
            this.lblSenha.Location = new System.Drawing.Point(339, 240);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(376, 19);
            this.lblSenha.TabIndex = 64;
            this.lblSenha.Text = "SENHA";
            this.lblSenha.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(339, 260);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ReadOnly = true;
            this.txtSenha.Size = new System.Drawing.Size(372, 32);
            this.txtSenha.TabIndex = 65;
            this.txtSenha.Tag = "editable";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Visible = false;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.lblConfSenha.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.lblConfSenha.ForeColor = System.Drawing.Color.DimGray;
            this.lblConfSenha.Location = new System.Drawing.Point(339, 308);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(376, 19);
            this.lblConfSenha.TabIndex = 66;
            this.lblConfSenha.Text = "CONFIRMAR SENHA";
            this.lblConfSenha.Visible = false;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txtConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfSenha.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.txtConfSenha.ForeColor = System.Drawing.Color.White;
            this.txtConfSenha.Location = new System.Drawing.Point(339, 328);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.ReadOnly = true;
            this.txtConfSenha.Size = new System.Drawing.Size(372, 32);
            this.txtConfSenha.TabIndex = 67;
            this.txtConfSenha.Tag = "editable";
            this.txtConfSenha.UseSystemPasswordChar = true;
            this.txtConfSenha.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(721, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "PERMISSÕES";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(340, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(372, 45);
            this.txtNome.TabIndex = 60;
            this.txtNome.Tag = "editable";
            this.txtNome.Text = "Sem Usuários";
            // 
            // chkPermissoes
            // 
            this.chkPermissoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPermissoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.chkPermissoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkPermissoes.CheckOnClick = true;
            this.chkPermissoes.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.chkPermissoes.ForeColor = System.Drawing.Color.White;
            this.chkPermissoes.Location = new System.Drawing.Point(721, 198);
            this.chkPermissoes.Name = "chkPermissoes";
            this.chkPermissoes.Size = new System.Drawing.Size(277, 435);
            this.chkPermissoes.TabIndex = 69;
            this.chkPermissoes.Tag = "";
            this.chkPermissoes.Visible = false;
            // 
            // asyncConsultar
            // 
            this.asyncConsultar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.asyncConsultar_DoWork);
            this.asyncConsultar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.asyncConsultar_RunWorkerCompleted);
            // 
            // asyncInserir
            // 
            this.asyncInserir.DoWork += new System.ComponentModel.DoWorkEventHandler(this.asyncInserir_DoWork);
            this.asyncInserir.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.asyncInserir_RunWorkerCompleted);
            // 
            // lblPermissoes
            // 
            this.lblPermissoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPermissoes.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lblPermissoes.ForeColor = System.Drawing.Color.White;
            this.lblPermissoes.Location = new System.Drawing.Point(722, 198);
            this.lblPermissoes.Name = "lblPermissoes";
            this.lblPermissoes.Size = new System.Drawing.Size(273, 419);
            this.lblPermissoes.TabIndex = 82;
            this.lblPermissoes.Tag = "editable";
            this.lblPermissoes.Text = "--";
            // 
            // asyncExcluir
            // 
            this.asyncExcluir.DoWork += new System.ComponentModel.DoWorkEventHandler(this.asyncExcluir_DoWork);
            this.asyncExcluir.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.asyncExcluir_RunWorkerCompleted);
            // 
            // asyncEditar
            // 
            this.asyncEditar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.asyncEditar_DoWork);
            this.asyncEditar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.asyncEditar_RunWorkerCompleted);
            // 
            // tmPesq
            // 
            this.tmPesq.Interval = 1000;
            this.tmPesq.Tick += new System.EventHandler(this.tmPesq_Tick);
            // 
            // frmUsuarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(1010, 683);
            this.Controls.Add(this.lblPermissoes);
            this.Controls.Add(this.chkPermissoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pcbStatus);
            this.Controls.Add(this.txtNmLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarioAdmin";
            this.Text = "USUÁRIOS";
            this.Activated += new System.EventHandler(this.frmUsuarioAdmin_Activated);
            this.Load += new System.EventHandler(this.frmUsuarioAdmin_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.PictureBox pcbStatus;
        private System.Windows.Forms.TextBox txtNmLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckedListBox chkPermissoes;
        private System.ComponentModel.BackgroundWorker asyncConsultar;
        private System.ComponentModel.BackgroundWorker asyncInserir;
        private System.Windows.Forms.Label lblPermissoes;
        private System.ComponentModel.BackgroundWorker asyncExcluir;
        private System.ComponentModel.BackgroundWorker asyncEditar;
        private System.Windows.Forms.Timer tmPesq;
    }
}