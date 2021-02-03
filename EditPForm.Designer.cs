namespace Midnight
{
    partial class EditPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvarP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecoP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbTipoP = new System.Windows.Forms.CheckBox();
            this.txtTipoP = new System.Windows.Forms.TextBox();
            this.cbxTipoProduto = new System.Windows.Forms.ComboBox();
            this.textBtxtDescricaoPox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIdP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSalvarP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPrecoP);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBtxtDescricaoPox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 97);
            this.panel1.TabIndex = 8;
            // 
            // lblIdP
            // 
            this.lblIdP.AutoSize = true;
            this.lblIdP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdP.Location = new System.Drawing.Point(5, 27);
            this.lblIdP.Name = "lblIdP";
            this.lblIdP.Size = new System.Drawing.Size(43, 17);
            this.lblIdP.TabIndex = 9;
            this.lblIdP.Text = "lblIdP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // btnSalvarP
            // 
            this.btnSalvarP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarP.Location = new System.Drawing.Point(657, 56);
            this.btnSalvarP.Name = "btnSalvarP";
            this.btnSalvarP.Size = new System.Drawing.Size(108, 32);
            this.btnSalvarP.TabIndex = 5;
            this.btnSalvarP.Text = "SALVAR";
            this.btnSalvarP.UseVisualStyleBackColor = true;
            this.btnSalvarP.Click += new System.EventHandler(this.btnSalvarP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preço";
            // 
            // txtPrecoP
            // 
            this.txtPrecoP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoP.Location = new System.Drawing.Point(657, 24);
            this.txtPrecoP.Name = "txtPrecoP";
            this.txtPrecoP.Size = new System.Drawing.Size(108, 25);
            this.txtPrecoP.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbTipoP);
            this.groupBox1.Controls.Add(this.txtTipoP);
            this.groupBox1.Controls.Add(this.cbxTipoProduto);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(141, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // ckbTipoP
            // 
            this.ckbTipoP.AutoSize = true;
            this.ckbTipoP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTipoP.Location = new System.Drawing.Point(6, 60);
            this.ckbTipoP.Name = "ckbTipoP";
            this.ckbTipoP.Size = new System.Drawing.Size(81, 20);
            this.ckbTipoP.TabIndex = 2;
            this.ckbTipoP.Text = "OUTROS";
            this.ckbTipoP.UseVisualStyleBackColor = true;
            this.ckbTipoP.CheckedChanged += new System.EventHandler(this.ckbTipoP_CheckedChanged);
            // 
            // txtTipoP
            // 
            this.txtTipoP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoP.Location = new System.Drawing.Point(6, 21);
            this.txtTipoP.Name = "txtTipoP";
            this.txtTipoP.Size = new System.Drawing.Size(188, 25);
            this.txtTipoP.TabIndex = 1;
            this.txtTipoP.Visible = false;
            // 
            // cbxTipoProduto
            // 
            this.cbxTipoProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoProduto.FormattingEnabled = true;
            this.cbxTipoProduto.Items.AddRange(new object[] {
            "MESA",
            "INGRESSO",
            "Agua (com gás)",
            "Agua (sem gás)",
            "Caipirinha",
            "Cerveja",
            "Chopp (300ml)",
            "Chopp (500ml)",
            "Chopp (torre)",
            "Chopp de Vinho (300ml)",
            "Chopp de Vinho (500ml)",
            "Chopp de Vinho (torre)",
            "Drink",
            "Dose",
            "Energetico (lata)",
            "Gin Tonica",
            "Gin Tropical",
            "Vinho (taça)",
            "Vinho (garrafa)",
            "Sucos",
            "Refrigerante (lata)",
            "Refrigerante (600ml)",
            "Refrigerante (2L)"});
            this.cbxTipoProduto.Location = new System.Drawing.Point(6, 22);
            this.cbxTipoProduto.Name = "cbxTipoProduto";
            this.cbxTipoProduto.Size = new System.Drawing.Size(188, 24);
            this.cbxTipoProduto.TabIndex = 0;
            // 
            // textBtxtDescricaoPox1
            // 
            this.textBtxtDescricaoPox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBtxtDescricaoPox1.Location = new System.Drawing.Point(353, 24);
            this.textBtxtDescricaoPox1.Name = "textBtxtDescricaoPox1";
            this.textBtxtDescricaoPox1.Size = new System.Drawing.Size(298, 25);
            this.textBtxtDescricaoPox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.tipo,
            this.preco,
            this.descricao});
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // preco
            // 
            this.preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // EditPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 283);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditPForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvarP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecoP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbTipoP;
        private System.Windows.Forms.TextBox txtTipoP;
        private System.Windows.Forms.ComboBox cbxTipoProduto;
        private System.Windows.Forms.TextBox textBtxtDescricaoPox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    }
}