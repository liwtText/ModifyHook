using DotNetDetour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACSHook.DLL
{
    public class HookService
    {
        /// <summary>
        /// Hook 初始化
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static int Start(string msg)
        {
            try
            {
                Service.Process_RecognizePlateService.InputParams = msg;
                MethodHook.Install();
            }
            catch
            {
                return -1;
            }
            return 1;
        }
    }
}
