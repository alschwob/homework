using System;
using System.Runtime.InteropServices;

namespace ShirtProj
{
    internal class shirt
    {

        static void Main(string[] args)
        {
            ColorsPatterns cp = new ColorsPatterns();
            string[] c = cp.GetColors();
            string[] p = cp.GetPatterns();
            createShirt(c,p);
        }
        
       public static void createShirt(string[] colors, string[]patterns)
        { 
            Random r = new Random();
            for (int i = 0; i < colors.Length; i++)
            {
                for (int j = 0; j < patterns.Length; j++)
                {
                   
                    {
                        if (patterns[j] == "solid")
                        {
                            string color = colors[i];
                            string pattern = patterns[j];
                            Console.WriteLine($"Color: {color}, Pattern: {pattern}");
                        }
                        else
                        {
                            string pattern = patterns[j];
                            string color = colors[i];
                            string color2 = colors[r.Next(colors.Length)];
                                do
                                {
                                    color2 = colors[r.Next(colors.Length)];
                                } while (color2 == color);
                            Console.WriteLine($"Colors: {color} and {color2}, Pattern: {pattern}");
                        }
                       
                    }
                }
            }
        }
    }
}