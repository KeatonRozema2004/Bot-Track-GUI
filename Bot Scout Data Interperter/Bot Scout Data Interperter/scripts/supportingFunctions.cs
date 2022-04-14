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

        public string zzGetFileDirectoryFromTeamName(string selectedPath, string teamName)
        {
            string[] files = Directory.GetFiles(selectedPath, "*.txt");

            for (int z = 0; files.Length > z; z++)
            {
                string fileName = Path.GetFileName(files[z]).Split('.')[0];

                if (fileName == teamName)
                {
                    return files[z];
                }
            }
            return null;
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
            if (returnPoints > 0)
                return returnPoints / matchesPlayed;
            else
                return 0;
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
 
        public dynamic[] zzGetMatchDataFromTeamByMatchNumber(string selectedPath, string teamNumber, string matchNumber)
        {
            string teamFile = zzGetFileDirectoryFromTeamName(selectedPath, teamNumber);
            string[] fileLines = File.ReadAllLines(teamFile);

            bool matchPassOff = false;

            List<int> matchData      = new List<int>();
            List<string> matchLabels = new List<string>();

            for (int z = 0; fileLines.Length > z; z++)
            {
                string currentLine = fileLines[z];
                string[] currentArray = currentLine.Split(':');

                if (currentArray.Length > 1)
                {
                    if (currentArray[0] == "Match Number" && currentArray[1] == matchNumber)
                    {
                        matchPassOff = true;
                    }
                    if (matchPassOff)
                    {
                        if (currentArray[0] == "Taxi" && currentArray[1] == " y") 
                        {
                            matchData.Add(2);
                            matchLabels.Add("Taxi");
                        }
                        if (currentArray[0] == "Taxi" && currentArray[1] == " n")
                        {
                            matchData.Add(0);
                            matchLabels.Add("Taxi");
                        }

                        if (currentArray[0] == "Auto Upper")
                        {
                            matchData.Add(Int32.Parse(currentArray[1])*4);
                            matchLabels.Add("Auto Upper");
                        }
                        if (currentArray[0] == "Auto Lower") 
                        {
                            matchData.Add(Int32.Parse(currentArray[1])*2);
                            matchLabels.Add("Auto Lower");
                        }
                        if (currentArray[0] == "Auto Missed") 
                        {
                            matchData.Add(Int32.Parse(currentArray[1]));
                            matchLabels.Add("Auto Missed");
                        }
                        if (currentArray[0] == "Tele Upper") 
                        {
                            matchData.Add(Int32.Parse(currentArray[1])*2);
                            matchLabels.Add("Tele Upper");
                        }
                        if (currentArray[0] == "Tele Lower") 
                        {
                            matchData.Add(Int32.Parse(currentArray[1]));
                            matchLabels.Add("Tele Lower");
                        }
                        if (currentArray[0] == "Tele Missed")
                        {
                            matchData.Add(Int32.Parse(currentArray[1]));
                            matchLabels.Add("Tele Missed");
                        }
                        if (currentArray[0] == "Climb Type")
                        {
                            if (currentArray[1] == " l")
                            {
                                matchData.Add(4);
                                matchLabels.Add("Climb");
                            } else if (currentArray[1] == " m")
                            {
                                matchData.Add(6);
                                matchLabels.Add("Climb");
                            } else if (currentArray[1] == " h")
                            {
                                matchData.Add(10);
                                matchLabels.Add("Climb");
                            } else if (currentArray[1] == " t")
                            {
                                matchData.Add(15);
                                matchLabels.Add("Climb");
                            } else if (currentArray[1] == " n")
                            {
                                matchData.Add(0);
                                matchLabels.Add("Climb");
                            }
                        }
                    }
                }
            }
            List<dynamic> returnList = new List<dynamic>();
            List<string> matchLabelsNoDups = matchLabels.Distinct().ToList();
            returnList.Add(matchData.ToArray());
            returnList.Add(matchLabelsNoDups.ToArray());
            return returnList.ToArray();
        }

        public dynamic[] zzReturnMatchAveragePointsByTeamNumber(string fileDirectory, string teamNumber)
        {
            string teamFile = zzGetFileDirectoryFromTeamName(fileDirectory, teamNumber);
            string[] fileLines = File.ReadAllLines(teamFile);

            bool matchTrue = false;
            List<int[]> totalsArray = new List<int[]>();
            List<int> currentMatchNumbers = new List<int>();
            List<string> matchLabels = new List<string>();
            foreach (string line in fileLines)
            {
                string[] lineValues = line.Split(':');

                if (lineValues.Length > 1)
                {
                    if (lineValues[0] == "Match Number")
                    {
                        matchTrue = true;
                    }
                } else
                {
                    if (line == "------------------------")
                        matchTrue = false;
                }
                if (matchTrue == true)
                {
                    if (lineValues[0] == "Taxi" && lineValues[1] == " y")
                    {
                        currentMatchNumbers.Add(2);
                        matchLabels.Add("Taxi");
                    }
                    else if (lineValues[0] == "Taxi" && lineValues[1] == " n")
                    {
                        currentMatchNumbers.Add(0);
                        matchLabels.Add("Taxi");
                    }
                    else if (lineValues[0] == "Auto Upper")
                    {
                        currentMatchNumbers.Add(Int32.Parse(lineValues[1]) * 4);
                        matchLabels.Add("Auto Upper");
                    }
                    else if (lineValues[0] == "Auto Lower")
                    {
                        currentMatchNumbers.Add(Int32.Parse(lineValues[1]) * 2);
                        matchLabels.Add("Auto Lower");
                    }
                    else if (lineValues[0] == "Auto Missed")
                    {
                        currentMatchNumbers.Add(Int32.Parse(lineValues[1]));
                        matchLabels.Add("Auto Missed");
                    }
                    else if (lineValues[0] == "Tele Upper")
                    {
                        currentMatchNumbers.Add(Int32.Parse(lineValues[1]) * 2);
                        matchLabels.Add("Tele Upper");
                    }
                    else if (lineValues[0] == "Tele Lower")
                    {
                        currentMatchNumbers.Add(Int32.Parse(lineValues[1]));
                        matchLabels.Add("Tele Lower");
                    }
                    else if (lineValues[0] == "Tele Missed")
                    {   
                        currentMatchNumbers.Add(Int32.Parse(lineValues[1]));
                        matchLabels.Add("Tele Missed");
                    }
                    else if (lineValues[0] == "Climb Type")
                    {
                        if (lineValues[1] == " l")
                        {
                            currentMatchNumbers.Add(4);
                            matchLabels.Add("Climb");
                        }
                        else if (lineValues[1] == " m")
                        {
                            currentMatchNumbers.Add(6);
                            matchLabels.Add("Climb");
                        }
                        else if (lineValues[1] == " h")
                        {
                            currentMatchNumbers.Add(10);
                            matchLabels.Add("Climb");
                        }
                        else if (lineValues[1] == " t")
                        {
                            currentMatchNumbers.Add(15);
                            matchLabels.Add("Climb");
                        }
                        else if (lineValues[1] == " n")
                        {
                            currentMatchNumbers.Add(0);
                            matchLabels.Add("Climb");
                        }
                    }
                } else if (currentMatchNumbers.Count != 0)
                {
                    totalsArray.Add(currentMatchNumbers.ToArray());
                    currentMatchNumbers = new List<int>();
                }
            }
            dynamic[] allMatches = totalsArray.ToArray();
            List<int> averageList = new List<int>();
            for (int z=0; allMatches.Length > z; z++)
            {
                int[] currentMatch = allMatches[z];

                for (int y=0; currentMatch.Length > y; y++)
                {
                    if (z == 0)
                        averageList.Add(currentMatch[y]);
                    else
                        averageList[y] += currentMatch[y];
                }
            }

            int matchesPlayed = zzGetTeamMatchesPlayed(fileLines);

            for (int x = 0; averageList.Count > x; x++)
            {
                averageList[x] = averageList[x] / matchesPlayed;
            }

            List<string> labels = matchLabels.Distinct().ToList();

            List<dynamic> returns = new List<dynamic>();
            returns.Add(averageList.ToArray());
            returns.Add(labels.ToArray());

            return returns.ToArray();
        }

        public string[] zzGetMatchesPlayedByTeam(string team, string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            List<string> matches = new List<string>();

            foreach (string line in lines)
            {
                string[] lineData = line.Split(':');
                if (lineData.Length > 1 &&  lineData[0] == "Match Number")
                {
                    matches.Add(line);
                }
            }

            return matches.ToArray();
        }

/*        public void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }*/

        public void zzRunEditChangeSubmit(string fileDirectory, string teamNumber, string matchSelect, string taxi, string autoLow, string autoHigh, string autoMiss, string teleLow, string teleHigh, string teleMiss, string climb) 
        {  
            string teamFile = zzGetFileDirectoryFromTeamName(fileDirectory, teamNumber);
            string[] fileLines = File.ReadAllLines(teamFile);

            bool matchFound = false;

            for (int z = 0; fileLines.Length > z; z++)
            {
                string line = fileLines[z];
                string[] lineTitle = line.Split(':');
                if (line == matchSelect)
                {
                    matchFound = true;
                } 
                if (lineTitle.Length == 1)
                {
                    matchFound = false;
                }


                if (matchFound == true)
                {
                    if (lineTitle.Length > 1)
                    {
                        if (lineTitle[0] == "Taxi")
                        {
                            fileLines[z] = "Taxi:" + taxi;
                        }
                        else if (lineTitle[0] == "Auto Upper")
                        {
                            fileLines[z] = "Auto Upper: " + autoHigh;
                        }
                        else if (lineTitle[0] == "Auto Lower")
                        {
                            fileLines[z] = "Auto Lower: " + autoLow;
                        }
                        else if (lineTitle[0] == "Auto Missed")
                        {
                            fileLines[z] = "Auto Missed: " + autoMiss;
                        }
                        else if (lineTitle[0] == "Tele Upper")
                        {
                            fileLines[z] = "Tele Upper: " + teleHigh;
                        }
                        else if (lineTitle[0] == "Tele Lower")
                        {
                            fileLines[z] = "Tele Lower: " + teleLow;
                        }
                        else if (lineTitle[0] == "Tele Missed")
                        {
                            fileLines[z] = "Tele Missed: " + teleMiss;
                        }
                        else if (lineTitle[0] == "Climb Type")
                        {
                            fileLines[z] = "Climb Type:" + climb;
                        }
                    }
                }
            }
            File.WriteAllLines(teamFile, fileLines);
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
