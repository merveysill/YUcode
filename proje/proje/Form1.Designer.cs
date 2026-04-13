
namespace proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.girişYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şansZarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bilgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yerÖnerisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dizaynÖnerisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişYapToolStripMenuItem,
            this.ürünlerToolStripMenuItem,
            this.şansZarıToolStripMenuItem,
            this.magazinToolStripMenuItem,
            this.bilgilerToolStripMenuItem,
            this.yerÖnerisiToolStripMenuItem,
            this.dizaynÖnerisiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Dizayn Önerisi";
            // 
            // girişYapToolStripMenuItem
            // 
            this.girişYapToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.girişYapToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.girişYapToolStripMenuItem.Name = "girişYapToolStripMenuItem";
            this.girişYapToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.girişYapToolStripMenuItem.Text = "Giriş Yap";
            this.girişYapToolStripMenuItem.Click += new System.EventHandler(this.girişYapToolStripMenuItem_Click);
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // şansZarıToolStripMenuItem
            // 
            this.şansZarıToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.şansZarıToolStripMenuItem.Name = "şansZarıToolStripMenuItem";
            this.şansZarıToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.şansZarıToolStripMenuItem.Text = "Şans Zarı";
            this.şansZarıToolStripMenuItem.Click += new System.EventHandler(this.şansZarıToolStripMenuItem_Click);
            // 
            // magazinToolStripMenuItem
            // 
            this.magazinToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.magazinToolStripMenuItem.Name = "magazinToolStripMenuItem";
            this.magazinToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.magazinToolStripMenuItem.Text = "Magazin";
            this.magazinToolStripMenuItem.Click += new System.EventHandler(this.magazinToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(394, 412);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // bilgilerToolStripMenuItem
            // 
            this.bilgilerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bilgilerToolStripMenuItem.Name = "bilgilerToolStripMenuItem";
            this.bilgilerToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.bilgilerToolStripMenuItem.Text = "Hayat Hileleri";
            this.bilgilerToolStripMenuItem.Click += new System.EventHandler(this.bilgilerToolStripMenuItem_Click);
            // 
            // yerÖnerisiToolStripMenuItem
            // 
            this.yerÖnerisiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yerÖnerisiToolStripMenuItem.Name = "yerÖnerisiToolStripMenuItem";
            this.yerÖnerisiToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.yerÖnerisiToolStripMenuItem.Text = "Yer Önerisi";
            this.yerÖnerisiToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yerÖnerisiToolStripMenuItem.Click += new System.EventHandler(this.yerÖnerisiToolStripMenuItem_Click);
            // 
            // dizaynÖnerisiToolStripMenuItem
            // 
            this.dizaynÖnerisiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dizaynÖnerisiToolStripMenuItem.Name = "dizaynÖnerisiToolStripMenuItem";
            this.dizaynÖnerisiToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.dizaynÖnerisiToolStripMenuItem.Text = "Dizayn Önerisi";
            this.dizaynÖnerisiToolStripMenuItem.Click += new System.EventHandler(this.dizaynÖnerisiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şansZarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazinToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem girişYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yerÖnerisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dizaynÖnerisiToolStripMenuItem;
    }
}

