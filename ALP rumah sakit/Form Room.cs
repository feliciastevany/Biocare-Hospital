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
using System.Xml.Linq;

namespace ALP_rumah_sakit
{
    public partial class Form_Room : Form
    {
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;
        MySqlDataReader mysqlreader;
        DataTable dtcbx = new DataTable();
        DataTable dtRoom = new DataTable();
        string connection;
        string sqlQuery;
        public Form_Room()
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

        private void Form_Room_Load(object sender, EventArgs e)
        {
            dtcbx.Clear();
            sqlQuery = $"SELECT concat('lantai', k.lantai) as lantai\r\nFROM kamar k\r\nWHERE k.lantai group by k.lantai";
            mysqlconnection = new MySqlConnection(connection);
            mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
            mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
            mysqldataadapter.Fill(dtcbx);
            comboBoxChoose.DataSource = dtcbx;
            comboBoxChoose.ValueMember = "lantai";
            comboBoxChoose.DisplayMember = "lantai";
        }

        private void comboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtRoom.Clear();
            string lantai = comboBoxChoose.SelectedValue.ToString();
            sqlQuery = $"SELECT k.no_kamar as 'No. Kamar', p1.nama_pasien as 'Nama pasien', p2.nama_perawat as 'Perawat'\r\nFROM pasien p1, kamar k, nota n, perawat p2\r\nWHERE n.id_pasien = p1.id_pasien\r\nand n.id_kamar = k.id_kamar\r\nand n.id_perawat = p2.id_perawat and concat('lantai', k.lantai) = '{lantai}' order by 1 asc ;";
            mysqlconnection = new MySqlConnection(connection);
            mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
            mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
            mysqldataadapter.Fill(dtRoom);
            dataGridViewRoom.DataSource = dtRoom;

        }

        private void dataGridViewNurse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
