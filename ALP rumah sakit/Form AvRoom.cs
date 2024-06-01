using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ALP_rumah_sakit
{
    public partial class Form_AvRoom : Form
    {
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;

        DataTable dtbook = new DataTable();
        string connection;
        string sqlQuery;
        Button[] book;
        public static string id;
        public Form_AvRoom()
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

        public static List<string> Room;
        List<string> Roomname = new List<string> { "Intensive Care Unit (ICU)", "Isolation Room", "Palliative Care", "Post-Operative Room", "Standard Private", "VIP Room" };
        List<string> harga = new List<string> { "Rp 2.500.000", "Rp 3.500.000", "Rp 3.500.000", "Rp 5.000.000", "Rp 1.500.000", "Rp 3.000.000" };
        List<string> jenis = new List<string> { "I001", "I002", "P001", "P002", "S001", "V001" };
        string directory;
        int xpic = 30;
        int ypic = 40;
        int xlbl = 280;
        int ylbl = 70;
        int xbtn = 510;
        int ybtn = 150;
        int ylbl2 = 120;
        private void Form_AvRoom_Load(object sender, EventArgs e)
        {
            string file = "room.txt";
            string[] foto = File.ReadAllLines(file);
            Room = new List<string>();
            foreach (string line in foto)
            {
                Room.AddRange(line.Split(','));
            }
            directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            book = new Button[6];
            for (int j = 0; j < Room.Count; j++)
            {
                PictureBox rum = new PictureBox();
                rum.ImageLocation = directory + Room[j];
                rum.Location = new Point(xpic, ypic);
                rum.Size = new Size(230, 140);
                rum.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(rum);
                ypic += 170;

                Label name = new Label();
                name.Location = new Point(xlbl, ylbl);
                name.Size = new Size(180, 30);
                name.Text = Roomname[j];
                name.BackColor = Color.Transparent;
                name.ForeColor = Color.White;
                name.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
                this.Controls.Add(name);
                ylbl += 170;

                Label price = new Label();
                price.Location = new Point(xlbl, ylbl2);
                price.Size = new Size(100, 30);
                price.Text = harga[j];
                price.BackColor = Color.Transparent;
                price.ForeColor = Color.White;
                price.Font = new Font("Bahnschrift", 9, FontStyle.Regular);
                this.Controls.Add(price);
                ylbl2 += 170;
            }
            try
            {
                sqlQuery = $"SELECT k.no_kamar as 'No. Kamar', k.id_jenis, k.available\r\nFROM kamar k;";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtbook);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bool available = false;
            for (int i = 0; i < jenis.Count; i++)
            {              
                book[i] = new Button();
                book[i].Location = new Point(xbtn, ybtn);
                book[i].Size = new Size(80, 25);
                book[i].BackColor = Color.Teal;
                book[i].ForeColor = Color.White;
                book[i].Text = "Check";
                book[i].Tag = jenis[i];
                book[i].Click += book_Click;
                this.Controls.Add(book[i]);
                ybtn += 170;
                for(int k = 0; k < dtbook.Rows.Count; k++)
                {
                    if (dtbook.Rows[k][1].ToString() == book[i].Tag.ToString())
                    {
                        if (dtbook.Rows[k][2].ToString() == "Y")
                        {
                            available = true;
                        }
                    }
                }
                if (!available)
                {
                    book[i].Enabled = false;
                }
            }
            
        }
        private void book_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            id = send.Tag.ToString();

            this.Controls.Clear();

            Form_Check check = new Form_Check();
            check.TopLevel = false;
            check.Dock = DockStyle.Fill;
            this.Controls.Add(check);
            check.Show();
        }
    }
}
