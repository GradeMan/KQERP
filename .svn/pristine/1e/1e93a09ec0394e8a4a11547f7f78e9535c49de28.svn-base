using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Util
{
    /****************
     * Get system icons
     * by conmajia@gmail.com ==> find me @ csdn.com
     * 2012-5-8
     * Springbear
     * 
     * This class has static methods to get
     * explorer icons by file extensions.
     * 
     * NOTE: this class is based on some anonymous
     * guy's work, thanks for all OPEN SOURCE
     * contributors!!
     * *************/
    public class WindowsHelper
    {
        #region Windows API
        [DllImport("Shell32.dll")]
        static extern int SHGetFileInfo(
            string pszPath,
            uint dwFileAttributes,
            ref   SHFILEINFO psfi,
            uint cbFileInfo,
            uint uFlags
            );

        struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            public char szDisplayName;
            public char szTypeName;
        }

        #endregion

        #region Methods
        // below is based on anonymous guy's work.
        /// <summary>
        /// 从文件扩展名得到文件关联图标
        /// </summary>
        /// <param name="fileName">文件名或文件扩展名</param>
        /// <param name="smallIcon">是否是获取小图标，否则是大图标</param>
        /// <returns>图标</returns>
        public static Icon FromExtension(string filePathOrExtension, bool small)
        {
            if (filePathOrExtension[0] != '.')
                filePathOrExtension = "." + filePathOrExtension;
            SHFILEINFO info = new SHFILEINFO();
            Icon icon = null;

            int total = (int)SHGetFileInfo(
                filePathOrExtension,
                100,
                ref info,
                0,
                (uint)(small ? 273 : 272)
                );
            if (total > 0)
            {
                icon = Icon.FromHandle(info.hIcon);
            }
            return icon;
        }
        #endregion
    }
}
