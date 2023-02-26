using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;

namespace Nunitlab
{
    public static class Triangle
    {
        static void Main(string[] args)
        {
        }
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "The Triangle is valid.";
            }
            else
            {
                result = "The Triangle is not valid.";
            }
            return result;
        }
    }
}