using System;

namespace ArcSoftFace.SDKModels
{
    /// <summary>
    /// 人脸检测优先角度结构体，推荐ASF_OP_0_HIGHER_EXT
    /// </summary>
    public struct ASF_OrientPriority
    {
        public const int ASF_OP_0_ONLY = 0x1;
        public const int ASF_OP_90_ONLY = 0x2;
        public const int ASF_OP_270_ONLY = 0x3;
        public const int ASF_OP_180_ONLY = 0x4;
        public const int ASF_OP_0_HIGHER_EXT = 0x5;
    }
}
