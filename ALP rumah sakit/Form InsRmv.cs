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
    public partial class Form_InsRmv : Form
    {
        public Form_InsRmv()
        {
            InitializeComponent();
            cbLoader();
            cbJnsKmr.DropDownStyle = ComboBoxStyle.DropDownList;
            cbhub.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDokter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbalatkelamin.DropDownStyle = ComboBoxStyle.DropDownList;
            txtnotelp.KeyPress += txtnotelp_KeyPress;
            txtnopj.KeyPress += txtnotelp_KeyPress;
        }
        string strconn = "server=localhost;uid=root;pwd=Apakau123;database=biocare";
        string query;

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;

        DataTable dt;

        string newidpasien;
        string newidpj;
        string newnokamar;
        string newidnota;
        string idperawat;
        public void cbLoader()
        {
            dt = new DataTable();

            query = "SELECT d.id_dokter as 'id', d.nama_dokter as 'nat' FROM dokter d where d.`remove` = 0;";
            try
            {
                conn = new MySqlConnection(strconn);
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                cbDokter.DataSource = dt;
                cbDokter.ValueMember = "id";
                cbDokter.DisplayMember = "nat";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cbDokter.SelectedItem = "";
            cbDokter.SelectedValue = "";

            dt = new DataTable();

            query = "select id_jenis, nama_jenis from jenis_kamar";
            try
            {
                conn = new MySqlConnection(strconn);
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                cbJnsKmr.DataSource = dt;
                cbJnsKmr.ValueMember = "id_jenis";
                cbJnsKmr.DisplayMember = "nama_jenis";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cbJnsKmr.SelectedItem = "";
            cbJnsKmr.SelectedValue = "";

            dt = new DataTable();

            query = "select hubungan from penanggung_jawab group by 1 order by 1";
            try
            {
                conn = new MySqlConnection(strconn);
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                cbhub.DataSource = dt;
                cbhub.ValueMember = "hubungan";
                cbhub.DisplayMember = "hubungan";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cbhub.SelectedItem = "";
            cbhub.SelectedValue = "";

            cbalatkelamin.Items.Add("Male");
            cbalatkelamin.Items.Add("Female");
        }

        public void dgvloader()
        {
            dt = new DataTable();

            query = "SELECT p.id_pasien as 'idpasien', k.no_kamar as 'No. Kamar', p.nama_pasien as 'Pasien', j.nama_PJ as 'Penanggung Jawab', d.nama_dokter as 'Dokter' FROM pasien p, kamar k, penanggung_jawab j, dokter d, nota n WHERE n.id_pasien = p.id_pasien and n.id_kamar = k.id_kamar and n.id_dokter = d.id_dokter and j.id_penanggungJawab = p.id_penanggungJawab and p.`remove` = '0';";
            try
            {
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

            dataGridView1.Columns["idpasien"].Visible = false;
        }

        public void removepasien(string idpasien, string nokamar)
        {
            query = $"update pasien set `remove` = '1' where id_pasien = '{idpasien}'";
            try
            {
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

            query = $"update kamar set available = 'Y' where id_kamar = '{nokamar}'";
            try
            {
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

        public void generateidpasien()
        {

            dt = new DataTable();

            query = "SELECT p.id_pasien FROM pasien p order by 1;";
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
                string idpasien = row["id_pasien"].ToString();
                listid.Add(idpasien);
            }

            lastid = listid[listid.Count - 1];
            depan = lastid.Substring(0, 1);
            id = Convert.ToInt32(lastid.Substring(1, lastid.Length - 1)) + 1;


            for (int i = 0; i < (lastid.Length) - (id.ToString().Length) - 1; i++)
            {
                zero += "0";
            }

            newidpasien = depan + zero + id;
        }

        public void generateidpj()
        {
            dt = new DataTable();

            query = "SELECT p.id_penanggungjawab as 'idpj' FROM penanggung_jawab p;";
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
                string idpj = row["idpj"].ToString();
                listid.Add(idpj);
            }

            lastid = listid[listid.Count - 1];
            depan = lastid.Substring(0, 1);
            id = Convert.ToInt32(lastid.Substring(1, lastid.Length - 1)) + 1;


            for (int i = 0; i < (lastid.Length) - (id.ToString().Length) - 1; i++)
            {
                zero += "0";
            }

            newidpj = depan + zero + id;
        }

        public void generateidkamar(string idjenis)
        {
            dt = new DataTable();

            query = $"select id_kamar from kamar where id_jenis = '{idjenis}' and available = 'Y' limit 1";
            try
            {
                conn = new MySqlConnection(strconn);
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);
                newnokamar = dt.Rows[0]["id_kamar"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            if (newnokamar == null)
            {
                MessageBox.Show("All Room With This Type Already Full. Please Select For Another Room");
                cbJnsKmr.SelectedIndex = -1;
                return;
            }
        }
        public void generateidperawat(string lantai)
        {

            dt = new DataTable();

            query = $"select id_perawat from perawat where id_perawat like '{lantai}%'order by 1";
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
                string idkamar = row["id_perawat"].ToString();
                listid.Add(idkamar);
            }

            lastid = listid[listid.Count - 1];
            depan = lastid.Substring(0, 1);
            Random random = new Random();
            id = random.Next(1, Convert.ToInt32(lastid.Substring(1, lastid.Length - 1)));


            for (int i = 0; i < (lastid.Length) - (id.ToString().Length) - 1; i++)
            {
                zero += "0";
            }

            idperawat = depan + zero + id;
        }
        public void generateidnota()
        {
            dt = new DataTable();

            query = $"select id_nota from nota order by 1";
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
                string idnota = row["id_nota"].ToString();
                listid.Add(idnota);
            }

            lastid = listid[listid.Count - 1];
            depan = lastid.Substring(0, 1);
            id = Convert.ToInt32(lastid.Substring(1, lastid.Length - 1)) + 1;


            for (int i = 0; i < (lastid.Length) - (id.ToString().Length) - 1; i++)
            {
                zero += "0";
            }

            newidnota = depan + zero + id;
        }
        private string generateiduseobat(string nokamar)
        {
            dt = new DataTable();

            query = $"select id_useobat, no_kamar from nota join kamar on kamar.id_kamar = nota.id_kamar order by 1 desc limit 1";
            conn = new MySqlConnection(strconn);
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(dt);


            string value = dt.Rows[0]["id_useobat"].ToString();
            string substring = value.Substring(1, 4);


            dt = new DataTable();

            query = $"select no_kamar from kamar where id_kamar = '{nokamar}'";
            conn = new MySqlConnection(strconn);
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(dt);

            string newid;
            string depan;
            string zero = "";
            string id;

            int number;

            depan = value.Substring(0, 1);

            number = Convert.ToUInt16(substring) + 1;

            id = dt.Rows[0]["no_kamar"].ToString();


            for (int i = 0; i <= (substring.Length) - (number.ToString().Length) - 1; i++)
            {
                zero += "0";
            }

            newid = depan + zero + number + id;

            return newid;
        }
        public bool insertpasien(string namapasien, string namapj, string tgllahir, string kelamin, string alamat, string kota, string notelp, string iddokter, string notelppj, string hub, string tglmsk, string tglkeluar, string idjenis)
        {
            bool ok = false;
            generateidpasien();
            generateidpj();
            generateidkamar(idjenis);
            if (newnokamar != null)
            {
                generateidnota();
                generateidperawat(newnokamar.Substring(0, 1));
                string newiduseobat = generateiduseobat(newnokamar);

                query = $"INSERT INTO pasien VALUES ('{newidpasien}', '{namapasien}', '{tgllahir}', '{alamat}', '{kota}', '{notelp}', '{newidpj}', '{kelamin}', '0')";
                try
                {
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

                query = $"INSERT INTO penanggung_jawab VALUES ('{newidpj}', '{namapj}', '{notelppj}', '{hub}')";
                try
                {
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

                query = $"INSERT INTO nota VALUES ('{newidnota}', '{newidpasien}', '{iddokter}', '{newnokamar}', '{idperawat}', '{newiduseobat}', '{tglmsk}', '{tglkeluar}', '0', '0')";
                try
                {
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

                query = $"update kamar set available = 'N' where id_kamar = '{newnokamar}'";
                try
                {
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

                //MessageBox.Show("Pasien Berhasil di Input");
                ok = true;

            }
            else
            {
                ok = false;
            }
            return ok;
        }
        private void Form_InsRmv_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.TopLevel = false;

            panelremove.Visible = false;
            panel1.Visible = false;
        }
        private void txtnotelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (dtptgllahir.Value.ToString() == "" && dtptglmsk.Value.ToString() == "" && dtptglkluar.Value.ToString() == "" && txtnamapasien.Text == "" && txtnamapj.Text == "" && txtnotelp.Text == "" && txtalamat.Text == "" && cbalatkelamin.SelectedValue.ToString() == "" && cbDokter.SelectedValue.ToString() == "" && txtkota.Text == "" && cbJnsKmr.SelectedValue.ToString() == "" && txtnopj.Text == "" && cbhub.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                string tgllahir = dtptgllahir.Value.ToString("yyyy-MM-dd");
                string tglmasuk = dtptglmsk.Value.ToString("yyyy-MM-dd");
                string tglkeluar = dtptglkluar.Value.ToString("yyyy-MM-dd");

                string namapasien = txtnamapasien.Text.ToString();
                string namapj = txtnamapj.Text.ToString();
                string notelp = txtnotelp.Text.ToString();
                string alamat = txtalamat.Text.ToString();
                string kelamin = cbalatkelamin.Text.ToString().Substring(0, 1);
                string dokter = cbDokter.SelectedValue.ToString();
                string kota = txtkota.Text.ToString();
                string idjenis = cbJnsKmr.SelectedValue.ToString();
                string notelppj = txtnopj.Text.ToString();
                string hub = cbhub.Text.ToString();

                bool nice = insertpasien(namapasien, namapj, tgllahir, kelamin, alamat, kota, notelp, dokter, notelppj, hub, tglmasuk, tglkeluar, idjenis);
                if (nice == true)
                {
                    MessageBox.Show("Pasien Berhasil di Input");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 || dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                string selectedValue = selectedRow.Cells["idpasien"].Value.ToString();
                string nokamar = selectedRow.Cells["No. Kamar"].Value.ToString();

                dt = new DataTable();

                query = $"select id_kamar from kamar where no_kamar = '{nokamar}'";
                conn = new MySqlConnection(strconn);
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                newnokamar = dt.Rows[0]["id_kamar"].ToString();

                removepasien(selectedValue, newnokamar);

                dgvloader();

                MessageBox.Show("Pasien Sudah di Hapus", "Berhasil", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Pasien Yang Mau di Hapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panelremove.Visible = true;
            dgvloader();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
