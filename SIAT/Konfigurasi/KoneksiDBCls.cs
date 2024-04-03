using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace SIAT.Konfigurasi
{
    class KoneksiDBCls:ServerCls
    {
        MySqlConnection mCon;
        MySqlCommand mCom;
        MySqlDataAdapter mAdp;

        string server = "server=localhost;port=3306;database=siat;uid=root;pwd=";

        public KoneksiDBCls()
        {
            mCon = new MySqlConnection(server);
            mCom = new MySqlCommand();
            mAdp = new MySqlDataAdapter();
        }

        private void bukaKoneksi()
        {
            if (mCon.State == ConnectionState.Closed)
            {
                try
                {
                    mCon.Open();
                }
                catch (Exception e) { }
            }
        }

        private void tutupKoneksi()
        {
            mCon.Close();
        }

        public override int eksekusiNonQuery(string query)
        {
            int kembalian = -1;

            try
            {
                bukaKoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                kembalian = mCom.ExecuteNonQuery();
            }
            catch (Exception e) { }
            finally
            {
                tutupKoneksi();
            }

            return kembalian;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable kembalian = new DataTable();

            try
            {
                bukaKoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                mAdp.SelectCommand = mCom;
                mAdp.Fill(kembalian);
            }
            catch (Exception e) { }
            finally
            {
                tutupKoneksi();
            }

            return kembalian;
        }
    }
}
