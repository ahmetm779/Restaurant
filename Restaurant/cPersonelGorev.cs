using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    class cPersonelGorev
    {
        cGenel gnl = new cGenel();

        private int _personelGorevId;
        private string _tanim;

        public int PersonelGorevId { get => _personelGorevId; set => _personelGorevId = value; }
        public string Tanim { get => _tanim; set => _tanim = value; }

        public void PersonelGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from PersonelGorevleri", con);
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
                    cPersonelGorev c = new cPersonelGorev();
                    c._personelGorevId = Convert.ToInt32(dr["ID"].ToString());
                    c._tanim = dr["Gorev"].ToString();
                    cb.Items.Add(c);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public string PersonelGorevTanim(int personel)
        {
            string sonuc = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select Gorev from PersonelGorevleri where ID=@personelId", con);
            cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = personel;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Dispose();
            con.Close();
            return sonuc;
        }
        public override string ToString()
        {
            return _tanim;
        }
    }
}
