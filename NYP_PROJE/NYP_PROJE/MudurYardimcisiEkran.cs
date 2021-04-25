using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace NYP_PROJE
{
   
    public partial class MudurYardimcisiEkran : Form
    {
        ArrayList projedetay = new ArrayList();
        public MudurYardimcisiEkran()
        {
            InitializeComponent();
            listView1.Visible = false;
            listView2.Visible = false;
            listView3.Visible = false;
            listView4.Visible = false;
           
            izinOnayla.Visible = false;
            TeknikIzinOnayla.Visible = false;
            EvrakİzinOnayla.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            izingünleri.Visible = false;
            ekizinLabel.Visible = false;
            EktextBox2.Visible = false;
            button1.Visible = false;
            TeknikEOnayla.Visible = false;
            ekİzinOnayla.Visible = false;
            verilerigoster();
            EvrakVerilerigoster();
            TeknipVerilerigoster();
            MusteriVerilerigoster();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0GKB0TH;Initial Catalog=proje;Integrated Security=True");
        private void EvrakVerilerigoster()
        {
            listView3.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From EvrakTable", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Eid"].ToString();
                ekle.SubItems.Add(oku["EAd"].ToString());
                ekle.SubItems.Add(oku["ESoyad"].ToString());
                ekle.SubItems.Add(oku["EMaas"].ToString());
                ekle.SubItems.Add(oku["EizinBaslangic"].ToString());
                ekle.SubItems.Add(oku["EizinBitis"].ToString());
                ekle.SubItems.Add(oku["Eekizin"].ToString());

                listView3.Items.Add(ekle);
                
            }

            baglan.Close();
        }
        private void TeknipVerilerigoster()
        {
            listView2.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From TeknikETable", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["Tid"].ToString();
                ekle.SubItems.Add(oku["TAd"].ToString());
                ekle.SubItems.Add(oku["TSoyad"].ToString());
                ekle.SubItems.Add(oku["TMaas"].ToString());
                ekle.SubItems.Add(oku["TizinBaslangic"].ToString());
                ekle.SubItems.Add(oku["TizinBitis"].ToString());
                ekle.SubItems.Add(oku["Tekizin"].ToString());
                foreach (var i in projedetay)
                {
                    ekle.SubItems.Add(i.ToString());
                }
                listView2.Items.Add(ekle);

            }

            baglan.Close();
        }
        private void MusteriVerilerigoster()
        {
            listView4.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From MusteriTable", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["Mid"].ToString();
                ekle.SubItems.Add(oku["FirmaIsmi"].ToString());
                ekle.SubItems.Add(oku["Il"].ToString());
                ekle.SubItems.Add(oku["Ilce"].ToString());
                ekle.SubItems.Add(oku["Acikadres"].ToString());
                ekle.SubItems.Add(oku["ProjeFiyat"].ToString());
                ekle.SubItems.Add(oku["IsYapmaSayisi"].ToString());
                listView4.Items.Add(ekle);
                projedetay.Add(oku["ProjeAdi"].ToString());
                projedetay.Add(oku["ProjeBaslangic"].ToString());
                projedetay.Add(oku["ProjeBitis"].ToString());

            }

            baglan.Close();
        }
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From oyuncuTabloo", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["maas"].ToString());
                
                ekle.SubItems.Add(oku["izinBaslangic"].ToString());
                ekle.SubItems.Add(oku["izinBitis"].ToString());
                ekle.SubItems.Add(oku["ekizin"].ToString());
                foreach (var i in projedetay)
                {
                    ekle.SubItems.Add(i.ToString());
                }
                listView1.Items.Add(ekle);
               

            }

            baglan.Close();
        }
        private void oyuncularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView3.Visible = false;
            listView2.Visible = false;
            listView4.Visible = false;
            listView1.Visible = true;
            EvrakİzinOnayla.Visible = false;
            TeknikIzinOnayla.Visible = false;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            izingünleri.Visible = true;
            izinOnayla.Visible = true;
            ekizinLabel.Visible = true;
            EktextBox2.Visible = true;
            button1.Visible = false;
            TeknikEOnayla.Visible = false;
            ekİzinOnayla.Visible = true;
            verilerigoster();
        }

        private void teknikEkipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView3.Visible = false;
            listView1.Visible = false;
            listView4.Visible = false;
            listView2.Visible = true;
            izinOnayla.Visible = false;
            EvrakİzinOnayla.Visible = false;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            izingünleri.Visible = true;
            TeknikIzinOnayla.Visible = true;
            ekizinLabel.Visible = true;
            EktextBox2.Visible = true;
            button1.Visible = false;
            ekİzinOnayla.Visible = false;
            TeknikEOnayla.Visible = true;
            TeknipVerilerigoster();
        }

        private void evrakİşleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            listView2.Visible = false;
            listView4.Visible = false;
            listView3.Visible = true;
            izinOnayla.Visible = false;
            TeknikIzinOnayla.Visible = false;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            izingünleri.Visible = true;
            EvrakİzinOnayla.Visible = true;
            ekizinLabel.Visible = true;
            EktextBox2.Visible = true;
            TeknikEOnayla.Visible = false;
            ekİzinOnayla.Visible = false;
            button1.Visible = true;
            EvrakVerilerigoster();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            listView2.Visible = false;
            listView3.Visible = false;
            listView4.Visible = true;
            izinOnayla.Visible = false;
            TeknikIzinOnayla.Visible = false;
            EvrakİzinOnayla.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            izingünleri.Visible = false;
            ekizinLabel.Visible = false;
            EktextBox2.Visible = false;
            button1.Visible = false;
            TeknikEOnayla.Visible = false;
            ekİzinOnayla.Visible = false;
            MusteriVerilerigoster();
        }
        int id1 = 0;
   

        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            id1 = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[5].Text;
            EktextBox2.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void listView2_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            id1 = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
            dateTimePicker1.Text = listView2.SelectedItems[0].SubItems[4].Text;
            dateTimePicker2.Text = listView2.SelectedItems[0].SubItems[5].Text;
            EktextBox2.Text = listView2.SelectedItems[0].SubItems[6].Text;
        }

        private void listView3_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            id1 = int.Parse(listView3.SelectedItems[0].SubItems[0].Text);
            dateTimePicker1.Text = listView3.SelectedItems[0].SubItems[4].Text;
            dateTimePicker2.Text = listView3.SelectedItems[0].SubItems[5].Text;
            EktextBox2.Text = listView3.SelectedItems[0].SubItems[6].Text;
        }

        private void EvrakİzinOnayla_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update EvrakTable set EizinBaslangic='" + dateTimePicker1.Text.ToString() + "',EizinBitis='" + dateTimePicker2.Text.ToString() + "'where Eid=" + id1 + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            EvrakVerilerigoster();
        }

        private void TeknikIzinOnayla_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update TeknikETable set TizinBaslangic='" + dateTimePicker1.Text.ToString() + "',TizinBitis='" + dateTimePicker2.Text.ToString() + "'where Tid=" + id1 + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            TeknipVerilerigoster();
        }

        private void izinOnayla_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update oyuncuTabloo set izinBaslangic='" + dateTimePicker1.Text.ToString() + "',izinBitis='" + dateTimePicker2.Text.ToString() + "'where id=" + id1 + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void TeknikEOnayla_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update TeknikETable set Tekizin='" + EktextBox2.Text + "'where Tid=" + id1 + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void ekİzinOnayla_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update oyuncuTabloo set ekizin='" + EktextBox2.Text + "'where id=" + id1 + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update EvrakTable set Eekizin='" + EktextBox2.Text + "'where eid=" + id1 + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }
    }
}
