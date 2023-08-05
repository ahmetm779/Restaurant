using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    class cPersonel
    {
        cGenel cGenel = new cGenel();
        #region Fields
        private int _PersonelId;
        private int _Gorevıd;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;
        #endregion
        #region Properties
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int Gorevıd { get => _Gorevıd; set => _Gorevıd = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public string PersonelParola { get => _PersonelParola; set => _PersonelParola = value; }
        public string PersonelKullaniciAdi { get => _PersonelKullaniciAdi; set => _PersonelKullaniciAdi = value; }
        public bool PersonelDurum { get => _PersonelDurum; set => _PersonelDurum = value; }
        #endregion


        public bool personelEntryControl(string password, int UserId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("select * from Personel where ID=@Id and Parola=@password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
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

            return result;
        }
        public void PersonelGetByInformation(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("select * from Personel", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cPersonel p = new cPersonel();
                p._PersonelId = Convert.ToInt32(dr["ID"]);
                p._Gorevıd = Convert.ToInt32(dr["GorevId"]);
                p._PersonelAd = Convert.ToString(dr["Ad"]);
                p._PersonelSoyad = Convert.ToString(dr["Soyad"]);
                p._PersonelParola = Convert.ToString(dr["Parola"]);
                p._PersonelKullaniciAdi = Convert.ToString(dr["KullaniciAdi"]);
                p._PersonelDurum = Convert.ToBoolean(dr["Durum"]);
                comboBox.Items.Add(p);
            }
            dr.Close();
            con.Close();

        }
        public override string ToString()
        {
            return PersonelKullaniciAdi;
        }
    }
}
