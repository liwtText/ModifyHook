// #define BaseDataModify
using ACSHook.DLL.Model;
using DotNetDetour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACSHook.DLL.Service
{
    public class Process_RecognizePlateService : IMethodHook
    {
        /// <summary>
        /// 输入参数，用','隔开
        /// </summary>
        public static string InputParams = "reset";

#if BaseDataModify
        [HookMethod("Reformer.Parking.Process_Trigger.BaseData")]
        public void BaseData(string carCode, string serial, DateTime currentTime, [RememberType("ACS_Parking.Commons.VideoRecognition.CameraResult")] object result, [RememberType("ACS_Parking.Model.view_camerabychannel")] object triggerCamerabychannel)
        {
            if (!string.Equals(InputParams, "reset", StringComparison.OrdinalIgnoreCase))
            {
                carCode = InputParams;
            }
            BaseData_Original(carCode, serial, currentTime, result, triggerCamerabychannel);
        }

        [OriginalMethod]
        public void BaseData_Original(string carCode, string serial, DateTime currentTime, [RememberType("ACS_Parking.Commons.VideoRecognition.CameraResult")] object result, [RememberType("ACS_Parking.Model.view_camerabychannel")] object triggerCamerabychannel)
        {
            return;
        }
#else
        [HookMethod("Reformer.Parking.Process_Trigger.Process_Camera")]
        public void Dahua_TransferFinished([RememberType("ACS_Parking.Commons.VideoRecognition.CameraResult")] CameraResult result)
        {
            if (!string.Equals(InputParams, "reset", StringComparison.OrdinalIgnoreCase))
            {
                string[] inputParamArray = InputParams.Split(',');
                result.pateno = inputParamArray[0];
                result.Plate_Color = inputParamArray[1];
                result.CarBrand = inputParamArray[2];
                result.CarColor = inputParamArray[3];
            }
            Dahua_TransferFinished_Original(result);
        }

        [OriginalMethod]
        public void Dahua_TransferFinished_Original([RememberType("ACS_Parking.Commons.VideoRecognition.CameraResult")] CameraResult result)
        {

        }
#endif
    }
}
