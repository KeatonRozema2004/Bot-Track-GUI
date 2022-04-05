using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot_Scout_Data_Interperter.scripts
{
    class supportingFunctions
    {
        public string[] zzGetDataFilesFromDirectory(string selectedPath)
        {
            string[] files = Directory.GetFiles(selectedPath, "*.txt");
            return files;
        }

        public string[] zzGetMatchDataForTeam(string selectPath, string teamNumber)
        {
            string[] files = zzGetDataFilesFromDirectory(selectPath);

            for (int z = 0; files.Length > z; z++)
            {
                string fileName   = Path.GetFileName(files[z]);
                string searchFile = teamNumber + ".txt";

                if (fileName == searchFile)
                {
                    string[] lines = File.ReadAllLines(files[z]);

                    List<string> robotData = new List<string>();

                    foreach (string line in lines)
                    {
                        if (line != "0")
                        {
                            robotData.Add(zzParseTextDocumentData(line));
                        }
                    }
                    return robotData.ToArray();
                }
            }
            return null;
        }

        private string zzParseTextDocumentData(string data)
        {

            string[] returnData = data.Split(':');

            if (returnData.Length == 2)
            {
                return returnData[1];
            } else
            {
                return null;
            }
        }
    }
}
