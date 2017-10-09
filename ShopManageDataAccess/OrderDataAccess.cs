using System;
using Dapper;
using System.Collections.Generic;
using ShopManageContact;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace ShopManageDataAccess
{
    public class OrderDataAccess
    {
        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <returns></returns>
        public async Task<List<Order>> GetOrderList()
        {
            var list = new List<Order>();
            using (var context = new MySqlConnection(DbConnection.ShopManageConnection))
            {
                list=await context.ExecuteScalarAsync<List<Order>>("select * from Order");
            }
            return list;
        }
    }
}
