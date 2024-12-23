using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GisePaneli : Form
    {
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=147147;Database=HavayoluFirmasi";
        Form1 form;
        int personelID;
        ArrayList yolcuIdDizi = new ArrayList();
        ArrayList ucusIdDizi = new ArrayList();

        public GisePaneli(int personelID1,Form1 form1)
        {
            InitializeComponent();

            this.personelID = personelID1;
            form = form1;
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void yolcuEkleButton_Click(object sender, EventArgs e)
        {
            yolcuPanel.Visible = true;
            biletAlPanel.Visible = false;
            veriPanel.Visible = false;

            
        }

        private void ekle1Button_Click(object sender, EventArgs e)
        {

            if (isimTextBox.Text != "" && soyIsimTextBox.Text != "" && emailTextBox.Text != "" && telefonTextBox.Text != "")
            {

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO yolcular (isim, soy_isim, e_mail, telefon) VALUES (@isim, @soy_isim, @e_mail, @telefon)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@isim", isimTextBox.Text);
                        command.Parameters.AddWithValue("@soy_isim", soyIsimTextBox.Text);
                        command.Parameters.AddWithValue("@e_mail", emailTextBox.Text);
                        command.Parameters.AddWithValue("@telefon", telefonTextBox.Text);

                        command.ExecuteNonQuery();


                    }
                }

                yolcuPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Hiç bir alan boş bırakılamaz");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void biletEkleButton_Click(object sender, EventArgs e)
        {
            veriPanel.Visible = false;
            yolcuPanel.Visible=false;
            biletAlPanel.Visible=true;
            
            
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT * FROM yolcular", connection))
                {

                    using (var reader = command.ExecuteReader())
                    {
                        yolcuIdDizi.Clear();
                        yolcularcomboBox.Items.Clear();

                        while (reader.Read())
                        {
                            yolcularcomboBox.Items.Add(reader["isim"].ToString()+" "+ reader["soy_isim"].ToString());


                            yolcuIdDizi.Add(Convert.ToInt32(reader["yolcu_id"]));
                            

                        }

                    }
                }

            }



            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT \r\n    u.ucus_id,\r\n    u.kalkis_gunu,\r\n    u.durum,\r\n    kalkis_h.sehir AS kalkis_sehri,\r\n    varis_h.sehir AS varis_sehri\r\nFROM \r\n    ucuslar u\r\nINNER JOIN \r\n    rota r ON u.rota_id = r.rota_id\r\nINNER JOIN \r\n    havaalanlari kalkis_h ON r.kalkis_ha_id = kalkis_h.hava_alani_id\r\nINNER JOIN \r\n    havaalanlari varis_h ON r.varis_ha_id = varis_h.hava_alani_id;\r\n", connection))
                {

                    using (var reader = command.ExecuteReader())
                    {

                        comboBox2.Items.Clear();
                        ucusIdDizi.Clear();

                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader["kalkis_sehri"].ToString() + "-" + reader["varis_sehri"].ToString());


                            ucusIdDizi.Add(Convert.ToInt32(reader["ucus_id"]));


                        }

                    }
                }

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void biletOlusturButton_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO biletler (yolcu_id, bagaj_id, ucus_id, koltuk_no, kesim_tarihi, fiyat, tur, gise_sorumlusu_id) VALUES (@yolcu_id, ekle_bagaj(\'"+textBox3.Text+" \',\'"+comboBox4.SelectedItem+"\')"+", @ucus_id, @koltuk_no, @kesim_tarihi, @fiyat, @tur, @gise_sorumlusu_id)";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@yolcu_id", yolcuIdDizi[yolcularcomboBox.SelectedIndex]);
                    command.Parameters.AddWithValue("@ucus_id", ucusIdDizi[comboBox2.SelectedIndex]);
                    command.Parameters.AddWithValue("@koltuk_no", Convert.ToInt32(textBox1.Text));
                    command.Parameters.AddWithValue("@kesim_tarihi", DateTime.Now);
                    command.Parameters.AddWithValue("@fiyat", Convert.ToInt32(textBox2.Text));
                    command.Parameters.AddWithValue("@tur", comboBox3.SelectedItem);
                    command.Parameters.AddWithValue("@gise_sorumlusu_id", personelID);

                    command.ExecuteNonQuery();


                }
            }
        }

        private void GosterButton_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();



            try
            {

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand("SELECT * FROM get_bilet_bilgileri()", connection))
                    {

                        using (var adapter = new NpgsqlDataAdapter(command))
                        {

                            adapter.Fill(table);
                            dataGridView1.DataSource = table;

                        }
                    }

                }
            }

            catch
            {

                MessageBox.Show("Veri Tabanina Baglanmadi", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





            veriPanel.Visible = true;
            biletAlPanel.Visible = false;
            yolcuPanel.Visible = false;
        }

        private void GisePaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }
    }
}
