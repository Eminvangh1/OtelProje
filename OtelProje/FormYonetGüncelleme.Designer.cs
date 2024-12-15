namespace OtelProje
{
    partial class FormYonetGüncelleme
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
            this.txtyıd = new System.Windows.Forms.TextBox();
            this.lblyoneticiad = new System.Windows.Forms.Label();
            this.txtyad = new System.Windows.Forms.TextBox();
            this.lblelektrik = new System.Windows.Forms.Label();
            this.txtysifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yöneticiıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yöneticiNckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yöneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yöneticiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet4 = new OtelProje.OtelDataSet4();
            this.yöneticiTableAdapter = new OtelProje.OtelDataSet4TableAdapters.YöneticiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yöneticiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtyıd
            // 
            this.txtyıd.Location = new System.Drawing.Point(152, 26);
            this.txtyıd.Name = "txtyıd";
            this.txtyıd.Size = new System.Drawing.Size(117, 20);
            this.txtyıd.TabIndex = 17;
            // 
            // lblyoneticiad
            // 
            this.lblyoneticiad.AutoSize = true;
            this.lblyoneticiad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyoneticiad.Location = new System.Drawing.Point(28, 26);
            this.lblyoneticiad.Name = "lblyoneticiad";
            this.lblyoneticiad.Size = new System.Drawing.Size(91, 20);
            this.lblyoneticiad.TabIndex = 16;
            this.lblyoneticiad.Text = "Yönetici ID:";
            // 
            // txtyad
            // 
            this.txtyad.Location = new System.Drawing.Point(152, 57);
            this.txtyad.Name = "txtyad";
            this.txtyad.Size = new System.Drawing.Size(117, 20);
            this.txtyad.TabIndex = 19;
            // 
            // lblelektrik
            // 
            this.lblelektrik.AutoSize = true;
            this.lblelektrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblelektrik.Location = new System.Drawing.Point(28, 57);
            this.lblelektrik.Name = "lblelektrik";
            this.lblelektrik.Size = new System.Drawing.Size(94, 20);
            this.lblelektrik.TabIndex = 18;
            this.lblelektrik.Text = "Yönetici Ad:";
            // 
            // txtysifre
            // 
            this.txtysifre.Location = new System.Drawing.Point(152, 89);
            this.txtysifre.Name = "txtysifre";
            this.txtysifre.Size = new System.Drawing.Size(117, 20);
            this.txtysifre.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Şifre:";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(32, 131);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 22;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(113, 131);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 23;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(194, 131);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(75, 23);
            this.btngüncelle.TabIndex = 24;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yöneticiıdDataGridViewTextBoxColumn,
            this.yöneticiNckDataGridViewTextBoxColumn,
            this.yöneticiSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yöneticiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(333, 172);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yöneticiıdDataGridViewTextBoxColumn
            // 
            this.yöneticiıdDataGridViewTextBoxColumn.DataPropertyName = "Yöneticiıd";
            this.yöneticiıdDataGridViewTextBoxColumn.HeaderText = "Yöneticiıd";
            this.yöneticiıdDataGridViewTextBoxColumn.Name = "yöneticiıdDataGridViewTextBoxColumn";
            this.yöneticiıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yöneticiNckDataGridViewTextBoxColumn
            // 
            this.yöneticiNckDataGridViewTextBoxColumn.DataPropertyName = "YöneticiNck";
            this.yöneticiNckDataGridViewTextBoxColumn.HeaderText = "YöneticiNck";
            this.yöneticiNckDataGridViewTextBoxColumn.Name = "yöneticiNckDataGridViewTextBoxColumn";
            // 
            // yöneticiSifreDataGridViewTextBoxColumn
            // 
            this.yöneticiSifreDataGridViewTextBoxColumn.DataPropertyName = "YöneticiSifre";
            this.yöneticiSifreDataGridViewTextBoxColumn.HeaderText = "YöneticiSifre";
            this.yöneticiSifreDataGridViewTextBoxColumn.Name = "yöneticiSifreDataGridViewTextBoxColumn";
            // 
            // yöneticiBindingSource
            // 
            this.yöneticiBindingSource.DataMember = "Yönetici";
            this.yöneticiBindingSource.DataSource = this.otelDataSet4;
            // 
            // otelDataSet4
            // 
            this.otelDataSet4.DataSetName = "OtelDataSet4";
            this.otelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yöneticiTableAdapter
            // 
            this.yöneticiTableAdapter.ClearBeforeFill = true;
            // 
            // FormYonetGüncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtysifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtyad);
            this.Controls.Add(this.lblelektrik);
            this.Controls.Add(this.txtyıd);
            this.Controls.Add(this.lblyoneticiad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormYonetGüncelleme";
            this.Text = "Yönetici Güncelleme";
            this.Load += new System.EventHandler(this.FormYonetGüncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yöneticiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtyıd;
        private System.Windows.Forms.Label lblyoneticiad;
        private System.Windows.Forms.TextBox txtyad;
        private System.Windows.Forms.Label lblelektrik;
        private System.Windows.Forms.TextBox txtysifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtelDataSet4 otelDataSet4;
        private System.Windows.Forms.BindingSource yöneticiBindingSource;
        private OtelDataSet4TableAdapters.YöneticiTableAdapter yöneticiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiNckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiSifreDataGridViewTextBoxColumn;
    }
}