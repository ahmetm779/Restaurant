using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    class cAdisyon
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelId;
        private int _Durum;
        private int _MasaId;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int ServisTurNo { get => _ServisTurNo; set => _ServisTurNo = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }
        #endregion

        public int GetByAddition(int MasaId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select top 1 ID from Adisyonlar where MasaId=@MasaId order by ID desc", con);
            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = MasaId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaId = Convert.ToInt32(cmd.ExecuteScalar());
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
            return MasaId;
        }//Açık olan masanın adisyon numarası
        public bool SetByAdditionNew(cAdisyon Bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into Adisyonlar(ServisTurNo,PersonelId,MasaId,Tarih,Durum) values(@ServisTurNo,@PersonelId,@MasaId,@Tarih,@Durum)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler.ServisTurNo;
                cmd.Parameters.Add("@PersonelId", SqlDbType.Int).Value = Bilgiler.PersonelId;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler.MasaId;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Bilgiler.Tarih;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = 0;
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
        public void AdisyonKapat(int adisyonId, int durum)
        {

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update Adisyonlar set Durum = @Durum where ID=@adisyonId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
                cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = durum;
                cmd.ExecuteNonQuery();
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
        }
        public int PaketAdisyonAdediBul()
        {
            int miktar = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select count(*) as Sayi from Adisyonlar where Durum=0 and ServisTurNo=2", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                miktar = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Dispose();
            con.Close();
            return miktar;
        }
        public void AcikPaketAdisyonlar(ListView lv)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select PaketSiparis.MusteriId,Musteriler.Ad + ' ' + Musteriler.Soyad as Musteri, Adisyonlar.ID as AdisyonId from PaketSiparis INNER JOIN Musteriler on Musteriler.ID=PaketSiparis.MusteriId INNER JOIN Adisyonlar on Adisyonlar.ID=PaketSiparis.AdisyonId where Adisyonlar.Durum=0", con);
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["MusteriId"].ToString());
                    lv.Items[i].SubItems.Add(dr["Musteri"].ToString());
                    lv.Items[i].SubItems.Add(dr["AdisyonId"].ToString());
                    i++;
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
        public int MusterininSonAdisyonId(int musteriId)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select Adisyonlar.ID from Adisyonlar INNER JOIN PaketSiparis on PaketSiparis.AdisyonId=Adisyonlar.ID where PaketSiparis.Durum=0 and Adisyonlar.Durum=0 and PaketSiparis.MusteriId=@MusteriId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@MusteriId", SqlDbType.Int).Value = musteriId;
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

        public void MusteriDetaylari(ListView lv, int musteriId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select PaketSiparis.MusteriId,PaketSiparis.AdisyonId,Musteriler.Ad,Musteriler.Soyad,CONVERT(varchar(10),Adisyonlar.Tarih,104) as Tarih from Adisyonlar INNER JOIN PaketSiparis on PaketSiparis.AdisyonId = Adisyonlar.ID INNER JOIN Musteriler on Musteriler.ID = PaketSiparis.MusteriId where Adisyonlar.ServisTurNo = 2 and Adisyonlar.Durum = 0 and PaketSiparis.MusteriId = @MusteriId", con);
            cmd.Parameters.Add("@MusteriId", SqlDbType.Int).Value = musteriId;
            SqlDataReader dr = null;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["MusteriId"].ToString());
                    lv.Items[i].SubItems.Add(dr["Ad"].ToString());
                    lv.Items[i].SubItems.Add(dr["Soyad"].ToString());
                    lv.Items[i].SubItems.Add(dr["Tarih"].ToString());
                    lv.Items[i].SubItems.Add(dr["AdisyonId"].ToString());
                    i++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Dispose();
            con.Close();
        }
    }
}
