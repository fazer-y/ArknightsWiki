using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManage
{
    public class DBManager
    {
        // 服务器名
        private string serverName = "";
        // 数据库名
        private string databaseName = "";
        // 用户名
        private string userName = "";
        // 密码
        private string password = "";
        // 连接语句
        private string connectString = "";
        // Sql Server连接
        private SqlConnection connection;

        public DBManager(string serverName, string databaseName, string userName, string password)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.userName = userName;
            this.password = password;
            connectString = $"server={this.serverName};" +
                            $"database={this.databaseName};" +
                            $"uid={this.userName};" +
                            $"pwd={this.password}";
        }

        public void OpenDB()
        {
            connection = new SqlConnection(connectString);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            Console.WriteLine("数据库已连接");
        }

        public void CloseDB()
        {
            if (connection != null &&
                connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            Console.WriteLine("数据库已断开");
        }

        public int InsertData(string tableName, string value)
        {
            string insertSqlString = $"insert into {tableName} values {value}";
            //SqlCommand cmd = new SqlCommand(sql, connection);//简单写法
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = insertSqlString,
                Connection = connection
            };
            int result = cmd.ExecuteNonQuery();  // 执行增 删 改 操作
            return result;
        }

        public int ExecProc(string procedureName, string param)
        {
            string procSqlString = $"exec {procedureName} {param}";
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = procedureName,
                Connection = connection
            };
            int result = cmd.ExecuteNonQuery();  // 执行增 删 改 操作
            return result;
        }

        public SqlDataReader SelectData(string tableName,
                string options = "", string column = "*")
        {
            string selectSqlString = "";
            if (options != "")
                selectSqlString = $"select {column} from {tableName} where {options}";
            else
                selectSqlString = $"select {column} from {tableName}";
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = selectSqlString,
                Connection = connection
            };
            SqlDataReader result = cmd.ExecuteReader();  // 执行增 删 改 操作
            return result;
        }

        public bool UpdateData(string tableName,
                string value, string options = "")
        {
            string selectSqlString = "";
            if (options != "")
                selectSqlString = $"update {tableName} set {value} where {options}";
            else
                selectSqlString = $"update {tableName} set {value}";
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = selectSqlString,
                Connection = connection
            };
            cmd.ExecuteNonQuery();  // 执行增 删 改 操作
            return true;
        }
    }
}
