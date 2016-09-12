namespace prjEleicao
{
    partial class frmEleitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEleitor));
            this.label6 = new System.Windows.Forms.Label();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstView = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.asyncConsultar = new System.ComponentModel.BackgroundWorker();
            this.asyncInserir = new System.ComponentModel.BackgroundWorker();
            this.asyncEditar = new System.ComponentModel.BackgroundWorker();
            this.asyncExcluir = new System.ComponentModel.BackgroundWorker();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pcbStatus = new System.Windows.Forms.PictureBox();
            this.tpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.tmPesq = new System.Windows.Forms.Timer(this.components);
            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(117)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(339, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(376, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "CADASTRO DE PESSOA FÍSICA(CPF)";
            // 
            // pnlTopo
            // 
            this.pnlTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(117)))));
            this.pnlTopo.Controls.Add(this.btnImport);
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 46);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "Eleitores";
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
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(51)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(340, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(372, 45);
            this.txtNome.TabIndex = 60;
            this.txtNome.Tag = "editable";
            this.txtNome.Text = "Sem Eleitor";
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
            // asyncEditar
            // 
            this.asyncEditar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.asyncEditar_DoWork);
            this.asyncEditar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.asyncEditar_RunWorkerCompleted);
            // 
            // asyncExcluir
            // 
            this.asyncExcluir.DoWork += new System.ComponentModel.DoWorkEventHandler(this.asyncExcluir_DoWork);
            this.asyncExcluir.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.asyncExcluir_RunWorkerCompleted);
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(51)))));
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.txtCPF.ForeColor = System.Drawing.Color.White;
            this.txtCPF.Location = new System.Drawing.Point(340, 194);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(183, 32);
            this.txtCPF.TabIndex = 64;
            this.txtCPF.Tag = "editable";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImport.BackgroundImage")));
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(189, 27);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(38, 30);
            this.btnImport.TabIndex = 35;
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tpInfo.SetToolTip(this.btnImport, "Importar eleitores");
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
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
            this.tpInfo.SetToolTip(this.btnEdit, "Editar");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.tpInfo.SetToolTip(this.btnExcluir, "Excluir");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.tpInfo.SetToolTip(this.btnAdd, "Adicionar");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // tpInfo
            // 
            this.tpInfo.BackColor = System.Drawing.Color.White;
            // 
            // tmPesq
            // 
            this.tmPesq.Interval = 1000;
            this.tmPesq.Tick += new System.EventHandler(this.tmPesq_Tick);
            // 
            // frmEleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1010, 683);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pcbStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEleitor";
            this.Text = "ELEITOR";
            this.Activated += new System.EventHandler(this.frmEleitor_Activated);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pcbStatus;
        private System.ComponentModel.BackgroundWorker asyncConsultar;
        private System.ComponentModel.BackgroundWorker asyncInserir;
        private System.ComponentModel.BackgroundWorker asyncEditar;
        private System.ComponentModel.BackgroundWorker asyncExcluir;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ToolTip tpInfo;
        private System.Windows.Forms.Timer tmPesq;

    }
}