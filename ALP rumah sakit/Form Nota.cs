using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ALP_rumah_sakit
{
    public partial class Form_Nota : Form
    {
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;
          MySqlDataReader reader;

        DataTable dtlabel = new DataTable();
        DataTable dtcbx = new DataTable();
        DataTable dgv = new DataTable();
        DataTable dttotal = new DataTable();
        string connection;
        string sqlQuery;
        public Form_Nota()
        {
            connection = "server=localhost;uid=root;pwd=Apakau123;database=biocare";
            try
            {
                mysqlconnection = new MySqlConnection(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
        }
        public static string namapas, dob, address, notelp, namadoc, namepas, idpasien, datenota, idinvoice, taxx, totall;

        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = $"UPDATE nota set paid = '1' where id_pasien = '{cbxnamaPasien.SelectedValue.ToString()}'";
                mysqlconnection = new MySqlConnection(connection);
                mysqlconnection.Open();
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                reader = mysqlcommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                dtcbx.Clear();
                sqlQuery = $"SELECT p.id_pasien, p.nama_pasien FROM pasien p, nota n where n.id_pasien = p.id_pasien and n.paid = 0;";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtcbx);
                cbxnamaPasien.DataSource = dtcbx;
                cbxnamaPasien.DisplayMember = "nama_pasien";
                cbxnamaPasien.ValueMember = "id_pasien";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        public static int subtotal, tottax, total;
        private void buttonPrint_Click_1(object sender, EventArgs e)
        {
            Form_Bill bill = new Form_Bill();

            bill.Show();
        }

        private void cbxnamaPasien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int hah = 0;

            try
            {
                dtlabel.Clear();
                sqlQuery = $"SELECT p.id_pasien, p.nama_pasien, date_format(p.tgl_lhr, '%d %M %Y'), concat(p.alamat, \", \", p.kota), p.notelf, d.nama_dokter, n.total, n.id_nota\r\nFROM pasien p, nota n, dokter d\r\nwhere p.id_pasien = n.id_pasien\r\nand d.id_dokter = n.id_dokter\r\nand n.id_pasien = '{cbxnamaPasien.SelectedValue.ToString()}'\r\n;";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtlabel);

                namepas = dtlabel.Rows[0][1].ToString();

                dgv.Clear();
                sqlQuery = $"SELECT o.id_obat as 'ID Obat', o.nama_obat as 'Nama Obat', u.qty as 'qty', concat('Rp ',o.hargaPerBiji) as 'Harga'\r\nFROM useobat u, obat o, nota n\r\nwhere o.id_obat = u.id_obat\r\nand n.id_useobat = u.id_useobat\r\nand n.id_pasien = '{cbxnamaPasien.SelectedValue.ToString()}'\r\n;";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dgv);
                dataharga.DataSource = dgv;

                dttotal.Clear();
                sqlQuery = $"SELECT o.id_obat as 'ID Obat', o.nama_obat as 'Nama Obat', u.qty as 'qty', o.hargaPerBiji as 'Harga'\r\nFROM useobat u, obat o, nota n\r\nwhere o.id_obat = u.id_obat\r\nand n.id_nota = u.id_nota\r\nand n.id_pasien = '{cbxnamaPasien.SelectedValue.ToString()}'\r\n;";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dttotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            idpas.Text = dtlabel.Rows[0][0].ToString();
            tanggallahir.Text = dtlabel.Rows[0][2].ToString();
            alamatpas.Text = dtlabel.Rows[0][3].ToString();
            notelppas.Text = dtlabel.Rows[0][4].ToString();
            namadokter.Text = dtlabel.Rows[0][5].ToString();
            idnota.Text = dtlabel.Rows[0][7].ToString();
            namapas = cbxnamaPasien.SelectedValue.ToString(); //ganti id

            idpasien = idpas.Text;
            dob = tanggallahir.Text;
            address = alamatpas.Text;
            notelp = notelppas.Text;
            namadoc = namadokter.Text;
            date.Text = DateTime.Now.ToString();
            datenota = date.Text;
            idinvoice = idnota.Text;

            List<int> qtys = new List<int>();
            List<int> hargas = new List<int>();

            foreach (DataRow row in dttotal.Rows)
            {
                int qty = Convert.ToInt32(row["qty"].ToString());
                qtys.Add(qty);

                int harga = Convert.ToInt32(row["Harga"].ToString());
                hargas.Add(harga);
            }

            for (int i = 0; i < qtys.Count; i++)
            {
                hah += qtys[i] * hargas[i];
            }

            lblsub.Text = "Rp " + hah.ToString();
            subtotal =  hah;
            tottax = subtotal*10/100;
            total = subtotal + tottax;

            lbltax.Text = "Rp " + tottax.ToString();
            lbltotal.Text = "Rp " + total.ToString();
           
            taxx = lbltax.Text;
            totall = lbltotal.Text;
        }
        private void Form_Nota_Load(object sender, EventArgs e)
        {
            try
            {
                dtcbx.Clear();
                sqlQuery = $"SELECT p.id_pasien, p.nama_pasien FROM pasien p, nota n where n.id_pasien = p.id_pasien and n.paid = 0;";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtcbx);
                cbxnamaPasien.DataSource = dtcbx;
                cbxnamaPasien.DisplayMember = "nama_pasien";
                cbxnamaPasien.ValueMember = "id_pasien";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
