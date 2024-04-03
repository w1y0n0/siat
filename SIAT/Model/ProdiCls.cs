using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SIAT.Model
{
    using Konfigurasi;

    class ProdiCls
    {
        private string _kode;
        private string _nama_prodi;

        KoneksiDBCls dbServer;
        DataTable dtTabel;
        string Query="";

        public ProdiCls()
        {
            _kode = "";
            _nama_prodi = "";

            dbServer = new KoneksiDBCls();
            dtTabel = new DataTable();
        }

        //property
        public string Kode
        {
            set { _kode = value; }
            //get { return _kode; }
        }

        public string Nama_Prodi
        {
            set { _nama_prodi = value; }
        }

        //method
        public bool apakahAda(string kd)
        {
            bool cek = false;
            Query = "select * from prodi where kode_prodi='" + kd + "'";
            dtTabel = dbServer.eksekusiQuery(Query);

            if (dtTabel.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public void simpan()
        {
            Query = "insert into prodi values ('"+ _kode +"','"+ _nama_prodi +"')";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Proses tambah data gagal.");
            }

        }

        public void ubah(string kd)
        {
            Query = "update prodi set nama_prodi='"+ _nama_prodi +
                    "' where kode_prodi='"+ kd +"'";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Proses ubah data gagal.");
            }
        }

        public void hapus(string kd)
        {
            Query = "delete from prodi where kode_prodi='" + kd + "'";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Proses hapus data gagal.");
            }
        }

        public DataTable tampilSemua()
        {
            Query = "select * from prodi";

            return dbServer.eksekusiQuery(Query);
        }
    }
}
