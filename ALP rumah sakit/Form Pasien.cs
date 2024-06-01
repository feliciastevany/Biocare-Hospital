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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ALP_rumah_sakit
{
    public partial class Form_Pasien : Form
    {
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;

        DataTable dtpasien1 = new DataTable();
        DataTable dtpasien2 = new DataTable();
        string connection;
        string sqlQuery;
        public Form_Pasien()
        {
            try
            {
                connection = "server=localhost;uid=root;pwd=Apakau123;database=biocare";
                mysqlconnection = new MySqlConnection(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
        }

        private void Form_Pasien_Load(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "select concat(id_pasien,' - ',nama_pasien) as IDName from pasien";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtpasien1);
                cbxName.DataSource = dtpasien1;
                cbxName.ValueMember = "IDName";
                cbxName.DisplayMember = "IDName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dtpasien2.Clear();
                string namepasien = cbxName.SelectedValue.ToString();
                sqlQuery = $"select p.nama_pasien Nama,p.alamat Alamat,p.kota Kota,p.notelf Tlp,p.gender Gender,pj.nama_PJ Nama_PJ,d.nama_dokter Dokter,n.id_nota No_Nota from pasien p inner join nota n on n.id_pasien = p.id_pasien inner join penanggung_jawab pj on pj.id_penanggungJawab = p.id_penanggungJawab inner join dokter d on d.id_dokter = n.id_dokter and concat(p.id_pasien, ' - ', p.nama_pasien) = '{namepasien}';";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                
                mysqldataadapter.Fill(dtpasien2);
                dgvPasien.DataSource = dtpasien2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            try
            {
                string namepasien = cbxName.SelectedValue.ToString();
                sqlQuery = $"select p.nama_pasien Nama,p.alamat Alamat,p.kota Kota,p.notelf Tlp,p.gender Gender,pj.nama_PJ Nama_PJ,d.nama_dokter Dokter,n.id_nota No_Nota from pasien p inner join nota n on n.id_pasien = p.id_pasien inner join penanggung_jawab pj on pj.id_penanggungJawab = p.id_penanggungJawab inner join dokter d on d.id_dokter = n.id_dokter;";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                dtpasien2.Clear();
                mysqldataadapter.Fill(dtpasien2);
                dgvPasien.DataSource = dtpasien2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}