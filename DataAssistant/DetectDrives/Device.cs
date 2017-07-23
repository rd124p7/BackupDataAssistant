/*

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DataAssistant.DetectDrives
{
    class Device
    {
        public Device() {}

        public string GetDeviceLetter()
        {
            string letter = "";

            foreach(DriveInfo di in DriveInfo.GetDrives())
            {
                if(di.DriveType == DriveType.Removable)
                {
                    letter = di.Name;
                }
                    
            }
            return letter;
        }

        public DriveInfo GetBackupDevice()
        {
            DriveInfo backupDrive = new DriveInfo(GetDeviceLetter());
            return backupDrive;
        }

        public Int64 GetDevFreeSpace()
        {
            return GetBackupDevice().AvailableFreeSpace;
        }

        public Int64 GetDevTotalSize()
        {
            return GetBackupDevice().TotalSize;
        }

        public string ConvertSize(Int64 number)
        {
            int giga = 1000000;
            double size = (int)number / giga;

            return String.Format("{0} MB", Convert.ToString(size));
        }

        public bool isDevReady()
        {
            if (GetBackupDevice().IsReady)
                return true;
            else
                return false;
        }
        
    }
}
