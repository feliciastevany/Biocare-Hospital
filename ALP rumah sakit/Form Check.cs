using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_rumah_sakit
{
    public partial class Form_Check : Form
    {
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;

        DataTable dtcheck = new DataTable();
        string connection;
        string sqlQuery;
        public Form_Check()
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

        private void Form_Check_Load(object sender, EventArgs e)
        {
            string id = Form_AvRoom.id;
            string directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            PictureBox rum = new PictureBox();
            rum.Location = new Point(20, 30);
            rum.Size = new Size(230, 140);
            rum.SizeMode = PictureBoxSizeMode.StretchImage;
            if (id == "I001")
            {
                rum.ImageLocation = directory + Form_AvRoom.Room[0];
            }
            else if (id == "I002")
            {
                rum.ImageLocation = directory + Form_AvRoom.Room[1];
            }
            else if (id == "P001")
            {
                rum.ImageLocation = directory + Form_AvRoom.Room[2];
            }
            else if (id == "P002")
            {
                rum.ImageLocation = directory + Form_AvRoom.Room[3];
            }
            else if (id == "S001")
            {
                rum.ImageLocation = directory + Form_AvRoom.Room[4];
            }
            else if (id == "V001")
            {
                rum.ImageLocation = directory + Form_AvRoom.Room[5];
            }
            this.Controls.Add(rum);

            try
            {
                sqlQuery = $"SELECT j.nama_jenis as 'Nama jenis', k.no_kamar as 'No. Kamar'\r\nFROM kamar k, jenis_kamar j\r\nwhere k.id_jenis = j.id_jenis and k.available = 'Y' and k.id_jenis = '{id}'";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtcheck);
                dgvCheck.DataSource = dtcheck;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Form_AvRoom Avroom = new Form_AvRoom();
            Avroom.TopLevel = false;
            Avroom.Dock = DockStyle.Fill;
            this.Controls.Add(Avroom);
            Avroom.Show();
        }
    }
}
