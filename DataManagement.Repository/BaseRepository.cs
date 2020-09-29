using System;
using System.Data;
using System.Data.SqlClient;

namespace DataManagement.Repository
{
    public class  BaseRepository : IDisposable
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectionString = "Data Source=.; Initial Catalog=SampleDB; Integrated Security=False";
            con = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            //throw new NotImplementedException();  
        }
    }

}  
