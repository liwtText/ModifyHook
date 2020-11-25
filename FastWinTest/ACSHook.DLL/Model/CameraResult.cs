using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ACSHook.DLL.Model
{
    /// <summary>
    /// 相机识别结果
    /// </summary>
    public class CameraResult
    {
        /// <summary>
        /// 摄像机编号
        /// </summary>
        public string cameraID = string.Empty;
        /// <summary>
        /// ip地址
        /// </summary>
        public string cameraip = string.Empty;
        /// <summary>
        /// 通道编号
        /// </summary>
        public int channelid = 0;
        /// <summary>
        /// 方向 0进 1出
        /// </summary>
        public int Direction = 0;
        /// <summary>
        /// 车牌号
        /// </summary>
        public string pateno = string.Empty;
        /// <summary>
        /// 抓拍图片路径
        /// </summary>
        public string imagePath = string.Empty;
        /// <summary>
        /// 发生时间
        /// </summary>
        public DateTime EventDt;
        /// <summary>
        /// 图片文件路径
        /// </summary>
        public string FilePath;
        /// <summary>
        /// 图片文件名称
        /// </summary>
        public string imgName;
        /// <summary>
        /// 相机品牌 D、H、E
        /// </summary>
        public char CameraBrand;
        /// <summary>
        /// 双相机处理的第二个识别结果
        /// </summary>
        public string secondCarCode = "";
        /// <summary>
        /// 抓拍图片信息
        /// </summary>
        public CameraImageResult cameraImageResult;
        /// <summary>
        /// 抓拍小图信息
        /// </summary>
        public CameraImageResult cameraImageResult2;
        /// <summary>
        /// 车辆类型
        /// </summary>
        public int CarType = 0;
        /// <summary>
        /// 车辆颜色
        /// </summary>
        public string CarColor = "未知";
        /// <summary>
        /// 车牌颜色
        /// </summary>
        public string Plate_Color;

        /// <summary>
        /// 特征码
        /// </summary>
        public string FeaturesCode;
        /// <summary>
        /// 车辆品牌
        /// </summary>
        public string CarBrand;
        /// <summary>
        /// 可信度
        /// </summary>
        public string Reliability = "1.0000";
        /// <summary>
        /// 是否待放行记录
        /// </summary>
        public bool IsExistsTempCarWait = false;
        /// <summary>
        /// 停车场ID
        /// </summary>
        public int ParkingLotID;
        /// <summary>
        /// 开闸类型
        /// </summary>
        public OpenGateType openGateType = OpenGateType.RecognitionOPenGate;
    }

    public class CameraImageResult
    {
        /// <summary>
        /// 抓拍相机ip
        /// </summary>
        public string cameraIp;
        /// <summary>
        /// 识别车牌号
        /// </summary>
        public string carCode;
        /// <summary>
        /// 图片大小
        /// </summary>
        public byte[] bs_img;
        /// <summary>
        /// 图片路径
        /// </summary>
        public string FilePath;
        /// <summary>
        /// 图片名称
        /// </summary>
        public string imageName;
        /// <summary>
        /// 是否车牌图片
        /// </summary>
        public bool isplate;
    }


    /// <summary>
    /// 开闸类型
    /// </summary>
    public enum OpenGateType
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        UnKnown = 0,
        /// <summary>
        /// 紧急开闸
        /// </summary>
        [Description("紧急开闸")]
        UrgentOpenGate = 1,
        /// <summary>
        /// 紧急关闸
        /// </summary>
        [Description("紧急关闸")]
        UrgentClosenGate = 2,
        /// <summary>
        /// 遥控开闸
        /// </summary>
        [Description("遥控开闸")]
        RemoteOpenGate = 3,
        /// <summary>
        /// 遥控关闸
        /// </summary>
        [Description("遥控关闸")]
        RemoteCloseGate = 4,
        /// <summary>
        /// 识别开闸
        /// </summary>
        [Description("识别开闸")]
        RecognitionOPenGate = 5,
        /// <summary>
        /// 解除紧急
        /// </summary>
        [Description("解除紧急")]
        RemoveUrgent = 6,
        /// <summary>
        /// 手控盒开闸
        /// </summary>
        [Description("手控盒开闸")]
        HandControlOpenGate = 7,
        /// <summary>
        /// 手控盒常开
        /// </summary>
        [Description("手控盒常开")]
        HandControlKeepOpenGate = 8,
        /// <summary>
        /// 取消手控盒常开
        /// </summary>
        [Description("取消手控盒常开")]
        HandControlRemoveKeepOpenGate = 9,
        /// <summary>
        /// 手控盒关闸
        /// </summary>
        [Description("手控盒关闸")]
        HandControlCloseGate = 10
    }
}
