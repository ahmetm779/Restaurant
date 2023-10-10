using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    class cMusteriler
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _musteriId;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _telefon;
        private string _adres;
        private string _email;
        #endregion
        #region Properties
        public int MusteriId { get => _musteriId; set => _musteriId = value; }
        public string MusteriAd { get => _musteriAd; set => _musteriAd = value; }
        public string MusteriSoyad { get => _musteriSoyad; set => _musteriSoyad = value; }
        public string Telefon { get => _telefon; set => _telefon = value; }
        public string Adres { get => _adres; set => _adres = value; }
        public string Email { get => _email; set => _email = value; }
        #endregion

        public bool MusteriVarMi(string tlf)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "MusteriVarmi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = tlf;
            cmd.Parameters.Add("@sonuc", SqlDbType.Int);
            cmd.Parameters["@sonuc"].Direction = ParameterDirection.Output;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                sonuc = Convert.ToBoolean(cmd.Parameters["@sonuc"].Value);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return sonuc;
        }
        public int MusteriEkle(cMusteriler musteriler)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into Musteriler(Ad,Soyad,Adres,Telefon,Email) values(@Ad,@Soyad,@Adres,@Telefon,@Email); select SCOPE_IDENTITY()", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@Ad", SqlDbType.VarChar).Value = musteriler._musteriAd;
                cmd.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = musteriler._musteriSoyad;
                cmd.Parameters.Add("@Adres", SqlDbType.VarChar).Value = musteriler._adres;
                cmd.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = musteriler._telefon;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = musteriler._email;
                sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return sonuc;
        }
        public bool MusteriGuncelle(cMusteriler musteriler)
        {
            bool sonuc = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update Musteriler set Ad=@Ad,Soyad=@Soyad,Adres=@Adres,Telefon=@Telefon,Email=@Email where ID=@MusteriId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@MusteriId", SqlDbType.Int).Value = musteriler._musteriId;
                cmd.Parameters.Add("@Ad", SqlDbType.VarChar).Value = musteriler._musteriAd;
                cmd.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = musteriler._musteriSoyad;
                cmd.Parameters.Add("@Adres", SqlDbType.VarChar).Value = musteriler._adres;
                cmd.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = musteriler._telefon;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = musteriler._email;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return sonuc;
        }
        public void MusterileriGetir(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Musteriler", con);
            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Ad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Soyad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Adres"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Email"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }

        }
        public void MusterileriGetirById(int musteri, TextBox ad, TextBox soyad, TextBox tlf, TextBox adres, TextBox email)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Musteriler where ID=@musteriId", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteri;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ad.Text = dr["Ad"].ToString();
                    soyad.Text = dr["Soyad"].ToString();
                    tlf.Text = dr["Telefon"].ToString();
                    adres.Text = dr["Adres"].ToString();
                    email.Text = dr["Email"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void MusteriGetirAd(ListView lv, string musteriAd)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Musteriler where Ad like @musteriAd + '%'", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@musteriAd", SqlDbType.VarChar).Value = musteriAd;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["Ad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Soyad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Adres"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Email"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void MusteriGetirSoyad(ListView lv, string musteriSoyad)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Musteriler where Soyad like @musteriSoyad + '%'", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@musteriSoyad", SqlDbType.VarChar).Value = musteriSoyad;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["Ad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Soyad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Adres"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Email"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void MusteriGetirTelefon(ListView lv, string musteriTelefon)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Musteriler where Telefon like @musteriTelefon + '%'", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@musteriTelefon", SqlDbType.VarChar).Value = musteriTelefon;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["Ad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Soyad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Adres"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Email"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void MusteriGetirAdres(ListView lv, string musteriAdres)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Musteriler where Adres like @musteriAdres + '%'", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@musteriAdres", SqlDbType.VarChar).Value = musteriAdres;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["ID"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["Ad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Soyad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Adres"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Email"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
    }
}
