using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACSHook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string ResetCommand = "reset";

        /// <summary>
        /// 修改识别车牌
        /// </summary>
        private void btnModifyRecognizePlate_Click(object sender, EventArgs e)
        {
            string[] inputParamArray = {
                txtRecognizePlate.Text.Trim(),
                txtRecognizePlateColor.Text.Trim(),
                txtRecognizeCarBrand.Text.Trim(),
                txtRecognizeCarColor.Text.Trim() };
            Inject(string.Join(",", inputParamArray));
        }

        /// <summary>
        /// 注入修改程序
        /// </summary>
        private void Inject(string message)
        {
            GetParkingPid(out int clientPid, out int serverPid);
            if (clientPid < 0 && serverPid < 0)
            {
                if (!isClosing)
                {
                    MessageBox.Show(this, "请先启动客户端或通信服务");
                }
                return;
            }
            if (clientPid >= 0)
            {
                InjectService.pid = (uint)clientPid;
                InjectService.Start(message);
            }
            if (serverPid >= 0)
            {
                InjectService.pid = (uint)serverPid;
                InjectService.Start(message);
            }
            btnResetRecognizePlate.Enabled = !string.Equals(message, ResetCommand, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 获取停车软件和服务的PID
        /// </summary>
        private void GetParkingPid(out int clientPid, out int serverPid, string machineName = ".")
        {
            clientPid = serverPid = -1;
            Process[] clientProcess = Process.GetProcessesByName("PakingVideo_Login", machineName);
            Process[] serviceProcess = Process.GetProcessesByName("PakingVideoWindowsService", machineName);
            if (clientProcess != null && clientProcess.Length > 0)
            {
                clientPid = clientProcess[0].Id;
            }
            if (serviceProcess != null && serviceProcess.Length > 0)
            {
                serverPid = serviceProcess[0].Id;
            }
        }

        /// <summary>
        /// 重置
        /// </summary>
        private void btnResetRecognizePlate_Click(object sender, EventArgs e)
        {
            Inject(ResetCommand);
        }

        /// <summary>
        /// 是否处在关闭中状态
        /// </summary>
        private bool isClosing = false;

        /// <summary>
        /// 关闭窗体前重置
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosing = true;
            if (btnResetRecognizePlate.Enabled)
            {
                Inject(ResetCommand);
            }
        }

        /// <summary>
        /// 随机数操作类
        /// </summary>
        private static readonly Random ran = new Random();

        /// <summary>
        /// 车牌开头
        /// </summary>
        private static Lazy<string[]> PlateFirstWord = new Lazy<string[]>(() => Read(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "CarCode.txt").Split(','));

        /// <summary>
        /// 产生车牌号
        /// </summary>
        /// <returns></returns>
        public static string GenerateCarCode()
        {
            StringBuilder strCarCode = new StringBuilder();
            strCarCode.Append(PlateFirstWord.Value[ran.Next(PlateFirstWord.Value.Length)]);
            int letterCount = 0;
            int length = 5;
            for (int i = 0; i < length; i++)
            {
                int type = ran.Next(5);
                if (type < 2 && letterCount < 2)
                {
                    char generate = (char)(ran.Next(26) + 65);
                    if (generate == 'O' || generate == 'I')
                    {
                        length++;
                        continue;
                    }
                    if (strCarCode.Length == 2 && (generate == 'D' || generate == 'F'))
                    {
                        length++;
                        letterCount--;
                    }
                    strCarCode.Append(generate);
                    letterCount++;
                }
                else
                {
                    strCarCode.Append((char)(ran.Next(10) + 48));
                }
            }
            return strCarCode.ToString();
        }

        /// <summary>
        /// 本地读取文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string Read(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            StringBuilder sb = new StringBuilder();
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                sb.Append(line);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 生成随机车牌号
        /// </summary>
        private void lblGeneratePlate_Click(object sender, EventArgs e)
        {
            txtRecognizePlate.Text = GenerateCarCode();
        }
    }
}
