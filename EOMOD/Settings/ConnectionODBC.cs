using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOMOD.Settings
{
    class ConnectionODBC
    {
        private OdbcConnection DbConnection;

        private OdbcDataReader DataReader;

        private String ConnectionString;
        public String CommandSqlText { set; get; }

        public ConnectionODBC()
        {
            this.ConnectionString = String.Format("DSN={0}",ConfigurationManager.ConnectionStrings["OdbcConnectionString"].ToString());
            this.LoadConnection();
        }

        public ConnectionODBC(String ConnectionStringValue )
        {
            this.ConnectionString = ConnectionStringValue;
            this.LoadConnection();

        }

        private void LoadConnection()
        {
            this.DbConnection = new OdbcConnection();
            this.DbConnection.ConnectionString = this.ConnectionString;
        }
  
        private void OpenConnection()
        { 
            try
            {
                DbConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error de conexion con la base de datos");
            }
        }

        private void CloseConnection()
        {
            this.DbConnection.Close();
        }

        public void ExecuteNonQuery()
        {
            this.OpenConnection();
            OdbcCommand DbCommand = this.DbConnection.CreateCommand();

            DbCommand.CommandText = this.CommandSqlText;
            DbCommand.ExecuteNonQuery();

            DbCommand.Dispose();
            this.CloseConnection();
        }

        public void ExecuteNonQuery(OdbcParameterCollection DatosParams)
        {
            this.OpenConnection();
            OdbcCommand DbCommand = this.DbConnection.CreateCommand();
            OdbcParameterCollection parameters = DbCommand.Parameters;
            parameters = DatosParams;

            DbCommand.CommandText = this.CommandSqlText;
            
            DbCommand.ExecuteNonQuery();

            DbCommand.Dispose();
            this.CloseConnection();
        }

        public DataTable ExecuteAdapterQuery()
        {
            DataTable myResult = new DataTable();

            this.OpenConnection();
            OdbcCommand DbCommand = this.DbConnection.CreateCommand();
            DbCommand.CommandText = this.CommandSqlText;
            DbCommand.Connection = this.DbConnection;
            OdbcDataAdapter DataAdapter = new OdbcDataAdapter(DbCommand);

            DataAdapter.Fill(myResult);

            DataAdapter.Dispose();
            DbCommand.Dispose();
            this.CloseConnection();

            return myResult;
        }


        public OdbcDataReader ExecuteReadQuery()
        {
            this.OpenConnection();
            OdbcCommand DbCommand = this.DbConnection.CreateCommand();
            DbCommand.CommandText = this.CommandSqlText;
            DbCommand.Connection = this.DbConnection;

            this.DataReader = DbCommand.ExecuteReader();

            DbCommand.Dispose();
            return DataReader;
        }

        public void CloseExecuteReadQuery()
        {
            this.DataReader.Close();
            this.CloseConnection();
        }

    }
}
