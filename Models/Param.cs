using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCJShop.Models
{
    public class Param
    {
        /// <summary>
        /// 參數KEY
        /// </summary>
        public int ParamId { get; set; }
        /// <summary>
        /// 參數群組
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// 參數代碼
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 參數內容
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 參數群組說明
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 上層參數流水號(ParamId)
        /// </summary>
        public int UpParamId { get; set; }
    }
    public class ParamGroupViewModel 
    {
        public int GroupId { get; set; }
        public string Memo { get; set; }
    }
}
