using System;
using System.Collections.Generic;
using System.Linq;

public class aoc_d2
{
    public void getfirststart()
    {
        int validPasswords = 0;

        string[] lines = System.IO.File.ReadAllLines(Environment.CurrentDirectory + "/inputs/day2.txt");
        foreach (string line in lines)
        {
            string[] passworddata = line.Split(" ");
            string[] limitations = passworddata[0].Split("-");
            char val = char.Parse(passworddata[1].Remove(1));
            int amount = passworddata[2].ToCharArray().Count(c => c == val);
            if (amount >= Int32.Parse(limitations[0]) && amount <= Int32.Parse(limitations[1]))
            {
                validPasswords++;
            }

        }
        System.Console.WriteLine(validPasswords);
    }

    public void getsecondstar()
    {
        int validPasswords = 0;

        string[] lines = System.IO.File.ReadAllLines(Environment.CurrentDirectory + "/inputs/day2.txt");
        foreach (string line in lines)
        {
            string[] passworddata = line.Split(" ");
            string[] limitations = passworddata[0].Split("-");
            char val = char.Parse(passworddata[1].Remove(1));
            int amount = passworddata[2].ToCharArray().Count(c => c == val);
            List<int> occurrences = new List<int>();
            if (amount > 0)
            {
                string pw = passworddata[2];
                for (int i = 0; i < passworddata[2].Length; i++)
                {
                    if (pw[i] == val)
                    {
                        occurrences.Add(i + 1);
                    }
                }
                System.Console.WriteLine(occurrences);

                if (occurrences.Contains(Int32.Parse(limitations[0])) ^ occurrences.Contains(Int32.Parse(limitations[1])))
                {
                    validPasswords++;
                }

            }

        }
        System.Console.WriteLine(validPasswords);
    }
}
