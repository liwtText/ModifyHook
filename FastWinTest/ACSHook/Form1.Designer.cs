namespace ACSHook
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModifyRecognizePlate = new System.Windows.Forms.Button();
            this.txtRecognizePlate = new System.Windows.Forms.TextBox();
            this.lblGeneratePlate = new System.Windows.Forms.Label();
            this.btnResetRecognizePlate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecognizePlateColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecognizeCarBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecognizeCarColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModifyRecognizePlate
            // 
            this.btnModifyRecognizePlate.Location = new System.Drawing.Point(377, 22);
            this.btnModifyRecognizePlate.Name = "btnModifyRecognizePlate";
            this.btnModifyRecognizePlate.Size = new System.Drawing.Size(75, 23);
            this.btnModifyRecognizePlate.TabIndex = 5;
            this.btnModifyRecognizePlate.Text = "修改识别";
            this.btnModifyRecognizePlate.UseVisualStyleBackColor = true;
            this.btnModifyRecognizePlate.Click += new System.EventHandler(this.btnModifyRecognizePlate_Click);
            // 
            // txtRecognizePlate
            // 
            this.txtRecognizePlate.Location = new System.Drawing.Point(84, 22);
            this.txtRecognizePlate.Name = "txtRecognizePlate";
            this.txtRecognizePlate.Size = new System.Drawing.Size(100, 21);
            this.txtRecognizePlate.TabIndex = 1;
            this.txtRecognizePlate.Text = "浙A12345";
            // 
            // lblGeneratePlate
            // 
            this.lblGeneratePlate.AutoSize = true;
            this.lblGeneratePlate.Location = new System.Drawing.Point(24, 26);
            this.lblGeneratePlate.Name = "lblGeneratePlate";
            this.lblGeneratePlate.Size = new System.Drawing.Size(53, 12);
            this.lblGeneratePlate.TabIndex = 4;
            this.lblGeneratePlate.Text = "车牌号：";
            this.lblGeneratePlate.Click += new System.EventHandler(this.lblGeneratePlate_Click);
            // 
            // btnResetRecognizePlate
            // 
            this.btnResetRecognizePlate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnResetRecognizePlate.Enabled = false;
            this.btnResetRecognizePlate.Location = new System.Drawing.Point(377, 63);
            this.btnResetRecognizePlate.Name = "btnResetRecognizePlate";
            this.btnResetRecognizePlate.Size = new System.Drawing.Size(75, 23);
            this.btnResetRecognizePlate.TabIndex = 6;
            this.btnResetRecognizePlate.Text = "重置";
            this.btnResetRecognizePlate.UseVisualStyleBackColor = true;
            this.btnResetRecognizePlate.Click += new System.EventHandler(this.btnResetRecognizePlate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "车牌颜色：";
            // 
            // txtRecognizePlateColor
            // 
            this.txtRecognizePlateColor.Location = new System.Drawing.Point(262, 22);
            this.txtRecognizePlateColor.Name = "txtRecognizePlateColor";
            this.txtRecognizePlateColor.Size = new System.Drawing.Size(100, 21);
            this.txtRecognizePlateColor.TabIndex = 2;
            this.txtRecognizePlateColor.Text = "蓝色";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "车牌品牌：";
            // 
            // txtRecognizeCarBrand
            // 
            this.txtRecognizeCarBrand.Location = new System.Drawing.Point(83, 64);
            this.txtRecognizeCarBrand.Name = "txtRecognizeCarBrand";
            this.txtRecognizeCarBrand.Size = new System.Drawing.Size(100, 21);
            this.txtRecognizeCarBrand.TabIndex = 3;
            this.txtRecognizeCarBrand.Text = "保时捷";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "车身颜色：";
            // 
            // txtRecognizeCarColor
            // 
            this.txtRecognizeCarColor.Location = new System.Drawing.Point(260, 64);
            this.txtRecognizeCarColor.Name = "txtRecognizeCarColor";
            this.txtRecognizeCarColor.Size = new System.Drawing.Size(100, 21);
            this.txtRecognizeCarColor.TabIndex = 4;
            this.txtRecognizeCarColor.Text = "黑色";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnModifyRecognizePlate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnResetRecognizePlate;
            this.ClientSize = new System.Drawing.Size(472, 109);
            this.Controls.Add(this.txtRecognizeCarBrand);
            this.Controls.Add(this.txtRecognizeCarColor);
            this.Controls.Add(this.txtRecognizePlateColor);
            this.Controls.Add(this.btnResetRecognizePlate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGeneratePlate);
            this.Controls.Add(this.txtRecognizePlate);
            this.Controls.Add(this.btnModifyRecognizePlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "识别结果修改工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModifyRecognizePlate;
        private System.Windows.Forms.TextBox txtRecognizePlate;
        private System.Windows.Forms.Label lblGeneratePlate;
        private System.Windows.Forms.Button btnResetRecognizePlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecognizePlateColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecognizeCarBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecognizeCarColor;
    }
}

