﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAMS.Client.Utils;

namespace IAMS.Client.Forms
{
    public partial class LaunchForm : Form
    {
        public MainForm MainForm { get; protected set; }

        public LaunchForm()
        {
            this.InitializeComponent();

            this.Icon = AppResource.AppIcon;
        }

        private async void LaunchForm_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            DialogResult dialogResult = DialogResult.None;
            try
            {
                await this.LaunchApplication();

                dialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.UpdateProgress($"启动程序出错：{ex.Message}");
                MessageBox.Show(ex.Message, "启动程序出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dialogResult = DialogResult.Abort;
            }
            finally
            {
                this.DialogResult = dialogResult;
            }
        }

        /// <summary>
        /// 启动应用程序
        /// </summary>
        private async Task LaunchApplication()
        {
            this.UpdateProgress($"检查 WebAPI 连接 ...");
            var address = ConfigHelper.WebAPIAddress;
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new Exception("WebAPI 地址为空！");
            }

            this.UpdateProgress($"获取会话秘钥 ...");
            const string apiAddress = "Connect/GetSessionKey";
            string key = await WebHelper.GetStringAsync($"{address}/{apiAddress}");
            WebHelper.SetSessionKey(key);

            this.UpdateProgress($"创建主窗口 ...");
            this.MainForm = new MainForm();
        }

        /// <summary>
        /// 更新进度
        /// </summary>
        /// <param name="message"></param>
        private void UpdateProgress(string message)
            => this.ProgressLabel.Text = message;
    }
}
