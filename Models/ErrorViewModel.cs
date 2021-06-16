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
    /// �^�ǰT��
    /// </summary>
    public class ReturnMsg
    {
        /// <summary>
        /// ���Ҧ��\�P�_(true:���\ false:����)
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// ���ҰT��(�ΥH�e��alert�T�����)
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// ���Ҷ��ة���
        /// </summary>
        public List<ValidationItem> ValidationItemList { get; set; }
    }

    /// <summary>
    /// ���Ҷ���
    /// </summary>
    public class ValidationItem
    {
        /// <summary>
        /// ����Key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// ���Ҷ��ذT��
        /// </summary>
        public string Msg { get; set; }
    }
}
