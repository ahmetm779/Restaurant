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
    }
}
