using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace diary
{
    public partial class yenientry : Form
    {
        public yenientry()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti;
        SQLiteCommand cmd;

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                string sifrelientry = Crypt.Encrypt(txtEntry.Text);
                cmd = new SQLiteCommand();
                baglanti = new SQLiteConnection("Data Source = sqllite.sqlite; Version = 3;");
                baglanti.Open();
                cmd.Connection = baglanti;

                cmd.CommandText = "insert into entryler(Entry, Tarih) values ('" + sifrelientry + "', '" + txtTarih.Text + "')";
                cmd.ExecuteNonQuery();
                baglanti.Close();

                lblbilgi.Text = "Entry başarıyla veritabanındaki yerini aldı.";
                lblbilgi.ForeColor = Color.Green;
                lblbilgi.Visible = true;
            }
            catch (SQLiteException)
            {
                string seq = @"create table entryler(ID INTEGER PRIMARY KEY AUTOINCREMENT, entry text not null, tarih text not null);";
                baglanti = new SQLiteConnection("data source = sqllite.sqlite; version = 3;");
                baglanti.Open();
                cmd = new SQLiteCommand(seq, baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();

                lblbilgi.Text = "Veritabanı hatası. Tekrar deneyiniz.";
                lblbilgi.ForeColor = Color.Red;
                lblbilgi.Visible = true;
            }
        }
            

        private void yenientry_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void yenientry_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToString();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainsc nesne = new mainsc();
            nesne.ShowDialog();
        }
    }
}
