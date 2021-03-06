using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IntArr = new int[] { 1, 2, 3, 4, 5 }; //整型数组
            List<int[]> ListCombination = PermutationAndCombination<int>.GetCombination(IntArr, 3); //求全部的3-3组合
            foreach (int[] arr in ListCombination)
            {
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        //static void Main(string[] args)
        //{
        //    DBManager dBManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
        //    dBManager.OpenDB();
        //    SqlDataReader reader = dBManager.SelectData("WikiPages", $"wikiTitle like '%12F' and wikiTags='干员资料'", "wikiPath"); ;
        //    int count = 1;
        //    while(reader.Read())
        //    {
        //        Console.WriteLine($"{count}"+reader["wikiPath"]);
        //        count++;
        //    }
        //    DateTime currentDateTime = DateTime.Now;
        //    Console.WriteLine(count);
        //    string times = currentDateTime.ToString().Replace("/", "_").Replace(" ", "_").Replace(':', '_');
        //    Console.WriteLine(times);
        //    FileStream stream = new FileStream("../test.txt", FileMode.Append, FileAccess.Write);
        //    string fileName = @"C:\Users\23887\Desktop\ArkWiki\References\md-fileloader-master\Program\MDLoader\bin\Debug\WikiPages/《假日终结》_2022_05_24_22_43_56.md";
        //    string changeTime = currentDateTime.ToString().Replace("/", "_").Replace(" ", "_").Replace(':', '_');
        //    string dirPath = fileName.Substring(0, fileName.IndexOf("/"));
        //    string oprName = fileName.Substring(fileName.IndexOf("/") + 1, fileName.IndexOf("_") - fileName.IndexOf("/") - 1);
        //    fileName = $"{dirPath}/{oprName}_{changeTime}.md";
        //    Console.WriteLine(fileName);
        //    Console.ReadKey();
        //}
    }

    internal class DBManager
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
                string options="", string column = "*")
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

    }
    public class PermutationAndCombination<T>
    {
        /// <summary>
        /// 交换两个变量
        /// </summary>
        /// <param name="a">变量1</param>
        /// <param name="b">变量2</param>
        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        /// <summary>
        /// 递归算法求数组的组合(私有成员)
        /// </summary>
        /// <param name="list">返回的范型</param>
        /// <param name="t">所求数组</param>
        /// <param name="n">辅助变量</param>
        /// <param name="m">辅助变量</param>
        /// <param name="b">辅助数组</param>
        /// <param name="M">辅助变量M</param>
        private static void GetCombination(ref List<T[]> list, T[] t, int n, int m, int[] b, int M)
        {
            for (int i = n; i >= m; i--)
            {
                b[m - 1] = i - 1;
                if (m > 1)
                {
                    GetCombination(ref list, t, i - 1, m - 1, b, M);
                }
                else
                {
                    if (list == null)
                    {
                        list = new List<T[]>();
                    }
                    T[] temp = new T[M];
                    for (int j = 0; j < b.Length; j++)
                    {
                        temp[j] = t[b[j]];
                    }
                    list.Add(temp);
                }
            }
        }
        /// <summary>
        /// 递归算法求排列(私有成员)
        /// </summary>
        /// <param name="list">返回的列表</param>
        /// <param name="t">所求数组</param>
        /// <param name="startIndex">起始标号</param>
        /// <param name="endIndex">结束标号</param>
        private static void GetPermutation(ref List<T[]> list, T[] t, int startIndex, int endIndex)
        {
            if (startIndex == endIndex)
            {
                if (list == null)
                {
                    list = new List<T[]>();
                }
                T[] temp = new T[t.Length];
                t.CopyTo(temp, 0);
                list.Add(temp);
            }
            else
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    Swap(ref t[startIndex], ref t[i]);
                    GetPermutation(ref list, t, startIndex + 1, endIndex);
                    Swap(ref t[startIndex], ref t[i]);
                }
            }
        }
        /// <summary>
        /// 求从起始标号到结束标号的排列，其余元素不变
        /// </summary>
        /// <param name="t">所求数组</param>
        /// <param name="startIndex">起始标号</param>
        /// <param name="endIndex">结束标号</param>
        /// <returns>从起始标号到结束标号排列的范型</returns>
        public static List<T[]> GetPermutation(T[] t, int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex > t.Length - 1)
            {
                return null;
            }
            List<T[]> list = new List<T[]>();
            GetPermutation(ref list, t, startIndex, endIndex);
            return list;
        }
        /// <summary>
        /// 返回数组所有元素的全排列
        /// </summary>
        /// <param name="t">所求数组</param>
        /// <returns>全排列的范型</returns>
        public static List<T[]> GetPermutation(T[] t)
        {
            return GetPermutation(t, 0, t.Length - 1);
        }
        /// <summary>
        /// 求数组中n个元素的排列
        /// </summary>
        /// <param name="t">所求数组</param>
        /// <param name="n">元素个数</param>
        /// <returns>数组中n个元素的排列</returns>
        public static List<T[]> GetPermutation(T[] t, int n)
        {
            if (n > t.Length)
            {
                return null;
            }
            List<T[]> list = new List<T[]>();
            List<T[]> c = GetCombination(t, n);
            for (int i = 0; i < c.Count; i++)
            {
                List<T[]> l = new List<T[]>();
                GetPermutation(ref l, c[i], 0, n - 1);
                list.AddRange(l);
            }
            return list;
        }
        /// <summary>
        /// 求数组中n个元素的组合
        /// </summary>
        /// <param name="t">所求数组</param>
        /// <param name="n">元素个数</param>
        /// <returns>数组中n个元素的组合的范型</returns>
        public static List<T[]> GetCombination(T[] t, int n)
        {
            if (t.Length < n)
            {
                return null;
            }
            int[] temp = new int[n];
            List<T[]> list = new List<T[]>();
            GetCombination(ref list, t, t.Length, n, temp, n);
            return list;
        }
    }
}
