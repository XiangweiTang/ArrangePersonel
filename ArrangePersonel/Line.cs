using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ArrangePersonel
{
    class Line
    {
        public string Content { get; }
        public string Id { get; set; } = "";
        public HashSet<string> ApplicableSet { get; set; } = new HashSet<string>();
        public Line()
        {

        }
        public Line(string line)
        {
            var split = line.Split('\t');
            Sanity.Requires(split.Length == 3, $"Invalid line format: {line}");
            Content = line;
            Id = split[0];
            string applicable = split[1];
            foreach (string s in applicable.Split(' '))
                ApplicableSet.Add(s);
            string notApplicable = split[2];
            //var rest = Constants.FULL_SET.Except(notApplicable.Split(' '));
            //foreach (string s in rest)
            //    ApplicableSet.Add(s);
        }
        
    }
}
