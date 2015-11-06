using System.Data.OleDb;

namespace GestionSociedad
{
    struct StructSoc
    {
        public  static OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\proyectos\GestionSociedad\GestionSociedad\data\Sociedad.accdb;Persist Security Info=True");
        
       

        
    }
}
