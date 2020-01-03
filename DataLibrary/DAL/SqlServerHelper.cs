using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataLibrary.DAL
{
    public class SqlServerHelper
    {
        public static String CONNECTIONSTRING = ConfigurationManager.AppSettings["CONNECTIONSTRING"];
        /// <summary>
        /// Excute a SQL
        /// </summary>
        /// <param name="sql">SQL String</param>
        /// <param name="commandType">CommandType</param>
        /// <param name="pars">Sql parameter: "@Name", SqlDbType, Value ("@id",SqlDbType.int, 1 [, ...])</param>
        public static void ExecuteNonQuery(
            string sql,
            CommandType commandType,
            params object[] pars)
        {
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();

            System.Diagnostics.Debug.WriteLine(sql);

            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = commandType;
            com.CommandTimeout = 10000;
            for (int i = 0; i < pars.Length; i += 3)
            {
                SqlParameter par = new SqlParameter(pars[i].ToString(), pars[i + 1]);
                par.Value = pars[i + 2];
                com.Parameters.Add(par);
            }
            com.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable ExecuteDataTable(
                                          string sql,
                                          CommandType commandType,
                                          params object[] pars)
        {
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();

            System.Diagnostics.Debug.WriteLine(sql);

            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = commandType;
            com.CommandTimeout = 10000;
            for (int i = 0; i < pars.Length; i += 3)
            {
                SqlParameter par = new SqlParameter(pars[i].ToString(), pars[i + 1]);
                par.Value = pars[i + 2];
                com.Parameters.Add(par);
            }

            SqlDataAdapter dad = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            dad.Fill(dt);
            con.Close();
            return dt;
        }
    }
}

