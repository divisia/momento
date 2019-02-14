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
using System.Data.SQLite;

namespace diary
{
    public partial class desifreliler : Form
    {
        public desifreliler()
        {
            InitializeComponent();
        }

        

        private void desifreliler_Load(object sender, EventArgs e)
        {
            SQLiteConnection con;
            SQLiteCommand cmd;
            SQLiteDataAdapter da;
            DataSet set;
            DataTable table;
            DataTable stable;
            DataTable ttable;
            string[] gecici = new string[999];
            string[] trh = new string[999];

            string konum = "data source = sqllite.sqlite";
            con = new SQLiteConnection(konum);
            string sqlsec = "select entry, tarih  from entryler";
            //string sqlyukle = "select * from entryler";


            da = new SQLiteDataAdapter(sqlsec, con);
            set = new DataSet();
            da.Fill(set);
            table = new DataTable();
            stable = new DataTable();
            ttable = new DataTable();
            table = set.Tables[0];
            
            stable.Columns.Add("Entry");
            stable.Columns.Add("Tarih");

            

            for (int i = 0; i < table.Rows.Count; i++)
            {
                stable.Rows.Add();
                gecici[i] = table.Rows[i]["entry"].ToString();
                stable.Rows[i]["Entry"] = Crypt.Decrypt( gecici[i]);

                
                trh[i] = table.Rows[i]["tarih"].ToString();
                stable.Rows[i]["Tarih"] = trh[i];

            }

            dataGridView1.DataSource = stable;
           







        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            duzenle nesne = new duzenle();
            nesne.ShowDialog();
            
        }
    }
}
