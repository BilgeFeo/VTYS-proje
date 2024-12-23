namespace WindowsFormsApp1
{
    partial class GisePaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GisePaneli));
            this.yolcuEkleButton = new System.Windows.Forms.Button();
            this.biletEkleButton = new System.Windows.Forms.Button();
            this.GosterButton = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.yolcuPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.soyIsimTextBox = new System.Windows.Forms.TextBox();
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.ekle1Button = new System.Windows.Forms.Button();
            this.biletAlPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.biletOlusturButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.yolcularcomboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veriPanel = new System.Windows.Forms.Panel();
            this.yolcuPanel.SuspendLayout();
            this.biletAlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.veriPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // yolcuEkleButton
            // 
            this.yolcuEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yolcuEkleButton.Location = new System.Drawing.Point(30, 86);
            this.yolcuEkleButton.Name = "yolcuEkleButton";
            this.yolcuEkleButton.Size = new System.Drawing.Size(142, 31);
            this.yolcuEkleButton.TabIndex = 0;
            this.yolcuEkleButton.Text = "Yolcu Ekle";
            this.yolcuEkleButton.UseVisualStyleBackColor = true;
            this.yolcuEkleButton.Click += new System.EventHandler(this.yolcuEkleButton_Click);
            // 
            // biletEkleButton
            // 
            this.biletEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletEkleButton.Location = new System.Drawing.Point(30, 150);
            this.biletEkleButton.Name = "biletEkleButton";
            this.biletEkleButton.Size = new System.Drawing.Size(142, 31);
            this.biletEkleButton.TabIndex = 1;
            this.biletEkleButton.Text = "Bilet Ekle";
            this.biletEkleButton.UseVisualStyleBackColor = true;
            this.biletEkleButton.Click += new System.EventHandler(this.biletEkleButton_Click);
            // 
            // GosterButton
            // 
            this.GosterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GosterButton.Location = new System.Drawing.Point(30, 214);
            this.GosterButton.Name = "GosterButton";
            this.GosterButton.Size = new System.Drawing.Size(142, 31);
            this.GosterButton.TabIndex = 2;
            this.GosterButton.Text = "Biletleri Göster";
            this.GosterButton.UseVisualStyleBackColor = true;
            this.GosterButton.Click += new System.EventHandler(this.GosterButton_Click);
            // 
            // geriButton
            // 
            this.geriButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriButton.Location = new System.Drawing.Point(30, 280);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(142, 31);
            this.geriButton.TabIndex = 3;
            this.geriButton.Text = "Geri";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // yolcuPanel
            // 
            this.yolcuPanel.BackColor = System.Drawing.Color.Transparent;
            this.yolcuPanel.Controls.Add(this.label4);
            this.yolcuPanel.Controls.Add(this.label3);
            this.yolcuPanel.Controls.Add(this.label2);
            this.yolcuPanel.Controls.Add(this.label1);
            this.yolcuPanel.Controls.Add(this.telefonTextBox);
            this.yolcuPanel.Controls.Add(this.emailTextBox);
            this.yolcuPanel.Controls.Add(this.soyIsimTextBox);
            this.yolcuPanel.Controls.Add(this.isimTextBox);
            this.yolcuPanel.Controls.Add(this.ekle1Button);
            this.yolcuPanel.Location = new System.Drawing.Point(246, 43);
            this.yolcuPanel.Name = "yolcuPanel";
            this.yolcuPanel.Size = new System.Drawing.Size(347, 314);
            this.yolcuPanel.TabIndex = 4;
            this.yolcuPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soy Isim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Isim";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(105, 194);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(136, 22);
            this.telefonTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(105, 138);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(136, 22);
            this.emailTextBox.TabIndex = 8;
            // 
            // soyIsimTextBox
            // 
            this.soyIsimTextBox.Location = new System.Drawing.Point(105, 74);
            this.soyIsimTextBox.Name = "soyIsimTextBox";
            this.soyIsimTextBox.Size = new System.Drawing.Size(136, 22);
            this.soyIsimTextBox.TabIndex = 7;
            // 
            // isimTextBox
            // 
            this.isimTextBox.Location = new System.Drawing.Point(105, 25);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(136, 22);
            this.isimTextBox.TabIndex = 6;
            // 
            // ekle1Button
            // 
            this.ekle1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle1Button.Location = new System.Drawing.Point(105, 257);
            this.ekle1Button.Name = "ekle1Button";
            this.ekle1Button.Size = new System.Drawing.Size(142, 31);
            this.ekle1Button.TabIndex = 5;
            this.ekle1Button.Text = "Yolcu Ekle";
            this.ekle1Button.UseVisualStyleBackColor = true;
            this.ekle1Button.Click += new System.EventHandler(this.ekle1Button_Click);
            // 
            // biletAlPanel
            // 
            this.biletAlPanel.BackColor = System.Drawing.Color.Transparent;
            this.biletAlPanel.Controls.Add(this.label12);
            this.biletAlPanel.Controls.Add(this.label11);
            this.biletAlPanel.Controls.Add(this.label10);
            this.biletAlPanel.Controls.Add(this.textBox3);
            this.biletAlPanel.Controls.Add(this.comboBox4);
            this.biletAlPanel.Controls.Add(this.biletOlusturButton);
            this.biletAlPanel.Controls.Add(this.label9);
            this.biletAlPanel.Controls.Add(this.label8);
            this.biletAlPanel.Controls.Add(this.label7);
            this.biletAlPanel.Controls.Add(this.label6);
            this.biletAlPanel.Controls.Add(this.label5);
            this.biletAlPanel.Controls.Add(this.comboBox3);
            this.biletAlPanel.Controls.Add(this.textBox2);
            this.biletAlPanel.Controls.Add(this.textBox1);
            this.biletAlPanel.Controls.Add(this.comboBox2);
            this.biletAlPanel.Controls.Add(this.yolcularcomboBox);
            this.biletAlPanel.Location = new System.Drawing.Point(209, 86);
            this.biletAlPanel.Name = "biletAlPanel";
            this.biletAlPanel.Size = new System.Drawing.Size(457, 227);
            this.biletAlPanel.TabIndex = 5;
            this.biletAlPanel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(152, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Bagaj Ağırlığı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(35, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Bagaj Türü";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.IndianRed;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Bagaj Özellikleri";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 16;
            // 
            // comboBox4
            // 
            this.comboBox4.AutoCompleteCustomSource.AddRange(new string[] {
            "Valiz",
            "Çanta",
            "Poşet"});
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Valiz",
            "Çanta",
            "Poşet",
            "Kutu"});
            this.comboBox4.Location = new System.Drawing.Point(15, 162);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(129, 24);
            this.comboBox4.TabIndex = 15;
            // 
            // biletOlusturButton
            // 
            this.biletOlusturButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletOlusturButton.Location = new System.Drawing.Point(256, 157);
            this.biletOlusturButton.Name = "biletOlusturButton";
            this.biletOlusturButton.Size = new System.Drawing.Size(142, 31);
            this.biletOlusturButton.TabIndex = 14;
            this.biletOlusturButton.Text = "Bilet Oluştur";
            this.biletOlusturButton.UseVisualStyleBackColor = true;
            this.biletOlusturButton.Click += new System.EventHandler(this.biletOlusturButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(176, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Koltuk No";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(298, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bilet Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(266, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Uçuş Seçiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yolcu Seçiniz";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Ekonomi",
            "VIP"});
            this.comboBox3.Location = new System.Drawing.Point(269, 89);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(129, 24);
            this.comboBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(220, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // yolcularcomboBox
            // 
            this.yolcularcomboBox.FormattingEnabled = true;
            this.yolcularcomboBox.Location = new System.Drawing.Point(14, 37);
            this.yolcularcomboBox.Name = "yolcularcomboBox";
            this.yolcularcomboBox.Size = new System.Drawing.Size(178, 24);
            this.yolcularcomboBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 189);
            this.dataGridView1.TabIndex = 6;
            // 
            // veriPanel
            // 
            this.veriPanel.BackColor = System.Drawing.Color.Transparent;
            this.veriPanel.Controls.Add(this.dataGridView1);
            this.veriPanel.Location = new System.Drawing.Point(178, 96);
            this.veriPanel.Name = "veriPanel";
            this.veriPanel.Size = new System.Drawing.Size(664, 198);
            this.veriPanel.TabIndex = 7;
            this.veriPanel.Visible = false;
            // 
            // GisePaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.plane_desktop_yms31u8wyuke7ari;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 433);
            this.Controls.Add(this.biletAlPanel);
            this.Controls.Add(this.veriPanel);
            this.Controls.Add(this.yolcuPanel);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.GosterButton);
            this.Controls.Add(this.biletEkleButton);
            this.Controls.Add(this.yolcuEkleButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GisePaneli";
            this.Text = "Bilet Olustur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GisePaneli_FormClosing);
            this.yolcuPanel.ResumeLayout(false);
            this.yolcuPanel.PerformLayout();
            this.biletAlPanel.ResumeLayout(false);
            this.biletAlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.veriPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yolcuEkleButton;
        private System.Windows.Forms.Button biletEkleButton;
        private System.Windows.Forms.Button GosterButton;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.Panel yolcuPanel;
        private System.Windows.Forms.Button ekle1Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox soyIsimTextBox;
        private System.Windows.Forms.TextBox isimTextBox;
        private System.Windows.Forms.Panel biletAlPanel;
        private System.Windows.Forms.ComboBox yolcularcomboBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button biletOlusturButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel veriPanel;
    }
}