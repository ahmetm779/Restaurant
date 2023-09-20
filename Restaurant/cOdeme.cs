using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    class cOdeme
    {
        #region Fields
        private int _OdemeId;
        private int _AdisyonId;
        private int _OdemeTurId;
        private decimal _AraToplam;
        private decimal _Indirim;
        private decimal _KdvTutari;
        private decimal _GenelToplam;
        private DateTime _Tarih;
        private int _MusteriId;
        #endregion
        #region Properties
        public int OdemeId { get => _OdemeId; set => _OdemeId = value; }
        public int AdisyonId { get => _AdisyonId; set => _AdisyonId = value; }
        public int OdemeTurId { get => _OdemeTurId; set => _OdemeTurId = value; }
        public decimal AraToplam { get => _AraToplam; set => _AraToplam = value; }
        public decimal Indirim { get => _Indirim; set => _Indirim = value; }
        public decimal KdvTutari { get => _KdvTutari; set => _KdvTutari = value; }
        public decimal GenelToplam { get => _GenelToplam; set => _GenelToplam = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int MusteriId { get => _MusteriId; set => _MusteriId = value; }
        #endregion

        cGenel gnl = new cGenel();

        //Müşterinin Masa Hesabını Kapatıyoruz.
        public bool BillClose(cOdeme bill)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into HesapOdemeleri(AdisyonId,OdemeTurId,MusteriId,AraToplam,KDVTutari,Indirim,ToplamTutar) values(@AdisyonId,@OdemeTurId,@MusteriId,@AraToplam,@KDVTutari,@Indirim,@ToplamTutar)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = bill._AdisyonId;
                cmd.Parameters.Add("@OdemeTurId", SqlDbType.Int).Value = bill._OdemeTurId;
                cmd.Parameters.Add("@MusteriId", SqlDbType.Int).Value = bill._MusteriId;
                cmd.Parameters.Add("@AraToplam", SqlDbType.Money).Value = bill._AraToplam;
                cmd.Parameters.Add("@KDVTutari", SqlDbType.Money).Value = bill._KdvTutari;
                cmd.Parameters.Add("@Indirim", SqlDbType.Money).Value = bill._Indirim;
                cmd.Parameters.Add("@ToplamTutar", SqlDbType.Money).Value = bill._GenelToplam;

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

        //Müşterinin toplam harcamasını buluyoruz.
        public decimal SumTotalClientId(int clientId)
        {
            decimal total = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select sum(ToplamTutar) as total from HesapOdemeleri where MusteriId=@clientId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@clientId", SqlDbType.Int).Value = clientId;
                total = Convert.ToDecimal(cmd.ExecuteScalar());
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

            return total;
        }
    }
}
