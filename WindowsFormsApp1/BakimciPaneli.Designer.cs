namespace WindowsFormsApp1
{
    partial class BakimciPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BakimciPaneli));
            this.kayit_Button = new System.Windows.Forms.Button();
            this.kayitlar = new System.Windows.Forms.DataGridView();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.bakim_Button = new System.Windows.Forms.Button();
            this.geri_Button = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ucaklar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bakimAciklama = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kayitlar)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.ekle.SuspendLayout();
            this.SuspendLayout();
            // 
            // kayit_Button
            // 
            this.kayit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_Button.Location = new System.Drawing.Point(8, 30);
            this.kayit_Button.Name = "kayit_Button";
            this.kayit_Button.Size = new System.Drawing.Size(176, 31);
            this.kayit_Button.TabIndex = 0;
            this.kayit_Button.Text = "Bakım Kayıtlarını Göster";
            this.kayit_Button.UseVisualStyleBackColor = true;
            this.kayit_Button.Click += new System.EventHandler(this.kayit_Button_Click);
            // 
            // kayitlar
            // 
            this.kayitlar.BackgroundColor = System.Drawing.Color.Bisque;
            this.kayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kayitlar.Location = new System.Drawing.Point(215, 0);
            this.kayitlar.Name = "kayitlar";
            this.kayitlar.RowHeadersWidth = 51;
            this.kayitlar.RowTemplate.Height = 24;
            this.kayitlar.Size = new System.Drawing.Size(746, 150);
            this.kayitlar.TabIndex = 1;
            this.kayitlar.Visible = false;
            this.kayitlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.Controls.Add(this.geri_Button);
            this.menuPanel.Controls.Add(this.bakim_Button);
            this.menuPanel.Controls.Add(this.kayit_Button);
            this.menuPanel.Location = new System.Drawing.Point(0, 101);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(187, 311);
            this.menuPanel.TabIndex = 2;
            // 
            // bakim_Button
            // 
            this.bakim_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakim_Button.Location = new System.Drawing.Point(11, 119);
            this.bakim_Button.Name = "bakim_Button";
            this.bakim_Button.Size = new System.Drawing.Size(159, 31);
            this.bakim_Button.TabIndex = 1;
            this.bakim_Button.Text = "Bakım Ekle";
            this.bakim_Button.UseVisualStyleBackColor = true;
            this.bakim_Button.Click += new System.EventHandler(this.bakim_Button_Click);
            // 
            // geri_Button
            // 
            this.geri_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri_Button.Location = new System.Drawing.Point(11, 212);
            this.geri_Button.Name = "geri_Button";
            this.geri_Button.Size = new System.Drawing.Size(159, 31);
            this.geri_Button.TabIndex = 2;
            this.geri_Button.Text = "Geri";
            this.geri_Button.UseVisualStyleBackColor = true;
            this.geri_Button.Click += new System.EventHandler(this.geri_Button_Click);
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.Bisque;
            this.ekle.Controls.Add(this.bakimAciklama);
            this.ekle.Controls.Add(this.label3);
            this.ekle.Controls.Add(this.label2);
            this.ekle.Controls.Add(this.ucaklar);
            this.ekle.Controls.Add(this.button1);
            this.ekle.Controls.Add(this.label1);
            this.ekle.Controls.Add(this.dateTimePicker1);
            this.ekle.Location = new System.Drawing.Point(263, 156);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(620, 210);
            this.ekle.TabIndex = 3;
            this.ekle.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(261, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bakım Tarihi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(226, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kayıt Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucaklar
            // 
            this.ucaklar.FormattingEnabled = true;
            this.ucaklar.Location = new System.Drawing.Point(13, 69);
            this.ucaklar.Name = "ucaklar";
            this.ucaklar.Size = new System.Drawing.Size(186, 24);
            this.ucaklar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uçaklar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(479, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Açıklama";
            // 
            // bakimAciklama
            // 
            this.bakimAciklama.Location = new System.Drawing.Point(431, 55);
            this.bakimAciklama.Name = "bakimAciklama";
            this.bakimAciklama.Size = new System.Drawing.Size(173, 96);
            this.bakimAciklama.TabIndex = 7;
            this.bakimAciklama.Text = "";
            // 
            // BakimciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.plane_desktop_yms31u8wyuke7ari;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 504);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.kayitlar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BakimciPaneli";
            this.Text = "Ucak Bakim Kaydi Ekrani";
            ((System.ComponentModel.ISupportInitialize)(this.kayitlar)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.ekle.ResumeLayout(false);
            this.ekle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kayit_Button;
        private System.Windows.Forms.DataGridView kayitlar;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button geri_Button;
        private System.Windows.Forms.Button bakim_Button;
        private System.Windows.Forms.Panel ekle;
        private System.Windows.Forms.ComboBox ucaklar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox bakimAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}