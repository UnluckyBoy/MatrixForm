#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 版权所有 (c) 2024 Microsoft  保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：QINGFENG
 * 公司名称：Microsoft
 * 命名空间：MatrixForm.Tools
 * 唯一标识：2e9bd11c-3b6e-413b-8752-f9e1fb01f3a4
 * 文件名：DataBaseTool
 * 当前用户域：QINGFENG
 * 
 * 创建者：matrix
 * 电子邮箱：qfmy_zhang@163.com
 * 创建时间：2024/6/4 星期二 20:04:04
 * 版本：V1.0.0
 * 描述：数据库连接池
 *
 * ----------------------------------------------------------------
 * 修改人：
 * 时间：
 * 修改说明：
 *
 * 版本：V1.0.1
 *----------------------------------------------------------------*/
#endregion << 版 本 注 释 >>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace MatrixForm.Tools
{
    internal class DataBaseTool
    {
        public static List<Dictionary<string, object>> QuerySql(string sqlStr)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OracleConnectionString"].ConnectionString;
            List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(sqlStr, connection);
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read()) // 遍历所有的行
                {
                    Dictionary<string, object> row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader[i]); // 获取列名并将其与值一起添加到字典中
                    }
                    results.Add(row); // 将行字典添加到结果列表中
                }
                reader.Close(); // 可以不需要显式关闭,using会处理资源的释放
            }
            foreach (var row in results)
            {
                foreach (var column in row)
                {
                    Console.Write($"列名: {column.Key}, 值: {column.Value} ");
                }
                Console.WriteLine(); // 换行以区分不同的行
            }
            return results;
        }

        public static string Update(string sqlStr,string sqlKey)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OracleConnectionString"].ConnectionString;
            string updateSql = "update HWHISDBA.HWLIS_JYSQ set SGSCBZ='0' where sqid in ";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand selectCommand = new OracleCommand(sqlStr+ sqlKey, connection))
                    {
                        OracleDataReader reader = selectCommand.ExecuteReader();
                        if (reader.HasRows) // 检查是否有数据行  
                        {
                            Console.WriteLine("查询到数据。");
                            using (OracleCommand updateCommand = new OracleCommand(updateSql + sqlKey, connection))
                            {
                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                if (rowsAffected>0)
                                {
                                    return "success";
                                }
                                else
                                {
                                    return "意料之外的异常！";
                                }
                            }
                        }
                        else
                        {
                            //MessageBox.Show("条码号异常!请检查。。。");
                            return "条码号异常！请检查。。。";
                        }
                        //reader.Close(); //通常不需要手动关闭,因为using语句会处理它
                    }
                    //selectCommand.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("发生错误-" + ex.Message);
                    return ex.Message;
                }
            }
        }
    }
}
