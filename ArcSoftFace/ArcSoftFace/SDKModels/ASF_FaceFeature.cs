using System;

namespace ArcSoftFace.SDKModels
{
    /// <summary>
    /// 人脸特征结构体
    /// </summary>
    public struct ASF_FaceFeature
    {
        /// <summary>
        /// 特征值 byte[]
        /// </summary>
        public IntPtr feature;

        /// <summary>
        /// 结果集大小
        /// </summary>
        public int featureSize;
    }
}
