using System;

namespace ArcSoftFace.Entity
{
    public class ImageInfo
    {
        /// <summary>
        /// 图片的像素数据
        /// </summary>
        public IntPtr imgData { get; set; }

        /// <summary>
        /// 图片像素宽
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// 图片像素高
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// 图片格式
        /// </summary>
        public int format { get; set; }
    }
}
