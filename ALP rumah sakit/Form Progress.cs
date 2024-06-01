using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_rumah_sakit
{
    public partial class Form_Progress : Form
    {
        Form1 form2form;
        public Form_Progress(Form1 form1)
        {
            InitializeComponent();
            this.form2form = form1;
            //form2form.f = this;
        }

        private void Form_Progress_Load(object sender, EventArgs e)
        {
            int p = 20;
            Timer timer = new Timer();
            timer.Interval = 800;
            timer.Tick += (s, arg) =>
            {
                progressBar1.Value += p;
                if (progressBar1.Value >= 100)
                {
                    timer.Stop();
                    this.Controls.Clear();
                    Form_Login formlogin = new Form_Login();
                    formlogin.TopLevel = false;
                    formlogin.Dock = DockStyle.Fill;
                    this.Controls.Add(formlogin);
                    formlogin.Show();
                }
            };
            timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
