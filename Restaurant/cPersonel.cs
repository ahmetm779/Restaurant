using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    class cPersonel
    {
        cGenel cGenel = new cGenel();
        #region Fields
        private int _PersonelId;
        private int _GorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;
        #endregion
        #region Properties
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int GorevId { get => _GorevId; set => _GorevId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public string PersonelParola { get => _PersonelParola; set => _PersonelParola = value; }
        public string PersonelKullaniciAdi { get => _PersonelKullaniciAdi; set => _PersonelKullaniciAdi = value; }
        public bool PersonelDurum { get => _PersonelDurum; set => _PersonelDurum = value; }
        #endregion


        public bool personelEntryControl(string password, int UserId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("select * from Personel where ID=@Id and Parola=@password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }
        public void PersonelGetByInformation(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("select * from Personel", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cPersonel p = new cPersonel();
                p._PersonelId = Convert.ToInt32(dr["ID"]);
                p._GorevId = Convert.ToInt32(dr["GorevId"]);
                p._PersonelAd = Convert.ToString(dr["Ad"]);
                p._PersonelSoyad = Convert.ToString(dr["Soyad"]);
                p._PersonelParola = Convert.ToString(dr["Parola"]);
                p._PersonelKullaniciAdi = Convert.ToString(dr["KullaniciAdi"]);
                p._PersonelDurum = Convert.ToBoolean(dr["Durum"]);
                comboBox.Items.Add(p);
            }
            dr.Close();
            con.Close();

        }
        public override string ToString()
        {
            return PersonelKullaniciAdi;
        }
        public void PersonelBilgileriGetirLv(ListView lv)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("select Personel.*,PersonelGorevleri.Gorev from Personel INNER JOIN PersonelGorevleri on PersonelGorevleri.ID=Personel.GorevId where Personel.Durum=0", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["GorevId"].ToString());
                lv.Items[i].SubItems.Add(dr["Gorev"].ToString());
                lv.Items[i].SubItems.Add(dr["Ad"].ToString());
                lv.Items[i].SubItems.Add(dr["Soyad"].ToString());
                lv.Items[i].SubItems.Add(dr["KullaniciAdi"].ToString());
                i++;
            }
            dr.Close();
            con.Close();

        }
        public void PersonelBilgileriGetirFromIDLv(ListView lv, int perId)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("select Personel.*,PersonelGorevleri.Gorev from Personel INNER JOIN PersonelGorevleri on PersonelGorevleri.ID=Personel.GorevId where Personel.Durum=0 and Personel.ID=@perId", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = perId;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["ID"].ToString());
                lv.Items[i].SubItems.Add(dr["GorevId"].ToString());
                lv.Items[i].SubItems.Add(dr["Gorev"].ToString());
                lv.Items[i].SubItems.Add(dr["Ad"].ToString());
                lv.Items[i].SubItems.Add(dr["Soyad"].ToString());
                lv.Items[i].SubItems.Add(dr["KullaniciAdi"].ToString());
                i++;
            }
            dr.Close();
            con.Close();

        }
        public string PersonelBilgiGetirIsim(int perId)
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("select Ad + Soyad from Personel where Personel.Durum=0 and Personel.ID=@perId", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = perId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            return sonuc;
        }
        public bool PersonelSifreDegistir(int perId, string pass)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("update Personel set Parola=@pass where ID=perId", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = perId;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            return sonuc;
        }
        public bool PersonelEkle(cPersonel cp)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("insert into Personel (Ad,Soyad,Parola,GorevId) values (@Ad,@Soyad,@Parola,@GorevId)", con);
            cmd.Parameters.Add("@Ad", SqlDbType.VarChar).Value = _PersonelAd;
            cmd.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = _PersonelSoyad;
            cmd.Parameters.Add("@Parola", SqlDbType.VarChar).Value = _PersonelParola;
            //cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = _PersonelKullaniciAdi;
            cmd.Parameters.Add("@GorevId", SqlDbType.Int).Value = _GorevId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            return sonuc;
        }
        public bool PersonelGuncelle(cPersonel cp, int perId)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("update Personel set Ad=@Ad,Soyad=@Soyad,Parola=@Parola,GorevId=@GorevId where ID=@perId ", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = perId;
            cmd.Parameters.Add("@Ad", SqlDbType.VarChar).Value = _PersonelAd;
            cmd.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = _PersonelSoyad;
            cmd.Parameters.Add("@Parola", SqlDbType.VarChar).Value = _PersonelParola;
            cmd.Parameters.Add("@GorevId", SqlDbType.Int).Value = _GorevId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            return sonuc;
        }
        public bool PersonelSil(int perId)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("update Personel set Durum=1 where ID=@perId ", con);
            cmd.Parameters.Add("@perId", SqlDbType.Int).Value = perId;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            return sonuc;
        }
    }
}
