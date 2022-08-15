namespace ap.urunTakip_win
{
    partial class Layout
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Satis = new System.Windows.Forms.Button();
            this.btn_Ayarlar = new System.Windows.Forms.Button();
            this.btn_urun2 = new System.Windows.Forms.Button();
            this.btn_urun = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel1.Controls.Add(this.btn_Satis);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Ayarlar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_urun2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_urun);
            this.splitContainer1.Panel1.Controls.Add(this.btn_anasayfa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(1404, 538);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Satis
            // 
            this.btn_Satis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Satis.BackColor = System.Drawing.Color.White;
            this.btn_Satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Satis.Location = new System.Drawing.Point(12, 344);
            this.btn_Satis.Name = "btn_Satis";
            this.btn_Satis.Size = new System.Drawing.Size(127, 58);
            this.btn_Satis.TabIndex = 0;
            this.btn_Satis.Text = "Satışlar";
            this.btn_Satis.UseVisualStyleBackColor = false;
            this.btn_Satis.Click += new System.EventHandler(this.btn_Satis_Click);
            // 
            // btn_Ayarlar
            // 
            this.btn_Ayarlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ayarlar.BackColor = System.Drawing.Color.White;
            this.btn_Ayarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ayarlar.Location = new System.Drawing.Point(12, 436);
            this.btn_Ayarlar.Name = "btn_Ayarlar";
            this.btn_Ayarlar.Size = new System.Drawing.Size(127, 58);
            this.btn_Ayarlar.TabIndex = 0;
            this.btn_Ayarlar.Text = "Ayarlar";
            this.btn_Ayarlar.UseVisualStyleBackColor = false;
            this.btn_Ayarlar.Click += new System.EventHandler(this.btn_Ayarlar_Click);
            // 
            // btn_urun2
            // 
            this.btn_urun2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_urun2.BackColor = System.Drawing.Color.White;
            this.btn_urun2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urun2.Location = new System.Drawing.Point(12, 255);
            this.btn_urun2.Name = "btn_urun2";
            this.btn_urun2.Size = new System.Drawing.Size(127, 58);
            this.btn_urun2.TabIndex = 0;
            this.btn_urun2.Text = "Ürünler - € $";
            this.btn_urun2.UseVisualStyleBackColor = false;
            this.btn_urun2.Click += new System.EventHandler(this.btn_urun2_Click);
            // 
            // btn_urun
            // 
            this.btn_urun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_urun.BackColor = System.Drawing.Color.White;
            this.btn_urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urun.Location = new System.Drawing.Point(12, 162);
            this.btn_urun.Name = "btn_urun";
            this.btn_urun.Size = new System.Drawing.Size(127, 58);
            this.btn_urun.TabIndex = 0;
            this.btn_urun.Text = "Ürünler - ₺";
            this.btn_urun.UseVisualStyleBackColor = false;
            this.btn_urun.Click += new System.EventHandler(this.btn_urun_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_anasayfa.BackColor = System.Drawing.Color.White;
            this.btn_anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anasayfa.Location = new System.Drawing.Point(12, 62);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(127, 58);
            this.btn_anasayfa.TabIndex = 0;
            this.btn_anasayfa.Text = "Anasayfa";
            this.btn_anasayfa.UseVisualStyleBackColor = false;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İnternet Bağlantınız Olmadığı İçin Veritabanına Erişemiyoruz. ";
            this.label1.Visible = false;
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1404, 538);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Layout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Takip Uygulaması";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Satis;
        private System.Windows.Forms.Button btn_Ayarlar;
        private System.Windows.Forms.Button btn_urun;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Button btn_urun2;
        private System.Windows.Forms.Label label1;
    }
}