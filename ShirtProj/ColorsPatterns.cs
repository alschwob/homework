using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtProj
{
    public class ColorsPatterns
    {
        string [] colors = new string[]
            {
                "Red",
                 "Green",
                "Blue",
                "Yellow"
            };
        string[] patterns = new string[]
                    {
                       "striped",
                       "solid",
                       "checkered",
                       "tie die"
                    };
        public string[] GetColors()
        {
            return colors;
        }
        public string[] GetPatterns()
        {
            return patterns;
        }
    }
}
