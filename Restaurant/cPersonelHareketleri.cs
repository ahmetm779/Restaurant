using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    class cPersonelHareketleri
    {
        cGenel cGenel = new cGenel();
        #region Fields
        private int _Id;
        private int _PersonelId;
        private string _Islem;
        private DateTime _Tarih;
        private bool _Durum;
        #endregion
        #region Properties
        public int Id { get => _Id; set => _Id = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public bool Durum { get => _Durum; set => _Durum = value; }
        #endregion


        public bool PersonelActionSave(cPersonelHareketleri personelHareketleri)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(cGenel.conString);
            SqlCommand cmd = new SqlCommand("insert into PersonelHareketleri(PersonelId,Islem,Tarih) values (@personelId,@Islem,@Tarih)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = personelHareketleri._PersonelId;
                cmd.Parameters.Add("@Islem", SqlDbType.VarChar).Value = personelHareketleri._Islem;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = personelHareketleri._Tarih;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return true;
        }
    }
}
