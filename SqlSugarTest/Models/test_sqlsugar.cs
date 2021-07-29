using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace BanLv.Entities
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("test_sqlsugar")]
    public partial class test_sqlsugar
    {
        public test_sqlsugar()
        {

        }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:可空日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? date1 {get;set;}

           /// <summary>
           /// Desc:不可空日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime date2 {get;set;}

    }
}