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
            if (con.State == ConnectionState.Closed)
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
        public void GetByProductSearch(ListView Cesitler, int txt)
        {
            Cesitler.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Urunler where ID=@Id", con);

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = txt;
            if (con.State == ConnectionState.Closed)
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
        //Ürün Kategori getir combobox
        public void UrunleriCesitleriListele(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Kategoriler where Durum=0", con);
            SqlDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cUrunCesitleri cUrunCesitleri = new cUrunCesitleri();
                    cUrunCesitleri._UrunTurNo = Convert.ToInt32(dr["ID"]);
                    cUrunCesitleri._KategoriAd = dr["KategoriAdi"].ToString();
                    cUrunCesitleri._Aciklama = dr["Aciklama"].ToString();
                    cb.Items.Add(cUrunCesitleri);
                }
            }
            catch (Exception ex)
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
        //Ürün Kategori getir ListView
        public void UrunleriCesitleriListele(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Kategoriler where Durum=0", con);
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
                    lv.Items[sayac].SubItems.Add(dr["KategoriAdi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Aciklama"].ToString());
                    sayac++;
                }
            }
            catch (Exception ex)
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
        //Ürün çeşitlerini getir ListView Arama
        public void UrunleriCesitleriListele(ListView lv, string ara)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Kategoriler where Durum=0 and KategoriAdi like '%' + @ara + '%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@ara", SqlDbType.VarChar).Value = ara;
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
                    lv.Items[sayac].SubItems.Add(dr["KategoriAdi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Aciklama"].ToString());
                    sayac++;
                }
            }
            catch (Exception ex)
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
        //Ürün Kategori Ekleme
        public int UrunCesitEkle(cUrunCesitleri cUrunCesitleri)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into Kategoriler(KategoriAdi,Aciklama) values(@KategoriAdi,@Aciklama)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@KategoriAdi", SqlDbType.VarChar).Value = cUrunCesitleri._KategoriAd;
                cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = cUrunCesitleri._Aciklama;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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
        //Ürün Kategori Güncelle
        public int UrunCesitGuncelle(cUrunCesitleri cUrunCesitleri)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update Kategoriler set KategoriAdi=@KategoriAdi,Aciklama=@Aciklama where ID=@KategoriId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@KategoriId", SqlDbType.Int).Value = cUrunCesitleri._UrunTurNo;
                cmd.Parameters.Add("@KategoriAdi", SqlDbType.VarChar).Value = cUrunCesitleri._KategoriAd;
                cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = cUrunCesitleri._Aciklama;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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
        //Ürün Kategori Sil
        public int UrunCesitSil(int id)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update Kategoriler set Durum=1 where ID=@KategoriId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@KategoriId", SqlDbType.Int).Value = id;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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

        public override string ToString()
        {
            return KategoriAd;
        }
    }
}
