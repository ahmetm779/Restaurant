using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    class cUrunCesitleri
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _UrunTurNo;
        private string _KategoriAd;
        private string _Aciklama;
        #endregion
        #region Properties
        public int UrunTurNo { get => _UrunTurNo; set => _UrunTurNo = value; }
        public string KategoriAd { get => _KategoriAd; set => _KategoriAd = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        #endregion

        public void GetByProductTypes(ListView Cesitler, Button btn)
        {
            Cesitler.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select UrunAd,Fiyat,Urunler.ID from Kategoriler INNER JOIN Urunler on Kategoriler.ID=Urunler.KategoriId where Urunler.KategoriId=@KategoriId", con);
            string aa = btn.Name;
            int uzunluk = aa.Length;

            cmd.Parameters.Add("@KategoriId", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;

            while (dr.Read())
            {
                Cesitler.Items.Add(dr["UrunAd"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
    }
}
