﻿using ACA_Common;
using ACA_Common.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACA_System_InTest
{
    public partial class FrmManual3 : Form
    {
        private System.Threading.Timer tmrState;
        private ButtonNew[] BtnArray = new ButtonNew[22];
        public FrmManual3()
        {
            InitializeComponent();
        }
        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {

            ButtonNew BtnNew = (ButtonNew)sender;
            try
            {
                if (Global.kv.Active)
                {
                    Global.kv.WriteMemory(DATABUILDERAXLibLB.DBPlcDevice.DKV7KXYM_RLY_B, BtnNew.Address, 1);
                }
                else MessageBox.Show("plc已断开");
            }
            catch (Exception)
            {

            }
        }

        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {

            ButtonNew BtnNew = (ButtonNew)sender;
            try
            {
                if (Global.kv.Active)
                {
                    Global.kv.WriteMemory(DATABUILDERAXLibLB.DBPlcDevice.DKV7KXYM_RLY_B, BtnNew.Address, 0);
                }
                else MessageBox.Show("plc已断开");
            }
            catch (Exception)
            {

            }
        }

        private void UiDisplay(object state)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    Display();
                }));
            }
        }

        private void Display()
        {
            try
            {
                for (int i = 0; i < BtnArray.Length; i++)
                {
                    if (Global.kv.ReadMemory(DATABUILDERAXLibLB.DBPlcDevice.DKV7K_EM_B, BtnArray[i].StateAddress) == 1)
                    {
                        BtnArray[i].BackColor = Color.GreenYellow;
                    }
                    else BtnArray[i].BackColor = Color.FromArgb(212, 208, 200);
                }
            }
            catch (Exception)
            {
                //for (int i = 0; i < BtnArray.Length; i++)
                //{
                //    BtnArray[i].BackColor = Color.FromArgb(212, 208, 200);
                //}
            }
        }

        private void FrmManual3_Load(object sender, EventArgs e)
        {
            BtnArray[0] = buttonNew1;
            BtnArray[1] = buttonNew2;
            BtnArray[2] = buttonNew3;
            BtnArray[3] = buttonNew4;
            BtnArray[4] = buttonNew5;
            BtnArray[5] = buttonNew6;
            BtnArray[6] = buttonNew7;
            BtnArray[7] = buttonNew8;
            BtnArray[8] = buttonNew9;
            BtnArray[9] = buttonNew10;
            BtnArray[10] = buttonNew11;
            BtnArray[11] = buttonNew12;
            BtnArray[12] = buttonNew13;
            BtnArray[13] = buttonNew14;
            BtnArray[14] = buttonNew15;
            BtnArray[15] = buttonNew16;
            BtnArray[16] = buttonNew17;
            BtnArray[17] = buttonNew18;
            BtnArray[18] = buttonNew19;
            BtnArray[19] = buttonNew20;
            BtnArray[20] = buttonNew21;
            BtnArray[21] = buttonNew22;
            tmrState = new System.Threading.Timer(UiDisplay, this, 0, 1000);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            tmrState.Dispose();
            Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            Hide();
            FrmManual2 frmManual2 = new FrmManual2();
            frmManual2.ShowDialog();
        }

    }
}
