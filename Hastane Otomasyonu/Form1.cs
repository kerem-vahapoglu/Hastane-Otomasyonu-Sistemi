using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            hastaGiris hastaGiris = new hastaGiris();
            hastaGiris.Show();
            this.Hide();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            doktorGiris doktorGiris = new doktorGiris();
            doktorGiris.Show();
            this.Hide();
        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
            sekreterGiris sekreterGiris = new sekreterGiris();
            sekreterGiris.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
