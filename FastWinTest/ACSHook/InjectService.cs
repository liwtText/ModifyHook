using FastWin32.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACSHook
{
	public class InjectService
	{
		//注入的核心dll 路径
		public static string path = System.AppDomain.CurrentDomain.BaseDirectory + "ACSHook.DLL.dll";

		/// <summary>
		/// 进程id
		/// </summary>
		public static uint pid = 0;

		/// <summary>
		/// 启动
		/// </summary>
		public static void Start(string param)
		{
			Inject(param);
		}


		#region 私有方法
		private static void Inject(string param)
		{
			try
			{
				Injector.InjectManaged(pid, path, "ACSHook.DLL.HookService", "Start", param, out int returnValue);
			}
			catch (Exception ex)
			{
			}
		}

		#endregion
	}
}
