using System.Collections.Generic;
using System.Linq;

namespace Strings.Solution.ReorderDataInLogFiles
{
    public class DataOrderInLogFiles
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            var letterLogs = new List<string>();
            var letterLogsWithoutPrefix = new List<string>();
            var numLogs = new Queue<string>();
            var finalList = new List<string>();

            foreach (var log in logs)
            {
                var temp = log.Split(' ');
                char firstCharacter = temp[1][0];
                if (char.IsDigit(firstCharacter))
                {
                    numLogs.Enqueue(log);
                }
                else
                {
                    letterLogs.Add(log);
                    letterLogsWithoutPrefix.Add(log.Substring(temp[0].Length + 1));
                }
            }

            letterLogs.Sort();
            letterLogsWithoutPrefix.Sort();

            foreach (var t in letterLogsWithoutPrefix)
            {
                var temp = letterLogs.FirstOrDefault(x => x.EndsWith(t));
                finalList.Add(temp);
                letterLogs.Remove(temp);
            }

            finalList.AddRange(numLogs);

            return finalList.ToArray();
        }
    }
}
