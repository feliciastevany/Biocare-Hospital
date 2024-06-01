using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_rumah_sakit
{
    public partial class Form_InsDoct : Form
    {
        public Form_InsDoct()
        {
            InitializeComponent();
            cbLoader();
            cbalatkelamin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpecialis.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        string strconn = "server=localhost;uid=root;pwd=Apakau123;database=biocare";
        string query;

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;

        DataTable dt;

        string newiddokter;
        public void cbLoader()
        {
            dt = new DataTable();

            try
            {
                query = "SELECT d.id_dokter as 'id', d.speciality as 'nat' FROM dokter d where `remove` = '0';";
                conn = new MySqlConnection(strconn);
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                cbSpecialis.DataSource = dt;
                cbSpecialis.ValueMember = "id";
                cbSpecialis.DisplayMember = "nat";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cbSpecialis.SelectedIndex = -1;

            cbalatkelamin.Items.Add("Male");
            cbalatkelamin.Items.Add("Female");
        }

        public void dgvloader()
        {
            dt = new DataTable();

            try
            {
                query = "SELECT * FROM biocare.dokter where `remove` = '0';";
                conn = new MySqlConnection(strconn);
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridView1.Columns["id_dokter"].Visible = false;
            dataGridView1.Columns["remove"].Visible = false;
        }

        public void generateiddokter()
        {
            dt = new DataTable();

            query = $"select id_dokter from dokter order by 1";
            try
            {
                conn = new MySqlConnection(strconn);
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            List<string> listid = new List<string>();

            string lastid;
            string depan;
            string zero = "";

            int id;

            foreach (DataRow row in dt.Rows)
            {
                string iddokter = row["id_dokter"].ToString();
                listid.Add(iddokter);
            }

            lastid = listid[listid.Count - 1];
            depan = lastid.Substring(0, 1);
            id = Convert.ToInt32(lastid.Substring(1, lastid.Length - 1)) + 1;


            for (int i = 0; i < (lastid.Length) - (id.ToString().Length) - 1; i++)
            {
                zero += "0";
            }

            newiddokter = depan + zero + id;
        }

        public void removedokter(string iddokter)
        {
            try
            {
                query = $"update dokter set `remove` = '1' where id_dokter = '{iddokter}'";
                conn = new MySqlConnection(strconn);
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void insertdokter(string namadokter, string kelamin, string spesialis, string harga)
        {
            generateiddokter();
            try
            {
                query = $"INSERT INTO dokter values ('{newiddokter}', '{namadokter}', '{spesialis}', '{kelamin}', {harga}, '0');";
                conn = new MySqlConnection(strconn);
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            MessageBox.Show("Dokter Berhasil di Input");
        }

        private void Form_InsDoct_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.TopLevel = false;

            panel2.Visible = false;
            panel1.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtnamaDokter.Text == "" && cbalatkelamin.SelectedIndex != -1 && cbSpecialis.SelectedIndex != -1 && txtHarga.Text == "")
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                string namaperawat = txtnamaDokter.Text.ToString();
                string kelamin = cbalatkelamin.Text.ToString().Substring(0, 1);
                string spesialis = cbSpecialis.Text.ToString();
                string harga = txtHarga.Text.ToString();

                insertdokter(namaperawat, kelamin, spesialis, harga);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 || dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                string selectedValue = selectedRow.Cells["id_dokter"].Value.ToString();

                removedokter(selectedValue);

                dgvloader();

                MessageBox.Show("Dokter Sudah di Hapus", "Berhasil", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Dokter Yang Mau di Hapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inserttoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void removetoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dgvloader();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
