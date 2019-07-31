using System;

namespace ArcSoftFace.SDKModels
{
    /// <summary>
    /// 单人脸检测结构体
    /// </summary>
    public struct ASF_SingleFaceInfo
    {
        /// <summary>
        /// 人脸坐标Rect结果
        /// </summary>
        public MRECT faceRect;
        /// <summary>
        /// 人脸角度
        /// </summary>
        public int faceOrient;
    }
}
