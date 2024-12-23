using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace WindowsFormsApp1
{





    public partial class Form1 : Form
    {

        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=147147;Database=HavayoluFirmasi";

        public Form1()
        {
            InitializeComponent();

           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
             


            try
            {

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand("SELECT * FROM mudur", connection))
                    {

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (kullaniciAdi_textBox.Text == reader["kullanici_adi"].ToString() && sifre_textBox.Text == reader["sifre"].ToString())
                                {
                                    AdminPaneli adminPaneli= new AdminPaneli(Convert.ToInt32(reader["personel_id"]), this);
                                    adminPaneli.Show(); 
                                    this.Hide();
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Veri Tabani Okunamadi!!","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                            }
                        }
                    }

                }


                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand("SELECT * FROM public.gisesorumlusu ", connection))
                    {

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (kullaniciAdi_textBox.Text == reader["kullanici_adi"].ToString() && sifre_textBox.Text == reader["sifre"].ToString())
                                {
                                    GisePaneli gisePAneli = new GisePaneli(Convert.ToInt32(reader["personel_id"]),this);
                                    gisePAneli.Show();
                                    this.Hide();
                                    
                                }

                            }
                            else
                            {
                                MessageBox.Show("Veri Tabani Okunamadi!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand("SELECT * FROM public.bakimci ", connection))
                    {

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (kullaniciAdi_textBox.Text == reader["kullanici_adi"].ToString() && sifre_textBox.Text == reader["sifre"].ToString())
                                {
                                    BakimciPaneli bakimciPaneli = new BakimciPaneli(this,Convert.ToInt32( reader["personel_id"]));
                                    bakimciPaneli.Show();
                                    this.Hide();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Veri Tabani Okunamadi!!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }


        }

        private void cikis_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
