using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ALP_rumah_sakit
{
    public partial class Form_History : Form
    {
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;

        DataTable dtHistory = new DataTable();
        string connection;
        string sqlQuery;
        public Form_History()
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

        private void dgv(string query, DataTable data)
        {
            data.Rows.Clear();
            data.Columns.Clear();
            mysqlcommand = new MySqlCommand(query, mysqlconnection);
            mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
            mysqldataadapter.Fill(data);
            dgvHistory.DataSource = data;
        }
        private void Form_History_Load(object sender, EventArgs e)
        {
            //string search = textBoxSearch.Text;
            //if (search == "")
            //{
            //    buttonSearch.Enabled = false;
            //}
            //else
            //{
            //    buttonSearch.Enabled = true;
            //}
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = $"SELECT n.id_nota as 'ID Nota', n.tgl_keluar as 'tgl pembayaran', n.id_useobat as 'ID Use Obat', p.nama_pasien as 'Nama Pasien', d.nama_dokter as 'Nama Dokter' \r\nFROM nota n, pasien p, dokter d\r\nWHERE paid = 1\r\nand p.id_pasien = n.id_pasien\r\nand d.id_dokter = n.id_dokter\r\n;";
                dgv(sqlQuery, dtHistory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search;
            search = textBoxSearch.Text;
            if (search == null)
            {
                MessageBox.Show("Please enter a valid name");
            }
            else
            {
                try
                {
                    sqlQuery = $"SELECT n.id_nota as 'ID Nota', n.tgl_keluar as 'tgl pembayaran', n.id_useobat as 'ID Use Obat', p.nama_pasien as 'Nama Pasien', d.nama_dokter as 'Nama Dokter' \r\nFROM nota n, pasien p, dokter d\r\nWHERE paid = 1\r\nand p.id_pasien = n.id_pasien\r\nand d.id_dokter = n.id_dokter and p.nama_pasien like '%{textBoxSearch.Text}%'";
                    dgv(sqlQuery, dtHistory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
