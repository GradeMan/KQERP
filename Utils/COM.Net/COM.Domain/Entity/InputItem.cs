using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COM.Domain
{
    /// <summary>
    /// 下拉输入项实体
    /// </summary>
    public class InputItem
    {
        private string name;
        private string code;
        /// <summary>
        /// 文本值
        /// </summary>
        public virtual string DisPlayName
        {
            get
            {
                return this.name;
            }
            set
            {
                //if (String.IsNullOrEmpty(value))
                //    throw new ApplicationException();
                this.name = value;
            }
        }
        /// <summary>
        /// 编码
        /// </summary>
        public virtual string Value
        {
            get
            {
                return this.code;
            }
            set
            {
                //if (String.IsNullOrEmpty(value))
                //    throw new ApplicationException();
                this.code = value;
            }
        }
        public virtual Guid Value2 { get; set; }
        /// <summary>
        /// 助记码
        /// </summary>
        public virtual string InputCode1 { get; set; }
        /// <summary>
        /// 助记码2
        /// </summary>
        public virtual string InputCode2 { get; set; }
        /// <summary>
        /// 助记码3
        /// </summary>
        public virtual string InputCode3 { get; set; }

        /// <summary>
        /// 助记码4
        /// </summary>
        public virtual string InputCode4 { get; set; }

        /// <summary>
        /// 助记码5
        /// </summary>
        public virtual string InputCode5 { get; set; }
    }
}
