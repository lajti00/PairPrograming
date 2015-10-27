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
        public void If_creatte_an_not_empty_Array_and_search_an_elemet_whic_is_contained_by_The_array_the_find_ptovide_the_good_index()
        {

            //Arrange
            var sorter = new LajtiBinaryChop();
            int[] testArray = new int[] { 1, 2, 4, 5, 6};
            int number = 5;
            
            //Act
            var resultArray = sorter.Find(testArray, number);
            
            //Assert
            Assert.That(resultArray[0], Is.EqualTo(3));
        }
        [Test]
        public void If_creatte_an_not_empty_Array_and_search_an_elemet_whic_is_not_contained_by_the_array_the_find_ptovide_minus_one_result()
        {
            var sorter = new LajtiBinaryChop();
            int[] testArray = new int[] { 1, 2 };
            int number = 15;

            var resultArray = sorter.Find(testArray, number);
            
            Assert.That(resultArray[0], Is.EqualTo(-1));
        }
        [Test]
        public void If_creatte_an_empty_Array_and_search_an_elemet_find_ptovide_minus_one_result()
        {
            var sorter = new LajtiBinaryChop();
            int[] testArray = new int[0];
            int number = 15;

            var resultArray = sorter.Find(testArray, number);

            Assert.That(resultArray[0], Is.EqualTo(-1));
        }


    }
}
