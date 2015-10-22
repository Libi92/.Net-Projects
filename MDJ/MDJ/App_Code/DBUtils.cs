using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDJ.App_Code
{
    public class DBUtils
    {
        //public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MDJConnectionString"].ConnectionString;

        public static string connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\Libin\\documents\\visual studio 2013\\Projects\\MDJ\\MDJ\\App_Data\\MDJ.mdf\";Integrated Security=True";

        public static SqlDataReader dataReader;
        public static SqlConnection connection;
        public static SqlCommand command;

        public static Dictionary<string, SqlDbType> paramTypes = new Dictionary<string, SqlDbType>()
        {
            {"varchar", SqlDbType.VarChar},
            {"nvarchar", SqlDbType.NVarChar},
            {"int", SqlDbType.Int},
            {"float", SqlDbType.Float}
        };

        public static void connect()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static void insertData(string method, QueryParamter[] parameters)
        {
            connect();
            command = new SqlCommand(method, connection);
            command.CommandType = CommandType.StoredProcedure;

            foreach (QueryParamter parameter in parameters)
            {
                command.Parameters.Add("@" + parameter.Name, paramTypes[parameter.Type]).Value = parameter.Value;
            }

            command.ExecuteNonQuery();

        }

        public static string getValue(string method, QueryParamter[] parameters, QueryParamter result)
        {
            connect();
            command = new SqlCommand(method, connection);
            command.CommandType = CommandType.StoredProcedure;

            foreach (QueryParamter parameter in parameters)
            {
                command.Parameters.Add("@" + parameter.Name, paramTypes[parameter.Type]).Value = parameter.Value;
            }

            SqlParameter parameterResult = command.Parameters.Add("@" + result.Name, paramTypes[result.Type]);
            parameterResult.Direction = ParameterDirection.Output;
            parameterResult.Size = 50;

            command.ExecuteNonQuery();


            return parameterResult.Value.ToString();
        }

        public static DataSet getDataSet(string method, QueryParamter[] parameters)
        {
            connect();
            command = new SqlCommand(method, connection);
            command.CommandType = CommandType.StoredProcedure;

            foreach (QueryParamter parameter in parameters)
            {
                command.Parameters.Add("@" + parameter.Name, paramTypes[parameter.Type]).Value = parameter.Value;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            return dataset;
        }

        public static DataTable getDataTable(string method, QueryParamter[] parameters)
        {
            connect();
            command = new SqlCommand(method, connection);
            command.CommandType = CommandType.StoredProcedure;

            foreach (QueryParamter parameter in parameters)
            {
                command.Parameters.Add("@" + parameter.Name, paramTypes[parameter.Type]).Value = parameter.Value;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }

    public class QueryParamter
    {
        public string Name;
        public string Type;
        public string Value;

        public QueryParamter(string name, string value, string type)
        {
            this.Name = name;
            this.Type = type;
            this.Value = value;
        }
    }
}
