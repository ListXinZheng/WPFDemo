using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAPP.DataAcess
{
    interface IDBOperator
    {
        /// <summary>
        /// 打开数据库
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        bool Open(string url);
        /// <summary>
        /// 关闭数据库
        /// </summary>
        /// <returns></returns>
        bool Close();
        /// <summary>
        /// 查
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        bool Query(string command);
        /// <summary>
        /// 删
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        bool Delete(string command);
        /// <summary>
        /// 改
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        bool Update(string command);
        /// <summary>
        /// 增
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        bool Add(string command);
        /// <summary>
        /// 全部删除
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        bool DeleteAll(string command);
    }
}
