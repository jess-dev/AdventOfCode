using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    class SonarSweep
    {
        public string doSweep(string[] input)
        {
            List<int> converted = convertInput(input);
            List<int> groupedConverted = getGroups(converted);
            return $"Increases: {getIncreases(groupedConverted)}";
        }

        public static List<int> convertInput(string[] input)
        {
            List<int> convertedInput = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                convertedInput.Add(int.Parse(input[i]));
            }

            return convertedInput;
        }

        public static List<int> getGroups(List<int> input)
        {
            List<int> groupedInput = new List<int>();

            for (int i = 0; i < input.Count - 1; i++)
            {
                if ((i + 2) < input.Count)
                {
                    groupedInput.Add(input[i] + input[i + 1] + input[i + 2]);
                }
            }

            return groupedInput;
        }

        public static int getIncreases(List<int> input)
        {
            int output = 0;

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] < input[i + 1])
                {
                    output += 1;
                }
            }

            return output;
        }
    }
}
