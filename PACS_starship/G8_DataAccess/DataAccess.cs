using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;

namespace G8_DataAccess
{
    public class DataAccess
    {
        public SqlConnection conn;
        public DataSet dts;
        //public string projectName;

        public void encryptConnectionString()
        {

#if DEBUG
            string applicationName = Environment.GetCommandLineArgs()[0];
#else
                string applicationName = Environment.GetCommandLineArgs()[0]+ ".exe";
#endif

            string exePath = System.IO.Path.Combine(Environment.CurrentDirectory, applicationName);
            Configuration conf = ConfigurationManager.OpenExeConfiguration(exePath);

            ConnectionStringsSection section = conf.GetSection("connectionStrings")
            as ConnectionStringsSection;

        }

        public string connectionString(string ProjectName)
        {
            string connectString = ConfigurationManager.ConnectionStrings[ProjectName+ ".Properties.Settings.SecureCoreConnectionString"].ToString();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);

            connectString = "Data Source = " + Environment.MachineName.ToString() + connectString.Substring(connectString.IndexOf('\\')); //Manually set computer name

            return connectString;
        }

        public void connectToDDBB(string ProjectName)
        {
            string cnx;
            cnx = connectionString(ProjectName);
            conn = new SqlConnection(cnx);
        }

        public DataSet getByTable(string table_name, string ProjectName)
        {
            dts = new DataSet();

            connectToDDBB(ProjectName);

            SqlDataAdapter adapter;

            string query = "select * from " + table_name;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, table_name);

            conn.Close();

            return dts;
        }

        public DataSet getByQuery(string consulta, string ProjectName)
        {
            connectToDDBB(ProjectName);

            SqlDataAdapter adapter;

            string query = consulta;
            adapter = new SqlDataAdapter(query, conn);
            DataSet dataset_portarperconsulta = new DataSet();

            conn.Open();

            adapter.Fill(dataset_portarperconsulta);

            conn.Close();

            return dataset_portarperconsulta;
        }

        public DataSet getByQuery(string consulta, string dataset_name, string ProjectName)
        {
            connectToDDBB(ProjectName);

            SqlDataAdapter adapter;

            string query = consulta;
            adapter = new SqlDataAdapter(query, conn);
            DataSet dataset_portarperconsulta = new DataSet();

            conn.Open();

            adapter.Fill(dataset_portarperconsulta, dataset_name);

            conn.Close();

            return dataset_portarperconsulta;
        }

        public bool updateDDBB(DataSet dts, string bbdd_tablename, string ProjectName)
        {
            bool correct = false;

            connectToDDBB(ProjectName);
            conn.Open();

            string query = "select * from " + bbdd_tablename;
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);


            if (dts.HasChanges())
            {
                int result = adapter.Update(dts.Tables[0]);
                correct = true;
            }

            conn.Close();

            return correct;
        }

        public void executeQuery(string consulta, string ProjectName)
        {
            string query = consulta;

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            int registresAfectats = cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public string GetTableData(string nomCamp, string query, string ProjectName)
        {
            connectToDDBB(ProjectName);

            SqlDataAdapter adapterLocal = new SqlDataAdapter(query, conn);

            DataSet dts = new DataSet();

            conn.Open();
            adapterLocal.Fill(dts);
            conn.Close();

            return dts.Tables[0].Rows[0][nomCamp].ToString();
        }
    }
}
