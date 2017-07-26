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

/**
    Class Name: Split
    Constructor: Split
    Inherits: None

    Description: 
        Perform operations to split the contents of a hard drive and return the results,
        operations to make sure the returned lists are around the same length
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataAssistant.Backup
{
    class Split
    {
        private string hdd_name = "";
        private string[] dirContents = { };
        private string[] fileContents = { };

        /**
            Constructor: Split
            Description:
                When a new Split instance is created pass in the letter of the hard drive,
                then set instance variables dirContents and fileContents

            Params: 
                hdd_name -> string
            Returns: None
        **/
        public Split(string hdd_name)
        {
            this.hdd_name = hdd_name;
            dirContents = Directory.GetDirectories(this.hdd_name);
            fileContents = Directory.GetFiles(this.hdd_name);
        }

        public List<string> getFirstSectionFolder()
        {
            List<string> temp = new List<string>();

            for (int i = 0; i < dirContents.Length / 2; i++)
                temp.Add(dirContents[i]);

            return temp;
        }

        public List<string> getLastSectionFolder()
        {
            List<string> temp = new List<string>();

            for (int i = dirContents.Length / 2; i < dirContents.Length; i++)
                temp.Add(dirContents[i]);

            return temp;
        }

        public List<string> getFileSection()
        {
            List<string> temp = new List<string>();

            for (int i = 0; i < fileContents.Length; i++)
                temp.Add(fileContents[i]);

            return temp;
        }
    }
}
