﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterStudentsPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var studentRecords = new List<string[]>();

            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                studentRecords.Add(tokens);

                input = Console.ReadLine();
            }

            studentRecords
                .Where(x => x[2].StartsWith("02") || x[2].StartsWith("+3592"))
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
