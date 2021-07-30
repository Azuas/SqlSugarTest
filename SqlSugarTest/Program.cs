using BanLv.Entities;
using SqlSugar;
using SqlSugarTest.Models;
using System;

namespace SqlSugarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "Server=XXXX;Port=XXXX;Charset=utf8mb4;DataBase=XXX;Persist Security Info=False;User ID=XXX;Password=XXXX;Allow Zero Datetime=true;Allow User Variables=True",//连接符字串
                DbType = DbType.MySql,
                IsAutoCloseConnection = true, //不设成true要手动close
                InitKeyType = InitKeyType.Attribute,
            });

            var t1 = db.Queryable<test_sqlsugar>()
                .Where(w => w.id == 1)
                .Select(s => new
                {
                    id = s.id,
                    date1 = s.date1
                }).First();

            try
            {
                var t2 = db.Queryable<test_sqlsugar>()
                .Where(w => w.id == 1)
                .Select(s => new
                {
                    id = s.id,
                    date1 = s.date1,
                    date2 = s.date2//不可空类型会报错2
                }).First();
            }
            catch (Exception ex)
            {

            }

            var t3= db.Queryable<test_sqlsugar>()
                .Where(w => w.id == 1)
                .Select(s => new test_sqlsugar_temp
                {
                    id = s.id,
                    date1 = s.date1,
                    date2 = s.date2
                }).First();
        }
    }
}
