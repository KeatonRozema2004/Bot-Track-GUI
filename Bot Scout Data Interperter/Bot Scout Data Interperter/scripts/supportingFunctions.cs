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

        public int zzReturnModePointsFromDataSheet(string[] lines, bool auto=false, bool tele=false, bool end=false)
        {
            int returnPoints = 0;
            int matchesPlayed = zzGetTeamMatchesPlayed(lines);


            foreach (string line in lines)
            {
                if (line != "0" || line != "------------------------")
                {
                    string[] currentLineData = line.Split(':');
                    if (auto == true && tele == false && end == false)
                    {
                        if (currentLineData[0] == "Taxi")
                        {
                            if (currentLineData[1] == " y")
                            {
                                returnPoints += 2;
                            }
                        }
                        else if (currentLineData[0] == "Auto Upper")
                        {
                            int autoUpper = Int32.Parse(currentLineData[1]); // I know Imma dumbass and could put this all in one line but na fam
                            int autoUpperPoints = autoUpper * 4;
                            returnPoints += autoUpperPoints;
                        }
                        else if (currentLineData[0] == "Auto Lower")
                        {
                            int autoLower = Int32.Parse(currentLineData[1]);
                            int autoLowerPoints = autoLower * 2;
                            returnPoints += autoLowerPoints;
                        }
                    }
                    else if (tele == true && auto == false && end == false)
                    {
                        if (currentLineData[0] == "Tele Upper")
                        {
                            int teleUpper = Int32.Parse(currentLineData[1]);
                            int teleUpperPoints = teleUpper * 2;
                            returnPoints += teleUpperPoints;
                        }
                        else if (currentLineData[0] == "Tele Lower")
                        {
                            int teleLower = Int32.Parse(currentLineData[1]);
                            returnPoints += teleLower;
                        }
                    }
                    else if (end == true && auto == false && tele == false)
                    {
                        if (currentLineData[0] == "Climb Type")
                        {
                            if (currentLineData[1] == " l")
                            {
                                returnPoints += 4;
                            }
                            else if (currentLineData[1] == " m")
                            {
                                returnPoints += 6;
                            }
                            else if (currentLineData[1] == " h")
                            {
                                returnPoints += 10;
                            }
                            else if (currentLineData[1] == " t")
                            {
                                returnPoints += 15;
                            }
                        }
                    }
                }  
            }
            return returnPoints/matchesPlayed;
        }

        public int zzGetTeamMatchesPlayed(string[] fileLines)
        {
            int matchesPlayed = 0;
            foreach (string line in fileLines)
            {
                string parsedLine;
                try { parsedLine = line.Split(':')[0]; } catch { parsedLine = ""; }
                
                if (parsedLine == "Match Number")
                {
                    matchesPlayed++;
                }
            }
            return matchesPlayed;
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
