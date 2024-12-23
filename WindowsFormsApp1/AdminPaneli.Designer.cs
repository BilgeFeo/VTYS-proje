namespace WindowsFormsApp1
{
    partial class AdminPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPaneli));
            this.pGuncelleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.cikisButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pilotPanel = new System.Windows.Forms.Panel();
            this.pilotlar = new System.Windows.Forms.ComboBox();
            this.pilotMaasText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gorevliMaasText = new System.Windows.Forms.TextBox();
            this.gorevliler = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pilotPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGuncelleButton
            // 
            this.pGuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pGuncelleButton.Location = new System.Drawing.Point(12, 125);
            this.pGuncelleButton.Name = "pGuncelleButton";
            this.pGuncelleButton.Size = new System.Drawing.Size(218, 33);
            this.pGuncelleButton.TabIndex = 0;
            this.pGuncelleButton.Text = "Pilot Maas Guncelle";
            this.pGuncelleButton.UseVisualStyleBackColor = true;
            this.pGuncelleButton.Click += new System.EventHandler(this.pGuncelleButton_Click);
            // 
            // silButton
            // 
            this.silButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Location = new System.Drawing.Point(12, 290);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(218, 33);
            this.silButton.TabIndex = 1;
            this.silButton.Text = "Bakim Kaydi Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // cikisButton
            // 
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.Location = new System.Drawing.Point(12, 436);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(133, 33);
            this.cikisButton.TabIndex = 2;
            this.cikisButton.Text = "Çıkış";
            this.cikisButton.UseVisualStyleBackColor = true;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kabin Görevlisi Maas Guncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pilotPanel
            // 
            this.pilotPanel.BackColor = System.Drawing.Color.Transparent;
            this.pilotPanel.Controls.Add(this.label2);
            this.pilotPanel.Controls.Add(this.label1);
            this.pilotPanel.Controls.Add(this.button2);
            this.pilotPanel.Controls.Add(this.pilotMaasText);
            this.pilotPanel.Controls.Add(this.pilotlar);
            this.pilotPanel.Location = new System.Drawing.Point(294, 112);
            this.pilotPanel.Name = "pilotPanel";
            this.pilotPanel.Size = new System.Drawing.Size(257, 244);
            this.pilotPanel.TabIndex = 4;
            this.pilotPanel.Visible = false;
            // 
            // pilotlar
            // 
            this.pilotlar.FormattingEnabled = true;
            this.pilotlar.Location = new System.Drawing.Point(34, 42);
            this.pilotlar.Name = "pilotlar";
            this.pilotlar.Size = new System.Drawing.Size(198, 24);
            this.pilotlar.TabIndex = 0;
            // 
            // pilotMaasText
            // 
            this.pilotMaasText.Location = new System.Drawing.Point(34, 109);
            this.pilotMaasText.Name = "pilotMaasText";
            this.pilotMaasText.Size = new System.Drawing.Size(198, 22);
            this.pilotMaasText.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(57, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Maaş Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maaşı Güncellenecek Pilot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(85, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Maaş";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.gorevliMaasText);
            this.panel1.Controls.Add(this.gorevliler);
            this.panel1.Location = new System.Drawing.Point(270, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 211);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(85, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yeni Maaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maaşı Güncellenecek Görevli";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(57, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Maaş Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gorevliMaasText
            // 
            this.gorevliMaasText.Location = new System.Drawing.Point(34, 109);
            this.gorevliMaasText.Name = "gorevliMaasText";
            this.gorevliMaasText.Size = new System.Drawing.Size(198, 22);
            this.gorevliMaasText.TabIndex = 1;
            // 
            // gorevliler
            // 
            this.gorevliler.FormattingEnabled = true;
            this.gorevliler.Location = new System.Drawing.Point(34, 42);
            this.gorevliler.Name = "gorevliler";
            this.gorevliler.Size = new System.Drawing.Size(198, 24);
            this.gorevliler.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 164);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(236, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 241);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(465, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 33);
            this.button4.TabIndex = 7;
            this.button4.Text = "Seçili Satırı Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.plane_desktop_yms31u8wyuke7ari;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pilotPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.pGuncelleButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPaneli";
            this.Text = "AdminPaneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPaneli_FormClosing);
            this.pilotPanel.ResumeLayout(false);
            this.pilotPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pGuncelleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pilotPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pilotMaasText;
        private System.Windows.Forms.ComboBox pilotlar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox gorevliMaasText;
        private System.Windows.Forms.ComboBox gorevliler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
    }
}