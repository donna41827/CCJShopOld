using System;
using System.Collections.Generic;

namespace CCJShop.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    /// <summary>
    /// 回傳訊息
    /// </summary>
    public class ReturnMsg
    {
        /// <summary>
        /// 驗證成功與否(true:成功 false:失敗)
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 驗證訊息(用以前端alert訊息顯示)
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 驗證項目明細
        /// </summary>
        public List<ValidationItem> ValidationItemList { get; set; }
    }

    /// <summary>
    /// 驗證項目
    /// </summary>
    public class ValidationItem
    {
        /// <summary>
        /// 項目Key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 驗證項目訊息
        /// </summary>
        public string Msg { get; set; }
    }
}
