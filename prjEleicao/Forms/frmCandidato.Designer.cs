namespace prjEleicao
{
    partial class frmCandidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCandidato));
            this.pnlTopoCandidato = new System.Windows.Forms.Panel();
            this.btnEditCand = new System.Windows.Forms.Button();
            this.btnSaveCand = new System.Windows.Forms.Button();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.btnExcluirCand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCandidato = new System.Windows.Forms.Button();
            this.btnCancelCand = new System.Windows.Forms.Button();
            this.btnVerPartido = new System.Windows.Forms.Button();
            this.cbPartido = new System.Windows.Forms.ComboBox();
            this.pcbStatus = new System.Windows.Forms.PictureBox();
            this.btnAlterarImagem = new System.Windows.Forms.Button();
            this.pcbFotoCandidato = new System.Windows.Forms.PictureBox();
            this.lstView = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.txtNomeCandidato = new System.Windows.Forms.TextBox();
            this.AsyncPesquisar = new System.ComponentModel.BackgroundWorker();
            this.tmPesq = new System.Windows.Forms.Timer(this.components);
            this.AsyncInserir = new System.ComponentModel.BackgroundWorker();
            this.AsyncEditar = new System.ComponentModel.BackgroundWorker();
            this.AsyncExcluir = new System.ComponentModel.BackgroundWorker();
            this.pnlTopoCandidato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopoCandidato
            // 
            this.pnlTopoCandidato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopoCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(162)))));
            this.pnlTopoCandidato.Controls.Add(this.btnEditCand);
            this.pnlTopoCandidato.Controls.Add(this.btnSaveCand);
            this.pnlTopoCandidato.Controls.Add(this.txtPesq);
            this.pnlTopoCandidato.Controls.Add(this.btnExcluirCand);
            this.pnlTopoCandidato.Controls.Add(this.label1);
            this.pnlTopoCandidato.Controls.Add(this.btnAddCandidato);
            this.pnlTopoCandidato.Controls.Add(this.btnCancelCand);
            this.pnlTopoCandidato.Controls.Add(this.btnVerPartido);
            this.pnlTopoCandidato.Location = new System.Drawing.Point(-1, -1);
            this.pnlTopoCandidato.Name = "pnlTopoCandidato";
            this.pnlTopoCandidato.Size = new System.Drawing.Size(1011, 111);
            this.pnlTopoCandidato.TabIndex = 26;
            this.pnlTopoCandidato.Tag = "editable";
            // 
            // btnEditCand
            // 
            this.btnEditCand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnEditCand.BackgroundImage = global::prjEleicao.Properties.Resources.edit;
            this.btnEditCand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditCand.FlatAppearance.BorderSize = 0;
            this.btnEditCand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.btnEditCand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btnEditCand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCand.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnEditCand.ForeColor = System.Drawing.Color.White;
            this.btnEditCand.Location = new System.Drawing.Point(448, 69);
            this.btnEditCand.Name = "btnEditCand";
            this.btnEditCand.Size = new System.Drawing.Size(36, 30);
            this.btnEditCand.TabIndex = 22;
            this.btnEditCand.UseVisualStyleBackColor = false;
            this.btnEditCand.Click += new System.EventHandler(this.btnEditCand_Click);
            // 
            // btnSaveCand
            // 
            this.btnSaveCand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSaveCand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveCand.FlatAppearance.BorderSize = 0;
            this.btnSaveCand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.btnSaveCand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCand.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnSaveCand.ForeColor = System.Drawing.Color.White;
            this.btnSaveCand.Location = new System.Drawing.Point(341, 69);
            this.btnSaveCand.Name = "btnSaveCand";
            this.btnSaveCand.Size = new System.Drawing.Size(87, 30);
            this.btnSaveCand.TabIndex = 33;
            this.btnSaveCand.Tag = "editable";
            this.btnSaveCand.Text = "SALVAR";
            this.btnSaveCand.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSaveCand.UseVisualStyleBackColor = false;
            this.btnSaveCand.Visible = false;
            this.btnSaveCand.Click += new System.EventHandler(this.btnSaveCand_Click);
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
            // btnExcluirCand
            // 
            this.btnExcluirCand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirCand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnExcluirCand.BackgroundImage = global::prjEleicao.Properties.Resources.excluir;
            this.btnExcluirCand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluirCand.FlatAppearance.BorderSize = 0;
            this.btnExcluirCand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnExcluirCand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirCand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCand.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnExcluirCand.ForeColor = System.Drawing.Color.White;
            this.btnExcluirCand.Location = new System.Drawing.Point(682, 69);
            this.btnExcluirCand.Name = "btnExcluirCand";
            this.btnExcluirCand.Size = new System.Drawing.Size(30, 30);
            this.btnExcluirCand.TabIndex = 21;
            this.btnExcluirCand.UseVisualStyleBackColor = false;
            this.btnExcluirCand.Click += new System.EventHandler(this.btnExcluirCand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 46);
            this.label1.TabIndex = 26;
            this.label1.Text = "Candidatos";
            // 
            // btnAddCandidato
            // 
            this.btnAddCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAddCandidato.BackgroundImage = global::prjEleicao.Properties.Resources.adicionar;
            this.btnAddCandidato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCandidato.FlatAppearance.BorderSize = 0;
            this.btnAddCandidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.btnAddCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCandidato.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnAddCandidato.ForeColor = System.Drawing.Color.White;
            this.btnAddCandidato.Location = new System.Drawing.Point(231, 27);
            this.btnAddCandidato.Name = "btnAddCandidato";
            this.btnAddCandidato.Size = new System.Drawing.Size(64, 30);
            this.btnAddCandidato.TabIndex = 20;
            this.btnAddCandidato.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddCandidato.UseVisualStyleBackColor = false;
            this.btnAddCandidato.Click += new System.EventHandler(this.btnAddCandidato_Click);
            // 
            // btnCancelCand
            // 
            this.btnCancelCand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelCand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancelCand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelCand.FlatAppearance.BorderSize = 0;
            this.btnCancelCand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnCancelCand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelCand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCand.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnCancelCand.ForeColor = System.Drawing.Color.White;
            this.btnCancelCand.Location = new System.Drawing.Point(625, 69);
            this.btnCancelCand.Name = "btnCancelCand";
            this.btnCancelCand.Size = new System.Drawing.Size(87, 30);
            this.btnCancelCand.TabIndex = 34;
            this.btnCancelCand.Tag = "editable";
            this.btnCancelCand.Text = "CANCELAR";
            this.btnCancelCand.UseVisualStyleBackColor = false;
            this.btnCancelCand.Visible = false;
            this.btnCancelCand.Click += new System.EventHandler(this.btnCancelCand_Click);
            // 
            // btnVerPartido
            // 
            this.btnVerPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnVerPartido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerPartido.FlatAppearance.BorderSize = 0;
            this.btnVerPartido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.btnVerPartido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btnVerPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPartido.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnVerPartido.ForeColor = System.Drawing.Color.White;
            this.btnVerPartido.Location = new System.Drawing.Point(341, 69);
            this.btnVerPartido.Name = "btnVerPartido";
            this.btnVerPartido.Size = new System.Drawing.Size(101, 30);
            this.btnVerPartido.TabIndex = 24;
            this.btnVerPartido.Text = "VER PARTIDO";
            this.btnVerPartido.UseVisualStyleBackColor = false;
            this.btnVerPartido.Click += new System.EventHandler(this.btnVerPartido_Click);
            // 
            // cbPartido
            // 
            this.cbPartido.BackColor = System.Drawing.Color.White;
            this.cbPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPartido.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.cbPartido.Location = new System.Drawing.Point(339, 195);
            this.cbPartido.Name = "cbPartido";
            this.cbPartido.Size = new System.Drawing.Size(208, 40);
            this.cbPartido.TabIndex = 40;
            this.cbPartido.Tag = "editable";
            this.cbPartido.Text = "Selecionar Partido";
            this.cbPartido.Visible = false;
            this.cbPartido.DropDown += new System.EventHandler(this.cbPartido_DropDown);
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
            this.pcbStatus.TabIndex = 36;
            this.pcbStatus.TabStop = false;
            this.pcbStatus.Visible = false;
            // 
            // btnAlterarImagem
            // 
            this.btnAlterarImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnAlterarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterarImagem.FlatAppearance.BorderSize = 0;
            this.btnAlterarImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.btnAlterarImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btnAlterarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarImagem.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnAlterarImagem.ForeColor = System.Drawing.Color.White;
            this.btnAlterarImagem.Location = new System.Drawing.Point(743, 253);
            this.btnAlterarImagem.Name = "btnAlterarImagem";
            this.btnAlterarImagem.Size = new System.Drawing.Size(200, 30);
            this.btnAlterarImagem.TabIndex = 37;
            this.btnAlterarImagem.Tag = "editable";
            this.btnAlterarImagem.Text = "ALTERAR IMAGEM";
            this.btnAlterarImagem.UseVisualStyleBackColor = false;
            this.btnAlterarImagem.Visible = false;
            this.btnAlterarImagem.Click += new System.EventHandler(this.btnAlterarImagem_Click);
            // 
            // pcbFotoCandidato
            // 
            this.pcbFotoCandidato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbFotoCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pcbFotoCandidato.Image = global::prjEleicao.Properties.Resources.noimage;
            this.pcbFotoCandidato.Location = new System.Drawing.Point(743, 44);
            this.pcbFotoCandidato.Name = "pcbFotoCandidato";
            this.pcbFotoCandidato.Size = new System.Drawing.Size(200, 203);
            this.pcbFotoCandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbFotoCandidato.TabIndex = 34;
            this.pcbFotoCandidato.TabStop = false;
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
            this.lstView.TabIndex = 33;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.lstView_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(339, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(376, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "PARTIDO";
            // 
            // lblPartido
            // 
            this.lblPartido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPartido.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lblPartido.ForeColor = System.Drawing.Color.White;
            this.lblPartido.Location = new System.Drawing.Point(335, 192);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(402, 41);
            this.lblPartido.TabIndex = 38;
            this.lblPartido.Tag = "editable";
            this.lblPartido.Text = "- -";
            // 
            // txtNomeCandidato
            // 
            this.txtNomeCandidato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtNomeCandidato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCandidato.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.txtNomeCandidato.ForeColor = System.Drawing.Color.White;
            this.txtNomeCandidato.Location = new System.Drawing.Point(340, 116);
            this.txtNomeCandidato.Name = "txtNomeCandidato";
            this.txtNomeCandidato.ReadOnly = true;
            this.txtNomeCandidato.Size = new System.Drawing.Size(372, 45);
            this.txtNomeCandidato.TabIndex = 35;
            this.txtNomeCandidato.Tag = "editable";
            this.txtNomeCandidato.Text = "Sem Candidato";
            // 
            // AsyncPesquisar
            // 
            this.AsyncPesquisar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AsyncPesquisar_DoWork);
            this.AsyncPesquisar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AsyncPesquisar_RunWorkerCompleted);
            // 
            // tmPesq
            // 
            this.tmPesq.Interval = 1000;
            this.tmPesq.Tick += new System.EventHandler(this.tmPesq_Tick);
            // 
            // AsyncInserir
            // 
            this.AsyncInserir.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AsyncInserir_DoWork);
            this.AsyncInserir.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AsyncInserir_RunWorkerCompleted);
            // 
            // AsyncEditar
            // 
            this.AsyncEditar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AsyncEditar_DoWork);
            this.AsyncEditar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AsyncEditar_RunWorkerCompleted);
            // 
            // AsyncExcluir
            // 
            this.AsyncExcluir.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AsyncExcluir_DoWork);
            this.AsyncExcluir.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AsyncExcluir_RunWorkerCompleted);
            // 
            // frmCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1010, 683);
            this.Controls.Add(this.cbPartido);
            this.Controls.Add(this.pcbStatus);
            this.Controls.Add(this.btnAlterarImagem);
            this.Controls.Add(this.pcbFotoCandidato);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.txtNomeCandidato);
            this.Controls.Add(this.pnlTopoCandidato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCandidato";
            this.Text = "frmCandidato";
            this.Activated += new System.EventHandler(this.frmCandidato_Activated);
            this.pnlTopoCandidato.ResumeLayout(false);
            this.pnlTopoCandidato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoCandidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopoCandidato;
        private System.Windows.Forms.Button btnEditCand;
        private System.Windows.Forms.Button btnSaveCand;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.Button btnExcluirCand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCandidato;
        private System.Windows.Forms.Button btnCancelCand;
        private System.Windows.Forms.Button btnVerPartido;
        private System.Windows.Forms.ComboBox cbPartido;
        private System.Windows.Forms.PictureBox pcbStatus;
        private System.Windows.Forms.Button btnAlterarImagem;
        private System.Windows.Forms.PictureBox pcbFotoCandidato;
        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.TextBox txtNomeCandidato;
        private System.ComponentModel.BackgroundWorker AsyncPesquisar;
        private System.Windows.Forms.Timer tmPesq;
        private System.ComponentModel.BackgroundWorker AsyncInserir;
        private System.ComponentModel.BackgroundWorker AsyncEditar;
        private System.ComponentModel.BackgroundWorker AsyncExcluir;
    }
}