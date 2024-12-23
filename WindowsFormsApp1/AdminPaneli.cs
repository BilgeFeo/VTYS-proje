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
    public partial class AdminPaneli : Form
    {
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=147147;Database=HavayoluFirmasi";
        Form1 form;
        int personelID;
        ArrayList pilotIDler = new ArrayList();
        ArrayList gorevliIDler = new ArrayList();


        public AdminPaneli(int personelID, Form1 form)
        {
            InitializeComponent();
            this.personelID = personelID;
            this.form = form;
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void AdminPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();

        }

        private void pGuncelleButton_Click(object sender, EventArgs e)
        {
            pilotPanel.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT personel_id, isim, soy_isim FROM personel WHERE tur like 'Pilot';", connection))
                {

                    using (var reader = command.ExecuteReader())
                    {
                        
                        pilotlar.Items.Clear();
                        pilotIDler.Clear();

                        while (reader.Read())
                        {

                            pilotIDler.Add(reader["personel_id"]);
                            pilotlar.Items.Add(reader["isim"].ToString() + " " + reader["soy_isim"].ToString());


                            


                        }

                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pilotPanel.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("SELECT personel_id, isim, soy_isim FROM personel WHERE tur like 'Kabin Gorevlisi';", connection))
                {

                    using (var reader = command.ExecuteReader())
                    {

                        gorevliler.Items.Clear();
                        gorevliIDler.Clear();

                        while (reader.Read())
                        {

                            gorevliIDler.Add(reader["personel_id"]);
                            gorevliler.Items.Add(reader["isim"].ToString() + " " + reader["soy_isim"].ToString());





                        }

                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("UPDATE pilot SET maas = " +Convert.ToInt32(pilotMaasText.Text)+ " WHERE personel_id = " + pilotIDler[pilotlar.SelectedIndex]+";", connection))
                {


                    command.ExecuteNonQuery();

                     
                    
                }

            }


            pilotPanel.Visible = false;
            panel1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pilotPanel.Visible = false;
            panel1.Visible = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("UPDATE kabingorevlisi SET maas = " + Convert.ToInt32(gorevliMaasText.Text) + " WHERE personel_id = " + gorevliIDler[gorevliler.SelectedIndex] + ";", connection))
                {


                    command.ExecuteNonQuery();



                }

            }


        }

        private void silButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible=false;
            pilotPanel.Visible=false;
            dataGridView1.Visible=true;

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
                            dataGridView1.DataSource = table;

                        }
                    }

                }
            }

            catch
            {

                MessageBox.Show("Veri Tabanina Baglanmadi", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            pilotPanel.Visible = false;


            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand("DELETE FROM bakimkayitlari WHERE bakim_id = "+ dataGridView1.CurrentRow.Cells["kayit"].Value + ";", connection))
                {


                    command.ExecuteNonQuery();



                }

            }



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
                            dataGridView1.DataSource = table;

                        }
                    }

                }
            }

            catch
            {

                MessageBox.Show("Veri Tabanina Baglanmadi", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
