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

    public partial class Form2 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
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
        public Form2()
        {

            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'askeriPersonelDataSet1.AskeriPersonel' table. You can move, or remove it, as needed.
            AskerGetir();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> askeriPersonelListesi = new List<string>();

            // DataGridView'dan gelen verileri liste içine ekleyin
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string yazi = "";
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (j == 0)
                    {
                        yazi = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        yazi += "x" + dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                AskerGetir();
                askeriPersonelListesi.Add(yazi);
            }

            // Fisher-Yates algoritmasını kullanarak listeyi karıştırın
            Random random = new Random();
            int n = askeriPersonelListesi.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string deger = askeriPersonelListesi[k];
                askeriPersonelListesi[k] = askeriPersonelListesi[n];
                askeriPersonelListesi[n] = deger;
            }

            // ListBox'lara karışık olarak atama yapın
            List<ListBox> gunListeleri = new List<ListBox>
    {
        lbxPzrtesi, lbxSalı, lbxCrşbma, lbxPrşmbe, lbxCuma, lbxCmartsi, lbxPazar
    };

            foreach (var listBox in gunListeleri)
            {
                listBox.Items.Clear();
            }

        int gunSayisi = gunListeleri.Count;
            for (int i = 0; i < askeriPersonelListesi.Count; i++)
            {
                gunListeleri[i % gunSayisi].Items.Add(askeriPersonelListesi[i]);
            }
            AskerGetir();
        }        
        private void Askeripersonel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void a_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

