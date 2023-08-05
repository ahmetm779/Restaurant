using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    class cSiparis
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _Id;
        private int _adisyonId;
        private int _urunId;
        private int _adet;
        private int _masaId;
        #endregion
        #region Properties
        public int Id { get => _Id; set => _Id = value; }
        public int AdisyonId { get => _adisyonId; set => _adisyonId = value; }
        public int UrunId { get => _urunId; set => _urunId = value; }
        public int Adet { get => _adet; set => _adet = value; }
        public int MasaId { get => _masaId; set => _masaId = value; }
        #endregion

        //Siparişleri Getir
        public void GetByOrder(ListView lv, int adisyon)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select UrunAd,Fiyat,Satislar.ID,UrunId,Satislar.Adet from Satislar INNER JOIN Urunler on Satislar.UrunId=Urunler.ID where AdisyonId=@AdisyonId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;
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
                    lv.Items.Add(dr["UrunAd"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Adet"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["UrunId"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["Fiyat"]) * Convert.ToDecimal(dr["Adet"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());
                    sayac++;
                }
            }
            catch (Exception)
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public bool SetSaveOrder(cSiparis Bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into Satislar(AdisyonId,UrunId,Adet,MasaId) values(@AdisyonId,@UrunId,@Adet,@MasaId)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = Bilgiler._adisyonId;
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = Bilgiler._urunId;
                cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = Bilgiler._adet;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler._masaId;
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
    }
}
