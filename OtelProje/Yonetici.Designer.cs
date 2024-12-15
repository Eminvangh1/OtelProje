namespace OtelProje
{
    partial class Yonetici
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
            this.txtkullanıcıad = new System.Windows.Forms.TextBox();
            this.lblelektrik = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblkayıtsistemi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtkullanıcıad
            // 
            this.txtkullanıcıad.Location = new System.Drawing.Point(140, 142);
            this.txtkullanıcıad.Name = "txtkullanıcıad";
            this.txtkullanıcıad.Size = new System.Drawing.Size(100, 20);
            this.txtkullanıcıad.TabIndex = 15;
            // 
            // lblelektrik
            // 
            this.lblelektrik.AutoSize = true;
            this.lblelektrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblelektrik.Location = new System.Drawing.Point(36, 142);
            this.lblelektrik.Name = "lblelektrik";
            this.lblelektrik.Size = new System.Drawing.Size(94, 20);
            this.lblelektrik.TabIndex = 14;
            this.lblelektrik.Text = "Kullanıcı Ad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(140, 178);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 20);
            this.txtsifre.TabIndex = 18;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Şifre:";
            // 
            // lblkayıtsistemi
            // 
            this.lblkayıtsistemi.AutoSize = true;
            this.lblkayıtsistemi.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkayıtsistemi.Location = new System.Drawing.Point(79, 55);
            this.lblkayıtsistemi.Name = "lblkayıtsistemi";
            this.lblkayıtsistemi.Size = new System.Drawing.Size(201, 32);
            this.lblkayıtsistemi.TabIndex = 19;
            this.lblkayıtsistemi.Text = "Otel Kayıt Sistemi";
            // 
            // Yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::OtelProje.Properties.Resources.matiat_img3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.lblkayıtsistemi);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtkullanıcıad);
            this.Controls.Add(this.lblelektrik);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Yonetici";
            this.Text = "Yonetici İslemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkullanıcıad;
        private System.Windows.Forms.Label lblelektrik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblkayıtsistemi;
    }
}