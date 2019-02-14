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
    public partial class duzenle : Form
    {
        public duzenle()
        {
            InitializeComponent();
        }

        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;
        DataSet dsyeni;
        DataTable dt;

        string desifreedilen;
        private void duzenle_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source=sqllite.sqlite;Version=3;");
            da = new SQLiteDataAdapter("Select *From entryler order by tarih", con);
            ds = new DataSet();
            dsyeni = new DataSet();
            dt = new DataTable();
            con.Open();

            da.Fill(ds, "entryler");
            dataGridView1.DataSource = ds.Tables["entryler"];
            con.Close();

            /*da.Fill(ds, "entryler");
            dataGridView1.DataSource = ds.Tables["entryler"];
            con.Close(); */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainsc nesne = new mainsc();
            nesne.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SQLiteConnection("Data Source=sqllite.sqlite;Version=3;");
                cmd = new SQLiteCommand();

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Delete from entryler where ID = " + txtID.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (SQLiteException)
            {
                label1.Visible = true;
                label1.Text = "SQLite hatası.";
                label1.ForeColor = Color.Chocolate;
            }
            
            
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            this.Hide();
            desifreliler nesne = new desifreliler();
            nesne.ShowDialog();
        }

        private void duzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;


            desifreedilen = ds.Tables["entryler"].Rows[a]["entry"].ToString();
            MessageBox.Show(Crypt.Decrypt(desifreedilen));
            

            
        }
    }
}
