using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            //@ para que use o literal sen escapar no string
            using(OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"+@"Data Source='C:\Users\a10jesuslb\Desktop\Base de datos1.accdb'"))
            {
              
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from Probas",cnn);
                
            }
        }
    }
}
