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

        public Split(string hdd_name)
        {
            this.hdd_name = hdd_name;
        }

        /**
            Method Name: splListsFolders
            Description:
                Split up the folders and files in the root directory, send them on to there seperate arrays 

            Params: None
            Returns: folderList -> List<List<string>>
        **/
        public List<string[]> splListsFoldersFiles()
        {
            return new List<string[]> { Directory.GetDirectories(this.hdd_name), Directory.GetFiles(this.hdd_name) };
        }

    }
}
