using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace CompName
{
    class Methods
    {
        public enum ChassisTypes
        {
            Other = 1,
            Unknown,
            Desktop,
            LowProfileDesktop,
            PizzaBox,
            MiniTower,
            Tower,
            Portable,
            Laptop,
            Notebook,
            Handheld,
            DockingStation,
            AllInOne,
            SubNotebook,
            SpaceSaving,
            LunchBox,
            MainSystemChassis,
            ExpansionChassis,
            SubChassis,
            BusExpansionChassis,
            PeripheralChassis,
            StorageChassis,
            RackMountChassis,
            SealedCasePC
        }

        public static string GetSerialNum()
        {
            string mbSrvTag = String.Empty;
            string mbMfg = String.Empty;
            ManagementScope scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
            scope.Connect();
            ManagementObject obj = new ManagementObject(scope, new ManagementPath("Win32_BaseBoard.Tag=\"Base Board\""), new ObjectGetOptions());

            foreach (PropertyData propData in obj.Properties)
            {
               // MessageBox.Show(propData.Name.ToString());
                if (propData.Name == "SerialNumber")
                {
                    mbSrvTag = Convert.ToString(propData.Value);
                }

                if (propData.Name == "Manufacturer")
                {
                    mbMfg = Convert.ToString(propData.Value);
                    //MessageBox.Show(mbMfg);
                }
            }

            if (mbMfg.ToUpper().Contains("DELL"))
            {
                mbSrvTag = mbSrvTag.Substring(1);
                mbSrvTag = mbSrvTag.Substring(0, 7);
            }

            return mbSrvTag;
        }

        public static string GetChassisType()
        {
            string mbChassis = String.Empty;

            ManagementClass mgcls = new ManagementClass("Win32_SystemEnclosure");
            foreach (ManagementObject obj in mgcls.GetInstances())
            {
                foreach (int i in (UInt16[])(obj["ChassisTypes"]))
                {
                    if (i > 0 && i < 25)
                    {
                        
                        mbChassis = Convert.ToString((ChassisTypes)i);
                    }
                    else
                    {
                        mbChassis = "Other";
                    }
                }
            }

            return mbChassis;
        }

        public static string PromptDialog(string text, string caption)
        {
            Form promptDiag = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent
            };

            Label txtLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox txtbx = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirm = new Button() { Text = "OK", Left = 350, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirm.Click += (sender, e) => { promptDiag.Close(); };
            promptDiag.Controls.Add(txtbx);
            promptDiag.Controls.Add(confirm);
            promptDiag.Controls.Add(txtLabel);
            promptDiag.AcceptButton = confirm;

            return promptDiag.ShowDialog() == DialogResult.OK ? txtbx.Text : "";
        }
    }
}
