using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COM.Data
{
    public class PagingModel
    {
        /// <summary>
        /// 以1开始计
        /// </summary>
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int ItemCount { get; set; }
        public PagingModel()
        {
            this.ItemCount = 0;
            this.PageIndex = 1;
            this.PageSize = 20;
        }

        public int MaxPageIndex
        {
            get
            {
                return this.ItemCount / this.PageSize + (this.ItemCount % this.PageSize > 0 ? 1 : 0);
            }
        }

        public int FirstIndexOfPage
        {
            get
            {
                return (PageIndex - 1) * PageSize + 1;
            }
        }

        public int LastIndexOfPage
        {
            get
            {
                return PageIndex * PageSize > ItemCount ? ItemCount : PageIndex * PageSize;
            }
        }
    }
}


