/*
MIT License

Copyright (c) 2017 rd124p7

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
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
        
        /**
            Method Name: GetDeviceLetter
            Description: 
                Returns the name (letter: C:\) of the removable device that is plugged in
                
            Params: None
            Returns: letter -> string   
        **/
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

        /**
            Method Name: GetBackupDevice
            Description:
                Return an instance of a DriveInfo object with the letter that is detected
                from the method GetDeviceLetter()

            Params: None
            Returns: backupDrive -> DriveInfo
        **/
        public DriveInfo GetBackupDevice()
        {
            DriveInfo backupDrive = new DriveInfo(GetDeviceLetter());
            return backupDrive;
        }

        /**
            Method Name: GetDevFreeSpace
            Description:
                Returns the amount of free space on the device that can be used

            Params: None
            Returns: DriveInfo.AvailableFreeSpace -> Int64
        **/
        public Int64 GetDevFreeSpace()
        {
            return GetBackupDevice().AvailableFreeSpace;
        }

        /**
            Method Name: GetDevTotalSize
            Description:
                Returns the total size of the removable device

            Params: None
            Returns: DriveInfo.AvailableFreeSpace -> Int64
        **/
        public Int64 GetDevTotalSize()
        {
            return GetBackupDevice().TotalSize;
        }

        /**
            Method Name: ConvertSize
            Description:
                Returns the converted size of a number into MegaBytes which then is 
                converted to a string

            Params:
                number -> Int64

            Returns: String.Format(size) -> string
        **/
        public string ConvertSize(Int64 number)
        {
            int giga = 1000000;
            double size = (int)number / giga;

            return String.Format("{0} MB", Convert.ToString(size));
        }

        /**
            Method Name: isDevReady
            Description:
                Return wether the removable device is ready

            Params: None
            Returns: -> bool
        **/
        public bool isDevReady()
        {
            if (GetBackupDevice().IsReady)
                return true;
            else
                return false;
        }
        
    }
}
