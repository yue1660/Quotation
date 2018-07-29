using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quotation.Models
{
    public static class Global
    {
        /// <summary> 全局所有的DataContexts
        /// </summary>
        public static Dictionary<string, DataContext> MapDbContext = new Dictionary<string, DataContext>();


        public static DataContext GetDataContext(string dbPath)
        {
            if (MapDbContext.ContainsKey(dbPath) == false)
            {
                var connectionString = GetEntityConnectionString("Model1", dbPath);
                var db = new DataContext(connectionString);
                MapDbContext[dbPath] = db;
                return db;
            }

            return MapDbContext[dbPath];
        }



        /// <summary>
        /// 得到Entity的连接字符串
        /// </summary>
        /// <param name="edmxFullName">Edmx的包括命名空间的全名称</param>
        /// <param name="server">服务器地址或名称</param>
        /// <param name="dadaBase">数据库</param>
        /// <param name="usr">用户</param>
        /// <param name="pswd">密码</param>
        /// <param name="appName">程序名称</param>
        /// <returns>Entity连接字符串</returns>
        private static string GetEntityConnectionString(string edmxFullName, string path)
        {
            System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder entityConnectionStringBuilder =
               new System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder();
            entityConnectionStringBuilder.Metadata = "res://*/" + edmxFullName + ".csdl|res://*/" + edmxFullName + ".ssdl|res://*/" + edmxFullName + ".msl";
            entityConnectionStringBuilder.Provider = "System.Data.SQLite.EF6";

            System.Data.SQLite.SQLiteConnectionStringBuilder sqlConnectionStringBuilder = new System.Data.SQLite.SQLiteConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = path;
            entityConnectionStringBuilder.ProviderConnectionString = sqlConnectionStringBuilder.ToString();

            return entityConnectionStringBuilder.ConnectionString;
        }


    }
}
