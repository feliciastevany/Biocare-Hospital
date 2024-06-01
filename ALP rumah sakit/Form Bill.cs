using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_rumah_sakit
{
    public partial class Form_Bill : Form
    {
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;

        DataTable dtlabel = new DataTable();
        DataTable dtcbx = new DataTable();
        DataTable dgv = new DataTable();
        DataTable dttotal = new DataTable();
        string connection;
        string sqlQuery;
        public Form_Bill()
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

        private void Form_Bill_Load(object sender, EventArgs e)
        {
            labelNama.Text = Form_Nota.namepas;
            labelidpas.Text = Form_Nota.namapas;
            labelDOB.Text = Form_Nota.dob;
            labelAddress.Text = Form_Nota.address;
            labelNotelp.Text = Form_Nota.notelp;
            labelnamaDoc.Text = Form_Nota.namadoc;
            labeltgl.Text = Form_Nota.datenota;
            labelsubtotal.Text = Form_Nota.subtotal.ToString();
            labelInvoice.Text = Form_Nota.idinvoice;

            labeltax.Text = Form_Nota.taxx;
            labeltotal.Text = Form_Nota.totall;

            try
            {
                dgv.Clear();
                sqlQuery = $"SELECT o.id_obat as 'ID Obat', o.nama_obat as 'Nama Obat', u.qty as 'qty', concat('Rp ',o.hargaPerBiji) as 'Harga'\r\nFROM useobat u, obat o, nota n\r\nwhere o.id_obat = u.id_obat\r\nand n.id_useobat = u.id_useobat\r\nand n.id_pasien = '{Form_Nota.namapas}'\r\n;";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dgv);
                dataharga.DataSource = dgv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labeltgl_Click(object sender, EventArgs e)
        {

        }
    }
}
