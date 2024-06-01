using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ALP_rumah_sakit
{
    public partial class Form_Function : Form
    {
        public Form_Function()
        {
            InitializeComponent();
            panelInsRmv.Visible = false;
            panelRoom.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelInsRmv.Visible == true)
            {
                panelInsRmv.Visible = false;
            }
            if (panelRoom.Visible == true)
            {
                panelRoom.Visible = false;
            }
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void buttonHistory_Click(object sender, EventArgs e)
        {
            labelWlcm.Text = "Billing History";
            this.panelFill.Controls.Clear();

            Form_History history = new Form_History();
            history.TopLevel = false;
            history.Dock = DockStyle.Fill;
            panelFill.Controls.Add(history);
            history.Show();
        }

        private void buttonPatient_Click_1(object sender, EventArgs e)
        {
            labelWlcm.Text = "Patient Data";
            this.panelFill.Controls.Clear();

            Form_Pasien pasien = new Form_Pasien();
            pasien.TopLevel = false;
            pasien.Dock = DockStyle.Fill;
            panelFill.Controls.Add(pasien);
            pasien.Show();
        }

        private void buttonInsRmv_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelInsRmv);
        }

        private void buttonRoom_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelRoom);
        }

        private void Form_Function_Load(object sender, EventArgs e)
        {
            this.panelFill.Controls.Clear();

            Form_default def = new Form_default();
            def.TopLevel = false;
            def.Dock = DockStyle.Fill;
            panelFill.Controls.Add(def);
            def.Show();
        }

        private void buttonAvRoom_Click(object sender, EventArgs e)
        {
            labelWlcm.Text = "Available Room";
            this.panelFill.Controls.Clear();

            Form_AvRoom Avroom = new Form_AvRoom();
            Avroom.TopLevel = false;
            Avroom.Dock = DockStyle.Fill;
            panelFill.Controls.Add(Avroom);
            Avroom.Show();
        }

        private void buttonUnRoom_Click(object sender, EventArgs e)
        {
            labelWlcm.Text = "Unavailable Room";
            this.panelFill.Controls.Clear();

            Form_Room Unroom = new Form_Room();
            Unroom.TopLevel = false;
            Unroom.Dock = DockStyle.Fill;
            panelFill.Controls.Add(Unroom);
            Unroom.Show();
        }

        private void buttonInsPas_Click(object sender, EventArgs e)
        {
            labelWlcm.Text = "Edit Patient";
            this.panelFill.Controls.Clear();

            Form_InsRmv edit = new Form_InsRmv();
            edit.TopLevel = false;
            edit.Dock = DockStyle.Fill;
            panelFill.Controls.Add(edit);
            edit.Show();
        }

        private void buttonInsDokter_Click(object sender, EventArgs e)
        {
            labelWlcm.Text = "Edit Doctor";
            this.panelFill.Controls.Clear();

            Form_InsDoct edit = new Form_InsDoct();
            edit.TopLevel = false;
            edit.Dock = DockStyle.Fill;
            panelFill.Controls.Add(edit);
            edit.Show();
        }

        private void buttonInsPrwt_Click(object sender, EventArgs e)
        {
            labelWlcm.Text = "Edit Nurse";
            this.panelFill.Controls.Clear();

            Form_InsNurse edit = new Form_InsNurse();
            edit.TopLevel = false;
            edit.Dock = DockStyle.Fill;
            panelFill.Controls.Add(edit);
            edit.Show();
        }

        private void buttonHistory_Click_1(object sender, EventArgs e)
        {
            labelWlcm.Text = "Billing History";
            this.panelFill.Controls.Clear();

            Form_History history = new Form_History();
            history.TopLevel = false;
            history.Dock = DockStyle.Fill;
            panelFill.Controls.Add(history);
            history.Show();
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            labelWlcm.Text = "Here is your Bill!";
            this.panelFill.Controls.Clear();

            Form_Nota nota = new Form_Nota();
            nota.TopLevel = false;
            nota.Dock = DockStyle.Fill;
            this.panelFill.Controls.Add(nota);
            nota.Show();
        }

        private void buttonObat_Click(object sender, EventArgs e)
        {
            labelWlcm.Text = "Medicine";
            this.panelFill.Controls.Clear();

            Form_Obat obat = new Form_Obat();
            obat.TopLevel = false;
            obat.Dock = DockStyle.Fill;
            this.panelFill.Controls.Add(obat);
            obat.Show();
        }
    }
}
