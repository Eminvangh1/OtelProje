namespace OtelProje
{
    partial class FormGiderListele
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.otelDataSet3 = new OtelProje.OtelDataSet3();
            this.otelGiderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelGiderlerTableAdapter = new OtelProje.OtelDataSet3TableAdapters.OtelGiderlerTableAdapter();
            this.ödemelerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doğalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diğerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelGiderlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ödemelerIDDataGridViewTextBoxColumn,
            this.elektrikDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.doğalgazDataGridViewTextBoxColumn,
            this.gıdaDataGridViewTextBoxColumn,
            this.diğerDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.otelGiderlerBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 250);
            this.dataGridView2.TabIndex = 1;
            // 
            // otelDataSet3
            // 
            this.otelDataSet3.DataSetName = "OtelDataSet3";
            this.otelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otelGiderlerBindingSource
            // 
            this.otelGiderlerBindingSource.DataMember = "OtelGiderler";
            this.otelGiderlerBindingSource.DataSource = this.otelDataSet3;
            // 
            // otelGiderlerTableAdapter
            // 
            this.otelGiderlerTableAdapter.ClearBeforeFill = true;
            // 
            // ödemelerIDDataGridViewTextBoxColumn
            // 
            this.ödemelerIDDataGridViewTextBoxColumn.DataPropertyName = "ÖdemelerID";
            this.ödemelerIDDataGridViewTextBoxColumn.HeaderText = "ÖdemelerID";
            this.ödemelerIDDataGridViewTextBoxColumn.Name = "ödemelerIDDataGridViewTextBoxColumn";
            this.ödemelerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elektrikDataGridViewTextBoxColumn
            // 
            this.elektrikDataGridViewTextBoxColumn.DataPropertyName = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.HeaderText = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.Name = "elektrikDataGridViewTextBoxColumn";
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            // 
            // doğalgazDataGridViewTextBoxColumn
            // 
            this.doğalgazDataGridViewTextBoxColumn.DataPropertyName = "Doğalgaz";
            this.doğalgazDataGridViewTextBoxColumn.HeaderText = "Doğalgaz";
            this.doğalgazDataGridViewTextBoxColumn.Name = "doğalgazDataGridViewTextBoxColumn";
            // 
            // gıdaDataGridViewTextBoxColumn
            // 
            this.gıdaDataGridViewTextBoxColumn.DataPropertyName = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.HeaderText = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.Name = "gıdaDataGridViewTextBoxColumn";
            // 
            // diğerDataGridViewTextBoxColumn
            // 
            this.diğerDataGridViewTextBoxColumn.DataPropertyName = "Diğer";
            this.diğerDataGridViewTextBoxColumn.HeaderText = "Diğer";
            this.diğerDataGridViewTextBoxColumn.Name = "diğerDataGridViewTextBoxColumn";
            // 
            // FormGiderListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(643, 250);
            this.Controls.Add(this.dataGridView2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGiderListele";
            this.Text = "GiderListele";
            this.Load += new System.EventHandler(this.FormGiderListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelGiderlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private OtelDataSet3 otelDataSet3;
        private System.Windows.Forms.BindingSource otelGiderlerBindingSource;
        private OtelDataSet3TableAdapters.OtelGiderlerTableAdapter otelGiderlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ödemelerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doğalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diğerDataGridViewTextBoxColumn;
    }
}