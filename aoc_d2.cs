using System;
using System.Linq;

public class aoc_d2
{
    public void getfirststart()
    {
        int validPasswords = 0;

        string[] lines = System.IO.File.ReadAllLines(@"C:\temp\aoc.txt");
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
}
