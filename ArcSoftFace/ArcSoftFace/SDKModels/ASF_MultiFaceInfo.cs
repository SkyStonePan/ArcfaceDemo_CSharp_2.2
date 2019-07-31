using System;

namespace ArcSoftFace.SDKModels
{
    /// <summary>
    /// 多人脸检测结构体
    /// </summary>
    public struct ASF_MultiFaceInfo
    {
        /// <summary>
        /// 人脸Rect结果集
        /// </summary>
        public IntPtr faceRects;

        /// <summary>
        /// 人脸角度结果集，与faceRects一一对应  对应ASF_OrientCode
        /// </summary>
        public IntPtr faceOrients;
        /// <summary>
        /// 结果集大小
        /// </summary>
        public int faceNum;
        /// <summary>
        /// face ID，IMAGE模式下不返回FaceID
        /// </summary>
        public IntPtr faceID;
    }
}
