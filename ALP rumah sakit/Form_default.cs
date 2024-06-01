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
    public partial class Form_default : Form
    {
        public Form_default()
        {
            InitializeComponent();
        }
        int a = 0;

        List<string> Default;
        string directory;
        private void Form_default_Load(object sender, EventArgs e)
        {
            string file = "default.txt";
            string[] foto = File.ReadAllLines(file);
            Default = new List<string>();
            foreach (string line in foto)
            {
                Default.AddRange(line.Split(','));
            }
            a = 1;
            directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            changeDefault(a);
            timer1.Start();
        }
        private void changeDefault(int x)
        {
            string url1 = Default[x];
            string fullUrl1 = directory + url1;
            pictureBox1.ImageLocation = fullUrl1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 4)
            {
                a = 0;
            }
            else
            {
                a++;
            }
            changeDefault(a);
        }
    }
}
