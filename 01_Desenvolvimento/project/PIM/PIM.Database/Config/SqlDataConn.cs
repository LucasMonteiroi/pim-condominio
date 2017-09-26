namespace PIM.Database.Config
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SqlDataConn
    {
        private static string _connectionStringHomolog = @"";
        private static string _connectionStringProd = @"";
        private static SqlDataConn _instance;

        #region --- Singleton ---

        public SqlDataConn()
        {

        }

        public static SqlDataConn GetInstance()
        {
            if (_instance == null)
                _instance = new SqlDataConn();
            return _instance;
        }

        #endregion --- Singleton ---

        public DataSet ExecuteSelect(string querySql)
        {
            using (SqlConnection conn = new SqlConnection(_connectionStringHomolog))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(querySql, conn);

                DataSet resultSet = new DataSet();
                adapter.Fill(resultSet);
                adapter.Dispose();

                return resultSet;
            }
        }

        //Todo: Implementar classe de retorno
        public void ExecuteInsert(string querySql)
        {
            using (SqlConnection conn = new SqlConnection(_connectionStringHomolog))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = querySql
                };

                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0)
                {
                    //Todo: Implementar tratativa
                }
                else
                {
                    //Todo: Implementar tratativa
                }
            }
        }
    }
}
