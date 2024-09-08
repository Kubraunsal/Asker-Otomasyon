using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asker
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=LAPTOP-VBT65R4T;Initial Catalog=AskeriPersonel;Integrated Security=True");
        }
        void AskerGetir()
        {
            baglanti = new SqlConnection(@"Data Source=LAPTOP-VBT65R4T;Initial Catalog=AskeriPersonel;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM AskeriPersonel", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'askeriPersonelDataSet.AskeriPersonel' table. You can move, or remove it, as needed.
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string adSoyad = textBox1.Text;
            string otherValue = textBox1.Text;
            baglanti.Open();
            komut = new SqlCommand("INSERT INTO AskeriPersonel (AdSoyad) VALUES (@adSoyad)", baglanti);
            komut.Parameters.AddWithValue("@adSoyad", adSoyad);
            komut.ExecuteNonQuery();
            baglanti.Close();
            AskerGetir();

            // Update DataGridView

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string adSoyadToDelete = textBox1.Text;

            if (!string.IsNullOrEmpty(adSoyadToDelete))
            {
                baglanti.Open();

                komut = new SqlCommand("DELETE FROM AskeriPersonel WHERE AdSoyad = @adSoyad", baglanti);
                komut.Parameters.AddWithValue("@adSoyad", adSoyadToDelete);
                komut.ExecuteNonQuery();

                baglanti.Close();
                
            }
            else
            {
                MessageBox.Show("Please enter AdSoyad to delete.");
            }
            AskerGetir();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            {
                string newAdSoyad = textBox1.Text; // Assuming the TextBox contains the new AdSoyad value

                if (!string.IsNullOrEmpty(newAdSoyad))
                {
                    baglanti.Open();

                    // Update the record in the database
                    komut = new SqlCommand("UPDATE AskeriPersonel SET AdSoyad = @newAdSoyad WHERE AdSoyad = @currentAdSoyad", baglanti);
                    komut.Parameters.AddWithValue("@newAdSoyad", newAdSoyad);
                    komut.Parameters.AddWithValue("@currentAdSoyad", newAdSoyad); // Since you only have one TextBox, you can use the same value for both
                    komut.ExecuteNonQuery();

                    baglanti.Close();
                   
                }
                else
                {
                    MessageBox.Show("Please enter a new AdSoyad value to update.");
                }
                AskerGetir();
            }

        }
        private void button4_Click_1(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
        }

        //private void button5_Click_1(object sender, EventArgs e)
        //{

        //    Form2 form2 = new Form2();
        //    form2.Show();

        //    this.Hide();
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

