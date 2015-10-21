using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LajtiCodeKatas
{
    public class LajtiStringCalculator
    {
        public int Add(string input)
        {
            if (input == null) throw new InvalidOperationException("Bad input format: You cannot use null as input! The good format is \"Integer32,Integer32\"");

            var splited = input.Split(',');
            if (splited.Length != 2) throw new InvalidOperationException("Bad input format: You cannot add more than two numbers! The good format is \"Integer32,Integer32\"");

            try
            {
                var value1 = Convert.ToInt32(splited[0]);
                var value2 = Convert.ToInt32(splited[1]);
                return value1 + value2;

            }
            catch (Exception)
            {

                throw new InvalidOperationException("Bad input format: You can add only two numbers! The good format is \"Integer32,Integer32\""); ;
            }

        }

    }
}
