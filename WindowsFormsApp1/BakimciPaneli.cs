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
    public partial class BakimciPaneli : Form



    {


        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=147147;Database=HavayoluFirmasi";

        Form1 form1;
        int personelID;
        ArrayList ucakDizi = new ArrayList();
        public BakimciPaneli(Form1 form, int personelID )
        {
            InitializeComponent();
            form1 = form;

            this.personelID = personelID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void geri_Button_Click(object sender, EventArgs e)
        {

            this.Close();
            form1.Show();

            
        }

        private void kayit_Button_Click(object sender, EventArgs e)
        {
            

            DataTable table = new DataTable();
            
            

            try
            {

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand("SELECT * FROM get_bakim_bilgileri();", connection))
                    {

                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            
                            adapter.Fill(table);
                            kayitlar.DataSource = table;

                        }
                    }

                }
            }

            catch {

                MessageBox.Show("Veri Tabanina Baglanmadi","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


               

            ekle.Visible = false;
            kayitlar.Visible=true;
        }

        private void bakim_Button_Click(object sender, EventArgs e)
        {


            ucaklar.Items.Clear();
            ucakDizi.Clear();
            

            DataTable table = new DataTable();



            try
            {

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand("SELECT * FROM ucaklar", connection))
                    {
                        
                        using (var reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                ucakDizi.Add(reader["ucak_id"]);
                                ucaklar.Items.Add(reader["ucak_adi"].ToString());
                            }

                        }
                    }

                }
            }

            catch
            {

                MessageBox.Show("Veri Tabanina Baglanmadi", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            




            kayitlar.Visible = false;
            ekle.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO bakimkayitlari (ucak_id, bakimci_id, aciklama, bakim_tarihi) VALUES (@ucak_id, @bakimci_id, @aciklama, @bakim_tarihi)";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@ucak_id", ucakDizi[ucaklar.SelectedIndex]);
                    command.Parameters.AddWithValue("@bakimci_id", personelID);
                    command.Parameters.AddWithValue("@aciklama", bakimAciklama.Text);
                    command.Parameters.AddWithValue("@bakim_tarihi", dateTimePicker1.Value);

                    command.ExecuteNonQuery();
                }
            }
            ekle.Visible = false;


        }
    }
}
