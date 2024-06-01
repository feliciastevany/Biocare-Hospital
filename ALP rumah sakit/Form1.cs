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
    public partial class Form1 : Form
    {
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;
        MySqlDataReader mysqlreader;
        DataTable dtpasien1 = new DataTable();
        DataTable dtpasien2 = new DataTable();
        string connection;
        string sqlQuery;
        public Form1()
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
        public Form_Login f { get; set; }

        /*public void formloader()
        {
            if (f != null)
            {
                f.MdiParent = this;
            }
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form_Progress progress = new Form_Progress(this);
            progress.Dock = DockStyle.Fill;
            progress.TopLevel = false;
            panel1.Controls.Add(progress);
            progress.Show();
        }
        public void setForm(object form)
        {
            panel1.Controls.Clear();
            if (form.GetType().ToString().Contains("Progress"))
            {
                var obj = form as Form_Function;
                obj.Dock = DockStyle.Fill;
                obj.TopLevel = false;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
