using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day 1
            SonarSweep sweep = new SonarSweep();
            string[] sweepInput = System.IO.File.ReadAllLines(@"C:\Users\jessi\OneDrive\Desktop\input.txt");
            Console.WriteLine(sweep.doSweep(sweepInput));

            // Day 2
            JourneyCalculator calc = new JourneyCalculator();
            string[] journeyInput = System.IO.File.ReadAllLines(@"C:\Users\jessi\OneDrive\Desktop\journeyInput.txt");
            Console.WriteLine(calc.calculatePosition(journeyInput));
        }
    }
}
