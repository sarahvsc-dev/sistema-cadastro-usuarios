namespace Projeto_crud
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.lblEditarUsuario = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblExcluirId = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEditar
            // 
            this.txtEditar.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditar.Location = new System.Drawing.Point(221, 415);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(40, 20);
            this.txtEditar.TabIndex = 90;
            // 
            // lblEditarUsuario
            // 
            this.lblEditarUsuario.AutoSize = true;
            this.lblEditarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblEditarUsuario.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEditarUsuario.Location = new System.Drawing.Point(20, 415);
            this.lblEditarUsuario.Name = "lblEditarUsuario";
            this.lblEditarUsuario.Size = new System.Drawing.Size(208, 18);
            this.lblEditarUsuario.TabIndex = 89;
            this.lblEditarUsuario.Text = "Digite o ID que deseja editar : \r\n";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.Location = new System.Drawing.Point(593, 420);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(95, 20);
            this.txtId.TabIndex = 88;
            // 
            // lblExcluirId
            // 
            this.lblExcluirId.AutoSize = true;
            this.lblExcluirId.BackColor = System.Drawing.Color.Transparent;
            this.lblExcluirId.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluirId.ForeColor = System.Drawing.Color.Red;
            this.lblExcluirId.Location = new System.Drawing.Point(482, 420);
            this.lblExcluirId.Name = "lblExcluirId";
            this.lblExcluirId.Size = new System.Drawing.Size(117, 18);
            this.lblExcluirId.TabIndex = 87;
            this.lblExcluirId.Text = "Excluir por ID : ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(694, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 24);
            this.btnBuscar.TabIndex = 86;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscar.Location = new System.Drawing.Point(482, 24);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(201, 20);
            this.txtBuscar.TabIndex = 85;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBuscar.Location = new System.Drawing.Point(361, 26);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(115, 18);
            this.lblBuscar.TabIndex = 84;
            this.lblBuscar.Text = "Buscar por ID : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(364, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 355);
            this.dataGridView1.TabIndex = 83;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(138, 173);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(178, 20);
            this.txtEstado.TabIndex = 82;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstado.Location = new System.Drawing.Point(70, 173);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 18);
            this.lblEstado.TabIndex = 81;
            this.lblEstado.Text = "Estado :";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(137, 222);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(178, 20);
            this.txtCidade.TabIndex = 80;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCidade.Location = new System.Drawing.Point(69, 222);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(62, 18);
            this.lblCidade.TabIndex = 79;
            this.lblCidade.Text = "Cidade :";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(267, 412);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(59, 24);
            this.btnEditar.TabIndex = 78;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(239, 314);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnAdicionar.Size = new System.Drawing.Size(77, 31);
            this.btnAdicionar.TabIndex = 77;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(694, 415);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(67, 25);
            this.btnExcluir.TabIndex = 76;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefone.Location = new System.Drawing.Point(63, 271);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(73, 18);
            this.lblTelefone.TabIndex = 75;
            this.lblTelefone.Text = "Telefone :";
            // 
            // maskTelefone
            // 
            this.maskTelefone.Location = new System.Drawing.Point(137, 272);
            this.maskTelefone.Mask = "(00)00000-0000";
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(178, 20);
            this.maskTelefone.TabIndex = 74;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 20);
            this.txtEmail.TabIndex = 73;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.Location = new System.Drawing.Point(138, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(178, 20);
            this.txtNome.TabIndex = 72;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(75, 123);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 18);
            this.lbl.TabIndex = 71;
            this.lbl.Text = "Email :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(75, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 18);
            this.lblNome.TabIndex = 70;
            this.lblNome.Text = "Nome :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.lblEditarUsuario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblExcluirId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.maskTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.Label lblEditarUsuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblExcluirId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblNome;
    }
}

