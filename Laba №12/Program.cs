﻿using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        string str = "ываолдидвадоладлоыав 99999999.45.45.45 123.45.7.0 йывфапиатрпвыфцВАЫПРО 23.45.65.212";
        Regex regex = new(@"\b((25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\b");
        MatchCollection matches = regex.Matches(str);

            foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}