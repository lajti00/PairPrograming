using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LajtiCodeKatas;

namespace LajtiCodeKatasUnitTests
{
    [TestFixture]
    class LajtiBinaryChopTest
    {


        [Test]
        public void If_Use_RandomArrayGen_with_exact_predefined_lenght_and_the_lenght_of_the_result_array_is_the_shame()
        {
            var chopper = new LajtiBinaryChop();
            int lenght = 100;
            int[] testArray = new int[lenght];
            int min = 1;
            int max = 1000;
            chopper.RandomArrayGen(ref testArray, min, max);
            Assert.That(testArray.Length, Is.EqualTo(lenght));
        }
        /*[Test]
        public void If()
        {
            var chopper = new LajtiBinaryChop();
            int lenght = 100;
            int[] testArray = new int[lenght];
            int min = 1;
            int max = 1000;
            chopper.RandomArrayGen(ref testArray, min, max);
            Assert.That(testArray[0], Is.EqualTo(10));
        }*/
        [Test]
        public void If_Use_RandomArrayGen_we_get_sorted_array()
        {
            var chopper = new LajtiBinaryChop();
            int lenght = 100;
            int[] testArray = new int[lenght];
            int min = 1;
            int max = 100;
            bool isShorted = false;
            Random rnd = new Random();
            int randomIndx = rnd.Next(1, lenght - 1);
            chopper.RandomArrayGen(ref testArray, min, max);
            var resultArray = chopper.find(testArray, testArray.Max());
            if (testArray[resultArray[0] - 1] < testArray[resultArray[0]] && testArray[resultArray[0]] <= testArray[resultArray[0]+1])
                isShorted = true;

            Assert.That(isShorted, Is.True);
        }
        [Test]
        public void If_creatte_an_not_empty_Array_and_search_an_elemet_whic_is_contained_by_The_array_the_find_ptovide_the_good_index()
        {
            var sorter = new LajtiBinaryChop();
            int[] testArray = new int[11] { 1, 2, 4, 5, 6, 7, 9, 10, 11, 12, 13 };
            int number = 5;
            var resultArray = sorter.find(testArray, number);
            Assert.That(resultArray[0], Is.EqualTo(3));
        }
        [Test]
        public void If_creatte_an_not_empty_Array_and_search_an_elemet_whic_is_not_contained_by_the_array_the_find_ptovide_minus_one_result()
        {
            var sorter = new LajtiBinaryChop();
            int[] testArray = new int[10] { 1, 2, 5, 6, 7, 9, 10, 11, 12, 13 };
            int number = 15;
            var resultArray = sorter.find(testArray, number);
            Assert.That(resultArray[0], Is.EqualTo(-1));
        }
        [Test]
        public void If_creatte_an_empty_Array_and_search_an_elemet_find_ptovide_minus_one_result()
        {
            var sorter = new LajtiBinaryChop();
            int[] testArray = new int[0];
            int number = 15;
            var resultArray = sorter.find(testArray, number);
            Assert.That(resultArray[0], Is.EqualTo(-1));
        }


    }
}
