using System;
using System.Collections.Generic;
using System.Text;

namespace ArrangePersonel
{
    static class GenerateRandomLine
    {
        static Random R = new Random();
        public static Line SetLine(int id)
        {            
            List<string> list = new List<string>();
            for(int i = 0; i <= 3; i++)
            {
                for(int j = 0; j <= 1; j++)
                {
                    if (R.Next(10) < 6)
                        list.Add($"{i}_{j}");
                }
            }
            string line = string.Join(" ", list);
            string s = "";
            if (R.Next(10) <= 6)
            {
                s = $"{id}\t{line}\t";
            }
            else
                s = $"{id}\t\t{line}";
            return new Line(s);
        }
    }
}
