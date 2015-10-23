using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace GestionSociedad
{
    struct StructSoc
    {
        public  static OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\a10jesuslb\Desktop\Sociedad.accdb'");
        
       

        
    }
}
