﻿namespace ACA_System.UI
{
    partial class FrmReady
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label16 = new ACA_Common.LabelNew();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TmrReady = new System.Windows.Forms.Timer(this.components);
            this.LblReady4 = new ACA_Common.LabelNew();
            this.LblReady15 = new ACA_Common.LabelNew();
            this.LblReady13 = new ACA_Common.LabelNew();
            this.LblReady14 = new ACA_Common.LabelNew();
            this.LblReady5 = new ACA_Common.LabelNew();
            this.LblReady6 = new ACA_Common.LabelNew();
            this.LblReady12 = new ACA_Common.LabelNew();
            this.LblReady3 = new ACA_Common.LabelNew();
            this.LblReady10 = new ACA_Common.LabelNew();
            this.LblReady2 = new ACA_Common.LabelNew();
            this.LblReady7 = new ACA_Common.LabelNew();
            this.LblReady1 = new ACA_Common.LabelNew();
            this.LblReady9 = new ACA_Common.LabelNew();
            this.LblReady11 = new ACA_Common.LabelNew();
            this.LblReady8 = new ACA_Common.LabelNew();
            this.LblReady16 = new ACA_Common.LabelNew();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Address = null;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(433, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 38);
            this.label16.StateAddress = null;
            this.label16.TabIndex = 17;
            this.label16.Text = "就绪页面";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnExit.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnExit.Location = new System.Drawing.Point(864, 1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(166, 68);
            this.BtnExit.TabIndex = 18;
            this.BtnExit.Text = "退出";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TmrReady
            // 
            this.TmrReady.Tick += new System.EventHandler(this.TmrReady_Tick);
            // 
            // LblReady4
            // 
            this.LblReady4.Address = "370003";
            this.LblReady4.AutoSize = true;
            this.LblReady4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady4.Location = new System.Drawing.Point(98, 329);
            this.LblReady4.Name = "LblReady4";
            this.LblReady4.Size = new System.Drawing.Size(298, 25);
            this.LblReady4.StateAddress = null;
            this.LblReady4.TabIndex = 22;
            this.LblReady4.Text = "条码枪平移气缸缩回限位";
            // 
            // LblReady15
            // 
            this.LblReady15.Address = "370014";
            this.LblReady15.AutoSize = true;
            this.LblReady15.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady15.Location = new System.Drawing.Point(596, 541);
            this.LblReady15.Name = "LblReady15";
            this.LblReady15.Size = new System.Drawing.Size(298, 25);
            this.LblReady15.StateAddress = null;
            this.LblReady15.TabIndex = 32;
            this.LblReady15.Text = "不合格挡停气缸伸出限位";
            // 
            // LblReady13
            // 
            this.LblReady13.Address = "370012";
            this.LblReady13.AutoSize = true;
            this.LblReady13.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady13.Location = new System.Drawing.Point(596, 402);
            this.LblReady13.Name = "LblReady13";
            this.LblReady13.Size = new System.Drawing.Size(352, 25);
            this.LblReady13.StateAddress = null;
            this.LblReady13.TabIndex = 33;
            this.LblReady13.Text = "工位2电极前进气缸2缩回限位";
            // 
            // LblReady14
            // 
            this.LblReady14.Address = "370013";
            this.LblReady14.AutoSize = true;
            this.LblReady14.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady14.Location = new System.Drawing.Point(596, 472);
            this.LblReady14.Name = "LblReady14";
            this.LblReady14.Size = new System.Drawing.Size(338, 25);
            this.LblReady14.StateAddress = null;
            this.LblReady14.TabIndex = 28;
            this.LblReady14.Text = "工位2通讯测试气缸缩回限位";
            // 
            // LblReady5
            // 
            this.LblReady5.Address = "370004";
            this.LblReady5.AutoSize = true;
            this.LblReady5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady5.Location = new System.Drawing.Point(98, 402);
            this.LblReady5.Name = "LblReady5";
            this.LblReady5.Size = new System.Drawing.Size(286, 25);
            this.LblReady5.StateAddress = null;
            this.LblReady5.TabIndex = 25;
            this.LblReady5.Text = "工位1挡停气缸伸出限位";
            // 
            // LblReady6
            // 
            this.LblReady6.Address = "370005";
            this.LblReady6.AutoSize = true;
            this.LblReady6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady6.Location = new System.Drawing.Point(98, 472);
            this.LblReady6.Name = "LblReady6";
            this.LblReady6.Size = new System.Drawing.Size(338, 25);
            this.LblReady6.StateAddress = null;
            this.LblReady6.TabIndex = 29;
            this.LblReady6.Text = "工位1产品举升气缸缩回限位";
            // 
            // LblReady12
            // 
            this.LblReady12.Address = "370011";
            this.LblReady12.AutoSize = true;
            this.LblReady12.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady12.Location = new System.Drawing.Point(596, 329);
            this.LblReady12.Name = "LblReady12";
            this.LblReady12.Size = new System.Drawing.Size(352, 25);
            this.LblReady12.StateAddress = null;
            this.LblReady12.TabIndex = 31;
            this.LblReady12.Text = "工位2电极前进气缸1缩回限位";
            // 
            // LblReady3
            // 
            this.LblReady3.Address = "370002";
            this.LblReady3.AutoSize = true;
            this.LblReady3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady3.Location = new System.Drawing.Point(98, 257);
            this.LblReady3.Name = "LblReady3";
            this.LblReady3.Size = new System.Drawing.Size(234, 25);
            this.LblReady3.StateAddress = null;
            this.LblReady3.TabIndex = 21;
            this.LblReady3.Text = "隔料气缸2缩回限位";
            // 
            // LblReady10
            // 
            this.LblReady10.Address = "370009";
            this.LblReady10.AutoSize = true;
            this.LblReady10.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady10.Location = new System.Drawing.Point(596, 183);
            this.LblReady10.Name = "LblReady10";
            this.LblReady10.Size = new System.Drawing.Size(286, 25);
            this.LblReady10.StateAddress = null;
            this.LblReady10.TabIndex = 24;
            this.LblReady10.Text = "工位2挡停气缸伸出限位";
            // 
            // LblReady2
            // 
            this.LblReady2.Address = "370001";
            this.LblReady2.AutoSize = true;
            this.LblReady2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady2.Location = new System.Drawing.Point(98, 183);
            this.LblReady2.Name = "LblReady2";
            this.LblReady2.Size = new System.Drawing.Size(234, 25);
            this.LblReady2.StateAddress = null;
            this.LblReady2.TabIndex = 20;
            this.LblReady2.Text = "隔料气缸1缩回限位";
            // 
            // LblReady7
            // 
            this.LblReady7.Address = "370006";
            this.LblReady7.AutoSize = true;
            this.LblReady7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady7.Location = new System.Drawing.Point(98, 541);
            this.LblReady7.Name = "LblReady7";
            this.LblReady7.Size = new System.Drawing.Size(352, 25);
            this.LblReady7.StateAddress = null;
            this.LblReady7.TabIndex = 23;
            this.LblReady7.Text = "工位1电极前进气缸1缩回限位";
            // 
            // LblReady1
            // 
            this.LblReady1.Address = "370000";
            this.LblReady1.AutoSize = true;
            this.LblReady1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady1.Location = new System.Drawing.Point(98, 111);
            this.LblReady1.Name = "LblReady1";
            this.LblReady1.Size = new System.Drawing.Size(220, 25);
            this.LblReady1.StateAddress = null;
            this.LblReady1.TabIndex = 19;
            this.LblReady1.Text = "挡料气缸伸出限位";
            // 
            // LblReady9
            // 
            this.LblReady9.Address = "370008";
            this.LblReady9.AutoSize = true;
            this.LblReady9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady9.Location = new System.Drawing.Point(596, 111);
            this.LblReady9.Name = "LblReady9";
            this.LblReady9.Size = new System.Drawing.Size(338, 25);
            this.LblReady9.StateAddress = null;
            this.LblReady9.TabIndex = 30;
            this.LblReady9.Text = "工位1通讯测试气缸缩回限位";
            // 
            // LblReady11
            // 
            this.LblReady11.Address = "370010";
            this.LblReady11.AutoSize = true;
            this.LblReady11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady11.Location = new System.Drawing.Point(596, 257);
            this.LblReady11.Name = "LblReady11";
            this.LblReady11.Size = new System.Drawing.Size(338, 25);
            this.LblReady11.StateAddress = null;
            this.LblReady11.TabIndex = 27;
            this.LblReady11.Text = "工位2产品举升气缸缩回限位";
            // 
            // LblReady8
            // 
            this.LblReady8.Address = "370007";
            this.LblReady8.AutoSize = true;
            this.LblReady8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady8.Location = new System.Drawing.Point(98, 613);
            this.LblReady8.Name = "LblReady8";
            this.LblReady8.Size = new System.Drawing.Size(352, 25);
            this.LblReady8.StateAddress = null;
            this.LblReady8.TabIndex = 26;
            this.LblReady8.Text = "工位1电极前进气缸2缩回限位";
            // 
            // LblReady16
            // 
            this.LblReady16.Address = "370015";
            this.LblReady16.AutoSize = true;
            this.LblReady16.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblReady16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblReady16.Location = new System.Drawing.Point(596, 613);
            this.LblReady16.Name = "LblReady16";
            this.LblReady16.Size = new System.Drawing.Size(246, 25);
            this.LblReady16.StateAddress = null;
            this.LblReady16.TabIndex = 34;
            this.LblReady16.Text = "不合格品挡停处有料";
            // 
            // FrmReady
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 701);
            this.Controls.Add(this.LblReady16);
            this.Controls.Add(this.LblReady4);
            this.Controls.Add(this.LblReady15);
            this.Controls.Add(this.LblReady13);
            this.Controls.Add(this.LblReady14);
            this.Controls.Add(this.LblReady5);
            this.Controls.Add(this.LblReady6);
            this.Controls.Add(this.LblReady12);
            this.Controls.Add(this.LblReady3);
            this.Controls.Add(this.LblReady10);
            this.Controls.Add(this.LblReady2);
            this.Controls.Add(this.LblReady7);
            this.Controls.Add(this.LblReady1);
            this.Controls.Add(this.LblReady9);
            this.Controls.Add(this.LblReady11);
            this.Controls.Add(this.LblReady8);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label16);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmReady";
            this.Text = "就绪页面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReady_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ACA_Common.LabelNew label16;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Timer TmrReady;
        private ACA_Common.LabelNew LblReady4;
        private ACA_Common.LabelNew LblReady15;
        private ACA_Common.LabelNew LblReady13;
        private ACA_Common.LabelNew LblReady14;
        private ACA_Common.LabelNew LblReady5;
        private ACA_Common.LabelNew LblReady6;
        private ACA_Common.LabelNew LblReady12;
        private ACA_Common.LabelNew LblReady3;
        private ACA_Common.LabelNew LblReady10;
        private ACA_Common.LabelNew LblReady2;
        private ACA_Common.LabelNew LblReady7;
        private ACA_Common.LabelNew LblReady1;
        private ACA_Common.LabelNew LblReady9;
        private ACA_Common.LabelNew LblReady11;
        private ACA_Common.LabelNew LblReady8;
        private ACA_Common.LabelNew LblReady16;
    }
}