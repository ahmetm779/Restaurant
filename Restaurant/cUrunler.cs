using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    class cUrunler
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _urunId;
        private int _urunTurNo;
        private string _urunad;
        private decimal _fiyat;
        private string _aciklama;
        #endregion
        #region Property
        public int UrunId { get => _urunId; set => _urunId = value; }
        public int UrunTurNo { get => _urunTurNo; set => _urunTurNo = value; }
        public string Urunad { get => _urunad; set => _urunad = value; }
        public decimal Fiyat { get => _fiyat; set => _fiyat = value; }
        public string Aciklama { get => _aciklama; set => _aciklama = value; }
        #endregion

        //Ürün adına göre listeleme
        public void UrunleriListeleByUrunAdi(ListView lv, string urunAdi)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Urunler where Durum=0 and UrunAd like '%' + @UrunAdi + '%'", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = urunAdi;
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
                    lv.Items[sayac].SubItems.Add(dr["KategoriId"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["UrunAd"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Aciklama"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["Fiyat"].ToString()));
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
        //Ürün ekle
        public int UrunEkle(cUrunler cUrunler)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into Urunler(UrunAd,KategoriId,Aciklama,Fiyat) values(@UrunAd,@KategoriId,@Aciklama,@Fiyat)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = cUrunler._urunad;
                cmd.Parameters.Add("@KategoriId", SqlDbType.Int).Value = cUrunler._urunTurNo;
                cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = cUrunler._aciklama;
                cmd.Parameters.Add("@Fiyat", SqlDbType.Money).Value = cUrunler._fiyat;
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
        //Ürün ve kategori listeleme
        public void UrunleriListele(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select Urunler.*,KategoriAdi from Urunler inner join Kategoriler on Kategoriler.ID=Urunler.KategoriId where Urunler.Durum=0", con);
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
                    lv.Items[sayac].SubItems.Add(dr["KategoriId"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KategoriAdi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["UrunAd"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["Fiyat"].ToString()));
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
        //Ürün Güncelle
        public int UrunGuncelle(cUrunler cUrunler)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update Urunler set UrunAd=@UrunAd,KategoriId=@KategoriId,Aciklama=@Aciklama,Fiyat=@Fiyat where ID=@UrunId", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = cUrunler._urunId;
                cmd.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = cUrunler._urunad;
                cmd.Parameters.Add("@KategoriId", SqlDbType.Int).Value = cUrunler._urunTurNo;
                cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = cUrunler._aciklama;
                cmd.Parameters.Add("@Fiyat", SqlDbType.Money).Value = cUrunler._fiyat;
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
        //Ürün Sil
        public int UrunSil(cUrunler cUrunler, int kat)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            //SqlCommand cmd = new SqlCommand("update Urunler set Durum=1 where ID=@UrunId", con);
            string sql = "update Urunler set Durum=1 where ";
            if (kat == 0)
                sql += "KategoriId=@UrunId";
            else
                sql += "ID=@UrunId";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = cUrunler._urunId;
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
        //Ürün ID göre listeleme
        public void UrunleriListeleByUrunId(ListView lv, int urunId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select Urunler.*,KategoriAdi from Urunler inner join Kategoriler on Kategoriler.ID=Urunler.KategoriId where Urunler.Durum=0 and Urunler.KategoriId=@UrunId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@UrunId", SqlDbType.Int).Value = urunId;
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
                    lv.Items[sayac].SubItems.Add(dr["KategoriId"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["KategoriAdi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["UrunAd"].ToString());
                    lv.Items[sayac].SubItems.Add(string.Format("{0:0#00.0}", dr["Fiyat"].ToString()));
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
        //Bütün ürünlerin 2 tarih arası istatistiksel listelenmesi
        public void UrunleriListeleIstatistiklereGore(ListView lv, DateTimePicker Baslangic, DateTimePicker Bitis)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select top 10 dbo.Urunler.UrunAd, sum(dbo.Satislar.Adet) as Adeti from dbo.Kategoriler inner join dbo.Urunler on" +
                                            "dbo.Kategoriler.ID = dbo.Urunler.KategoriId inner join dbo.Satislar on" +
                                            "dbo.Urunler.ID = dbo.Satislar.UrunId inner join dbo.Adisyonlar on" +
                                            "dbo.Satislar.AdisyonId = dbo.Adisyonlar.ID where" +
                                            "(convert(datetime, Tarih, 104) between convert(datetime, '01.01.2013', 104) and convert(datetime, '01.01.2015', 104))" +
                                            "group by dbo.Urunler.UrunAd order by Adeti desc", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = Baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = Bitis.Value.ToShortDateString();
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
                    lv.Items[sayac].SubItems.Add(dr["UrunAd"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Adeti"].ToString());
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
        //Seçilen ürünlerin istatistiksel listelenmesi
        public void UrunleriListeleIstatistiklereGoreUrunId(ListView lv, DateTimePicker Baslangic, DateTimePicker Bitis, int UrunKatId)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select top 10 dbo.Urunler.UrunAd, sum(dbo.Satislar.Adet) as Adeti from dbo.Kategoriler inner join dbo.Urunler on " +
                                            "dbo.Kategoriler.ID = dbo.Urunler.KategoriId inner join dbo.Satislar on " +
                                            "dbo.Urunler.ID = dbo.Satislar.UrunId inner join dbo.Adisyonlar on " +
                                            "dbo.Satislar.AdisyonId = dbo.Adisyonlar.ID where " +
                                            "(convert(datetime, Tarih, 104) between convert(datetime, '01.01.2013', 104) and convert(datetime, '01.01.2015', 104)) " +
                                            "and (dbo.Urunler.KategoriId=@UrunKatId) group by dbo.Urunler.UrunAd order by Adeti desc", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@Baslangic", SqlDbType.VarChar).Value = Baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("@Bitis", SqlDbType.VarChar).Value = Bitis.Value.ToShortDateString();
            cmd.Parameters.Add("@UrunKatId", SqlDbType.Int).Value = UrunKatId;
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
                    lv.Items[sayac].SubItems.Add(dr["UrunAd"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["Adeti"].ToString());
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
    }
}
