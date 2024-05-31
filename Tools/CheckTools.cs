#region << 版 本 注 释 >>
/*----------------------------------------------------------------
 * 版权所有 (c) 2024 Microsoft  保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：QINGFENG
 * 公司名称：Microsoft
 * 命名空间：MatrixForm.Tools
 * 唯一标识：a9922525-a3d6-4f7c-9b84-e43f2eef031e
 * 文件名：CheckTools
 * 当前用户域：QINGFENG
 * 
 * 创建者：matrix
 * 电子邮箱：xxxx@hotmail.com
 * 创建时间：2024/5/31 星期五 17:46:05
 * 版本：V1.0.0
 * 描述：
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


namespace MatrixForm.Tools
{
    /// <summary>
    /// 检测空对象公共方法
    /// </summary>
    internal class CheckTools
    {
        // 通用方法，仅检查null  
        public static bool IsNullOrEmptyObject(object obj)
        {
            return obj == null;
        }

        // 特定于字符串的方法  
        public static bool IsNullOrEmptyString(string str)
        {
            return string.IsNullOrEmpty(str);
        }

        // 特定于数组的方法（以int数组为例）  
        public static bool IsNullOrEmptyArray<T>(T[] array)
        {
            return array == null || array.Length == 0;
        }

        // 特定于List的方法（以List<int>为例）  
        public static bool IsNullOrEmptyList<T>(IList<T> list)
        {
            return list == null || list.Count == 0;
        }
    }
}
