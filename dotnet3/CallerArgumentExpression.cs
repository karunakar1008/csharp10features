using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace dotnet3
{
    internal class CallerArgumentExpression
    {
        public static void Main(string[] args)
        {
            string[] excelColumns = new string[] { "Firstname","Lastname","Designation","Salary" };


            Assert(excelColumns.Length != 4);
            Assert(excelColumns.Length != 4, "Excel does not have valid columns");

            Assert(!excelColumns.Contains("Firstname"));
            Assert(!excelColumns.Contains("Firstname"), "First name column is mandatory");

            Console.ReadLine();
        }
        public static void Assert(bool condition, string conditionExpression = default)
        {
            if (condition)
                throw new Exception($"Condition failed: {conditionExpression}");
        }
    }
}
