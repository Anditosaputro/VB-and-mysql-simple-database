using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace Latihan_CRUD2
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = new MySqlConnection("server=localhost;database=kontak;uid=root;password=;SslMode=none");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            LoadData();
            koneksi.Close();
        }
        public void LoadData()
        {
            //inisisalisasi mysqlcommand
            MySqlCommand command;
            command = koneksi.CreateCommand();

            //ambil data dari kontak query
            command.CommandText = "select * from kontak";

            //masukkan data ke DataGrid
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridKontak.DataSource = dataset.Tables[0].DefaultView;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            //buka koneksi
            koneksi.Open();

            //inisialisasi mysqlcommand
            MySqlCommand command;
            command = koneksi.CreateCommand();

            //input data query
            command.CommandText = "INSERT INTO kontak (nama,instansi,telepon,seluler,alamat) VALUES (@nama,@instansi,@telepon,@seluler,@alamat);";

            //tambah parameter
            command.Parameters.AddWithValue("@nama", textNama.Text);
            command.Parameters.AddWithValue("@instansi", textBInstansi.Text);
            command.Parameters.AddWithValue("@telepon", textTelepon.Text);
            command.Parameters.AddWithValue("@seluler", textSeluler.Text);
            command.Parameters.AddWithValue("@alamat", richTextAlamat.Text);

            // memunculkan messagebox
            MessageBox.Show("data berhasil disimpan");

            //eksekusi query
            command.ExecuteNonQuery();

            //kosongkan form
            textNama.Clear();
            textBInstansi.Clear();
            textTelepon.Clear();
            textSeluler.Clear();
            richTextAlamat.Clear();

            //load data
            LoadData();

            //tutupkoneksi
            koneksi.Close();

        }
    }
}
