using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace BLL
{
    public class DB
    {
        MySqlHelper mysql = new MySqlHelper();
        ///<summary>
        /// 通用删除方法
        /// </summary>
        /// <param value="要删除的值的条件" where="查询删除的条件" TableName="要删除数值的表名">SQL语句</param>
        /// <returns>返回删除成功或失败</returns>
        public string Delete(string value, string where, string TableName)
        {
            string sql = "delete from " + TableName + " where " + where + "=" + value;
            string sc;
            if (DAO.MySqlHelper.ExecuteSql(sql) < 1)
            {
                sc= "删除失败";
            }
            else
            {
                sc = "删除成功";
            }
            return sc;
        }
        ///<summary>
        /// 通用登录方法
        /// </summary>
        /// <param Name="用户" Pwd="密码" >SQL语句</param>
        /// <returns>返回删除成功或失败</returns>
        public bool Logo(string Name, string Pwd)
        {

            string sql = "select * from 数据库表名 where 用户名=" + Name + "and 密码=" + Pwd;

            return DAO.MySqlHelper.Exists(sql);
        }
    }
}
