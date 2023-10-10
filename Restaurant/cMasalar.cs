using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Restaurant
{
    class cMasalar
    {
        #region Fields
        private int _Id;
        private int _Kapasite;
        private int _ServisTuru;
        private int _Durum;
        private int _Onay;
        private string _MasaBilgi;
        #endregion

        #region Properties
        public int Id { get => _Id; set => _Id = value; }
        public int Kapasite { get => _Kapasite; set => _Kapasite = value; }
        public int ServisTuru { get => _ServisTuru; set => _ServisTuru = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int Onay { get => _Onay; set => _Onay = value; }
        public string MasaBilgi { get => _MasaBilgi; set => _MasaBilgi = value; }
        #endregion

        cGenel gnl = new cGenel();
        public string SessionSum(int state, string masaId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select Tarih,MasaId from Adisyonlar Right Join Masalar on Adisyonlar.MasaId=Masalar.ID where Masalar.Durum=@durum and Adisyonlar.Durum=0 and Masalar.ID=@masaId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Convert.ToInt32(masaId);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }
        public int TableGetByNumber(string TableValue)
        {
            string aa = TableValue;
            int length = aa.Length;
            string masaNo = "";
            if (length > 8)
            {
                masaNo = aa.Substring(length - 2, 2);
            }
            else
            {
                masaNo = aa.Substring(length - 1, 1);
            }
            return Convert.ToInt32(masaNo);
        }
        public bool TableGetByState(int ButtonName, int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select Durum from Masalar where ID=@TableId and Durum=@state", con);
            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
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
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
        public void SetChangeTableState(string ButonName, int state)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update Masalar set Durum=@Durum where ID=@MasaNo", con);
            string masaNo = "";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string aa = ButonName;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
            if (uzunluk > 8)
            {
                masaNo = aa.Substring(uzunluk - 2, 2);
            }
            else
            {
                masaNo = aa.Substring(uzunluk - 1, 1);
            }

            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = masaNo;


            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
        public void MasaKapasitesiveDurumuGetir(ComboBox cb)
        {
            cb.Items.Clear();
            string durum = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Masalar", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cMasalar cMasalar = new cMasalar();
                if (cMasalar._Durum == 2)
                    durum = "DOLU";
                else if (cMasalar._Durum == 3)
                    durum = "REZERVE";
                cMasalar._Kapasite = Convert.ToInt32(dr["Kapasite"]);
                cMasalar._MasaBilgi = "Masa No: " + dr["ID"].ToString() + " Kapasitesi: " + dr["Kapasite"].ToString();
                cMasalar._Id = Convert.ToInt32(dr["ID"]);
                cb.Items.Add(cMasalar);
            }

            dr.Close();
            con.Dispose();
            con.Close();
        }
        public override string ToString()
        {
            return MasaBilgi;
        }
    }
}
