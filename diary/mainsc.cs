using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace diary
{
    public partial class mainsc : Form
    {
        public mainsc()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            this.Hide();
            yenientry nesne = new yenientry();
            nesne.ShowDialog();

        }


        private void btnEskiler_Click(object sender, EventArgs e)
        {

            
                this.Hide();
                duzenle nesne = new duzenle();
                nesne.ShowDialog();
            
            

        }

        private void mainsc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
