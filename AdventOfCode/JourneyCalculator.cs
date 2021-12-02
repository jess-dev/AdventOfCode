using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    class JourneyCalculator
    {
        public string calculatePosition(string[] input, int h = 0, int d = 0, int a = 0)
        {

            for (int i = 0; i < input.Length; i++)
            {
                var direction = input[i].Split(' ');
                switch (direction[0])
                {
                    case "forward":
                        h += int.Parse(direction[1]);
                        d += (int.Parse(direction[1]) * a);
                        break;
                    case "down":
                        a += int.Parse(direction[1]);
                        break;
                    case "up":
                        a -= int.Parse(direction[1]);
                        break;
                    default:
                        break;
                }
            }
            return $"Horizontal: {h} - Depth: {d} - Multiplied: {h * d}";
        }
    }
}
