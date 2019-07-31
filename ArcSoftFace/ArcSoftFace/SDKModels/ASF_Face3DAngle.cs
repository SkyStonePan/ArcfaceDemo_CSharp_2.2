using System;

namespace ArcSoftFace.SDKModels
{
    /// <summary>
    /// 3D人脸角度检测结构体，可参考https://ai.arcsoft.com.cn/bbs/forum.php?mod=viewthread&tid=1459&page=1&extra=&_dsign=fd9e1a7a
    /// </summary>
    public struct ASF_Face3DAngle
    {
        public IntPtr roll;
        public IntPtr yaw;
        public IntPtr pitch;
        /// <summary>
        /// 是否检测成功，0成功，其他为失败
        /// </summary>
        public IntPtr status;
        public int num;
    }
}
