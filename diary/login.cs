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
using System.Security.Cryptography;
using System.IO;

namespace diary
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti;
        SQLiteCommand cmd;


        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("sqllite.sqlite"))
            {
                string konum = "data source=sqllite.sqlite";
                SQLiteConnection baglanti = new SQLiteConnection(konum);
                baglanti.Open();

                string sql = "select*from kullanicilar where kullanici_adi=@kullanici_adi and parola=@parola";
                SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@kullanici_adi", txtAd.Text);
                adp.SelectCommand.Parameters.AddWithValue("@parola", MD5Sifrele(txtSifre.Text));

                DataTable dt = new DataTable();
                adp.Fill(dt);
                baglanti.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Kullanıcı adı ya da parola hatalı.", "Giriş başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    mainsc nesne = new mainsc();
                    nesne.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show("Veri tabanı bulunamadı. Yeni bir veritabanı ve girili bilgiler ile kullanıcı kaydı oluşturulsun mu? ", "Veritabanı Oluşturma Servisi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SQLiteConnection.CreateFile("sqllite.sqlite");
                    string seq = @"create table kullanicilar(ID INTEGER PRIMARY KEY AUTOINCREMENT, kullanici_adi text not null, parola text not null);";
                    string sqa = @"create table entryler(ID INTEGER PRIMARY KEY AUTOINCREMENT, entry text not null, tarih text not null);";
                    baglanti = new SQLiteConnection("data source = sqllite.sqlite; version = 3;");
                    baglanti.Open();
                    cmd = new SQLiteCommand(seq, baglanti);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    cmd = new SQLiteCommand(sqa, baglanti);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "insert into kullanicilar(kullanici_adi, parola) values ('" + txtAd.Text + "', '" + MD5Sifrele(txtSifre.Text) + "')";


                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        public static string MD5Sifrele(string metin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] btr = Encoding.UTF8.GetBytes(metin);
            btr = md5.ComputeHash(btr);

            StringBuilder sb = new StringBuilder();


            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            return sb.ToString();
        }
    }
}
