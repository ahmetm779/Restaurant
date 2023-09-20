using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    class cPaketler
    {
        #region Fields
        private int _ID;
        private int _AdditionId;
        private int _ClientId;
        private string _Description;
        private int _State;
        private int _PayTypeId;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int AdditionId { get => _AdditionId; set => _AdditionId = value; }
        public int ClientId { get => _ClientId; set => _ClientId = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int State { get => _State; set => _State = value; }
        public int PayTypeId { get => _PayTypeId; set => _PayTypeId = value; }
        #endregion

        cGenel gnl = new cGenel();

        //Paket Servisi Açma
        public bool OrderServiceOpen(cPaketler order)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into PaketSiparis(MusteriId,AdisyonId,OdemeTurId,Aciklama) values(@MusteriId,@AdisyonId,@OdemeTurId,@Aciklama)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@MusteriId", SqlDbType.Int).Value = order._ClientId;
                cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = order._AdditionId;
                cmd.Parameters.Add("@OdemeTurId", SqlDbType.Int).Value = order._PayTypeId;
                cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = order._Description;
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
        //Paket Servisi Kapatma
        public void OrderServiceClose(int AdditionId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update PaketSiparis set PaketSiparis.Durum=1 where PaketSiparis.AdisyonId=@AdisyonId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdditionId;
                Convert.ToBoolean(cmd.ExecuteNonQuery());
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
        //Açılan Adisyon ve Paket Siparişe Ait Ön Ödeme Tür Id
        public int OdemeTurIdGetir(int adisyonId)
        {
            int odemeTurId = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select PaketSiparis.OdemeTurId from PaketSiparis INNER JOIN Adisyonlar on PaketSiparis.AdisyonId=Adisyonlar.ID where Adisyonlar.ID=@adisyonId", con);
           cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                odemeTurId = Convert.ToInt32(cmd.ExecuteScalar());
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
            return odemeTurId;
        }
        //Sipariş kontrol için müşteriye ait olan en son adisyon nosunu getirme
        //Bir müşteriye ait 2 tane siparişin açık olamayacağını belirtiyoruz.
        public int MusteriSonAdisyonIdFetir(int musteriId)
        {
            int no = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select Adisyonlar.ID from Adisyonlar INNER JOIN PaketSiparis on PaketServis.AdisyonId=Adisyonlar.ID where Adisyonlar.Durum=0 and PaketSiparis.Durum=0 and PaketSiparis.MusteriId=@musteriId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriId", SqlDbType.Int).Value = musteriId;
                no = Convert.ToInt32(cmd.ExecuteScalar());
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

            return no;
        }
        //Müşteri Arama ekranında adisyonbul butonu açık mı değil mi kontrol
        public bool GetCheckOpenAdditionId(int additionId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Adisyonlar where Durum=0 and ID=@additionId ", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@additionId", SqlDbType.Int).Value = additionId;
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



    }
}
