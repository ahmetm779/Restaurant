using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Restaurant
{
    class cRezervasyon
    {
        #region Fields
        private int _ID;
        private int _TableId;
        private int _ClientId;
        private DateTime _Date;
        private int _ClientCount;
        private string _Description;
        private int _AdditionId;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int TableId { get => _TableId; set => _TableId = value; }
        public int ClientId { get => _ClientId; set => _ClientId = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public int ClientCount { get => _ClientCount; set => _ClientCount = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int AdditionId { get => _AdditionId; set => _AdditionId = value; }
        #endregion

        cGenel gnl = new cGenel();
        //MusteriId masa numarasına göre
        public int GetByClientfromRezervasyon(int tableId)
        {
            int clientId = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select top 1 MusteriId from Rezervasyonlar where MasaId=@MasaId order by MusteriId desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = tableId;

                clientId = Convert.ToInt32(cmd.ExecuteScalar());
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

            return clientId;
        }
        //Hesap Kapatırken rezervasyonlu masayı kapatıyoruz.
        public bool RezervasyonKapat(int adisyonId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update Rezervasyonlar set Durum=1 where AdisyonId=@adisyonId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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

            return result;
        }
        //Rezervasyonları Getir
        public void MusteriIdGetirFromRezervasyon(ListView lv)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select Rezervasyonlar.MusteriId,(Ad+Soyad) as musteri from Rezervasyonlar INNER JOIN " +
                "Musteriler on Rezervasyonlar.MusteriId=Musteriler.ID where Rezervasyonlar.Durum=0", con);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;

            while (dr.Read())
            {
                lv.Items.Add(dr["MusteriId"].ToString());
                lv.Items[i].SubItems.Add(dr["musteri"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        //Eski Rezervasyonları Getir
        public void EskiRezervasyonlariGetir(ListView lv, int mId)
        {
            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select Rezervasyonlar.MusteriId,Ad,Soyad,AdisyonId,Tarih from Rezervasyonlar INNER JOIN " +
                "Musteriler on Rezervasyonlar.MusteriId=Musteriler.ID where Rezervasyonlar.MusteriId=@mId and Rezervasyonlar.Durum=0 " +
                "order by Rezervasyonlar.ID desc", con);

            cmd.Parameters.Add("@mId", SqlDbType.Int).Value = mId;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
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
            dr.Close();
            con.Dispose();
            con.Close();
        }
        //En son rezervasyon tarihini getir
        public DateTime EnSonRezervasyonTarihi(int mId)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select Tarih from Rezervasyonlar where MusteriId=@mId and Durum=1 " +
                "order by Rezervasyonlar.ID desc", con);

            cmd.Parameters.Add("@mId", SqlDbType.Int).Value = mId;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dt = Convert.ToDateTime(cmd.ExecuteScalar());

            con.Dispose();
            con.Close();
            return dt;
        }
        //Açık rezervasyon sayısını getir
        public int AcikRezervasyonSayisi()
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select COUNT(*) from Rezervasyonlar where Durum=0", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {

                throw;
            }
            con.Dispose();
            con.Close();
            return sonuc;
        }
        //Rezervasyon Açık mı kontrolü
        public bool RezervasyonAcikmiKontrol(int mId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select top 1 Rezervasyonlar.ID from Rezervasyonlar where MusteriId=@mId and Durum=1 order by ID desc", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@mId", SqlDbType.Int).Value = mId;
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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

            return result;
        }
        //Rezervasyon Aç
        public bool RezervasyonAc(cRezervasyon r)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Rezervasyonlar (MusteriId,MasaId,AdisyonId,KisiSayisi,Tarih,Aciklama,Durum) " +
                "values(@MusteriId,@MasaId,@AdisyonId,@KisiSayisi,@Tarih,@Aciklama,1)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@MusteriId", SqlDbType.Int).Value = r._ClientId;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = r._TableId;
                cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = r._AdditionId;
                cmd.Parameters.Add("@KisiSayisi", SqlDbType.Int).Value = r._ClientCount;
                cmd.Parameters.Add("@Tarih", SqlDbType.Date).Value = r._Date;
                cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = r._Description;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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

            return result;
        }
        //Rezerve Masa ID si getir
        public int RezerveMasaIdGetir(int mId)
        {
            int sonuc = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select Rezervasyonlar.MasaId from Rezervasyonlar INNER JOIN Adisyonlar on " +
                "Rezervasyonlar.AdisyonId=Adisyonlar.ID where (Rezervasyonlar.Durum=1) and Adisyonlar.Durum=0 and Adisyonlar.MusteriId=@mId", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd.Parameters.Add("mId", SqlDbType.Int).Value = mId;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {

                throw;
            }
            con.Dispose();
            con.Close();
            return sonuc;
        }
    }
}
