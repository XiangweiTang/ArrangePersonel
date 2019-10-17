using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace ArrangePersonel
{
    class Arrange
    {
        public string InputPath { get; set; } = @"";
        public string OutputPath { get; set; } = @"";
        public string SetPath { get; set; } = @"";
        HashSet<string> Set = new HashSet<string>();
        public void Run()
        {
            string inputList = InputPath;
            string outputPath = OutputPath;
            //var personelList = Enumerable.Range(0, 50).Select(x => GenerateRandomLine.SetLine(x)).ToList();
            //File.WriteAllLines(inputList, personelList.Select(x => x.Content));
            var personelList = File.ReadLines(inputList).Select(x => new Line(x)).ToList();
            var dict = ArrangeTime(personelList);
            Set = new HashSet<string>(File.ReadAllText(SetPath).Split(','));
            File.WriteAllLines(outputPath, dict.Select(x => x.Key + "\t" + string.Join(" ", x.Value)));
        }
        private Dictionary<string, List<string>> ArrangeTime(List<Line> personelList)
        {
            Dictionary<string, List<string>> dateDict = Set.ToDictionary(x => x, x => new List<string>());

            Dictionary<string, int> setDict = Set.ToDictionary(x => x, x => 0);

            while (personelList.Count > 0)
            {
                var mostUrgentline = personelList.Aggregate((x, y) => x.ApplicableSet.Count < y.ApplicableSet.Count ? x : y);
                personelList.Remove(mostUrgentline);
                var bestDates = setDict.OrderBy(x => x.Value).Select(x => x.Key);
                foreach(string bestDate in bestDates)
                {
                    if (mostUrgentline.ApplicableSet.Contains(bestDate))
                    {
                        setDict[bestDate]++;
                        dateDict[bestDate].Add(mostUrgentline.Id);
                        break;
                    }
                }
            }
            return dateDict;
        }
    }
}
