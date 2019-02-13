using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;

namespace PreactorASPCore.Models.OracleData
{
    public class OracleRepository
    {
        private string host = "prod.vit.belwest.com";
        private int port = 1521;
        private string sid = "orcl.Belw-MPUDB";
        private string user = "SergeyTrofimov";
        private string password = "jC7EGzQ1pX";

        private OracleConnection GetDBConnection()
        {
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                                + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                                + sid + ")));Password=" + password + ";User ID=" + user;
            OracleConnection conn = new OracleConnection
            {
                ConnectionString = connString
            };
            return conn;
        }

        public List<T> GetEntities<T>() where T : class, new()
        {
            var list = new List<T>();
            using (OracleConnection con = GetDBConnection())
            {
                string SQLCommand = "select * from belwpr." + typeof(T).Name;
                con.Open();
                OracleCommand comm = new OracleCommand(SQLCommand, con);
                var reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    T res = new T();
                    var type = res.GetType();
                    foreach (var field in type.GetProperties())
                    {
                        var val = reader[field.Name];
                        field.SetValue(res, val);
                    }
                    list.Add(res);
                }
            }

            return list;
        }
    }
}
