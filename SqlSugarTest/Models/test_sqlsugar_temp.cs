using System;
using System.Collections.Generic;
using System.Text;

namespace SqlSugarTest.Models
{
    public class test_sqlsugar_temp
    {
        public int id { get; set; }

        /// <summary>
        /// Desc:可空日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? date1 { get; set; }

        /// <summary>
        /// Desc:不可空日期
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime date2 { get; set; }
    }
}
