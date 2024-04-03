using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SIAT.Konfigurasi
{
    abstract class ServerCls
    {
        // unt menangani instruksi SELECT
        public abstract DataTable eksekusiQuery(string query);

        // unt menangani instruksi INSERT,UPDATE,DELETE
        public abstract int eksekusiNonQuery(string query);
    }
}
