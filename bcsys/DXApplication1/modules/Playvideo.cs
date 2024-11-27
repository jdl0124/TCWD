using System.Collections.Generic;
using System.IO;

namespace PriorityTextToSpeech.modules
{
    class Playvideo
    {
        public string[] ProcessDirectory(string targetDirectory)
        {

            List<string> lst = new List<string>();
            //string [] vfiles;   

            int x = 0;
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                lst.Add(fileName);
                x+=1;
                
            }
            string[] vfiles = lst.ToArray();
            return vfiles;
            // Recurse into subdirectories of this directory.
            //string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            //foreach (string subdirectory in subdirectoryEntries)
            //    ProcessDirectory(subdirectory);

        }
    }
}
