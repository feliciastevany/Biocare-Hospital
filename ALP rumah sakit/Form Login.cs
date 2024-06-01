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
    public partial class Form_Login : Form
    {
        //Form1 form2form;
        MySqlConnection mysqlconnection;
        MySqlCommand mysqlcommand;
        MySqlDataAdapter mysqldataadapter;

        DataTable dtlogin = new DataTable();
        string connection;
        string sqlQuery;
        public Form_Login()
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool login = false;
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Please input the field correctly", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < dtlogin.Rows.Count; i++)
                {
                    if (dtlogin.Rows[i][0].ToString() == textBoxID.Text)
                    {
                        login = true;
                    }
                }
                if (login)
                {
                    MessageBox.Show("You're logged in!");
                    this.Controls.Clear();
                    Form_Function function = new Form_Function();
                    function.TopLevel = false;
                    function.Dock = DockStyle.Fill;
                    this.Controls.Add(function);
                    function.Show();
                }
                else
                {
                    MessageBox.Show("The ID you entered is incorrect, please try again.");
                }
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "SELECT p.id_perawat FROM perawat p;";
                mysqlconnection = new MySqlConnection(connection);
                mysqlcommand = new MySqlCommand(sqlQuery, mysqlconnection);
                mysqldataadapter = new MySqlDataAdapter(mysqlcommand);
                mysqldataadapter.Fill(dtlogin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
