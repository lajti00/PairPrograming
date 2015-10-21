using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LajtiCodeKatas;
using NUnit.Framework;

namespace LajtiCodeKatasUnitTests
{
            
    [TestFixture]
    class LajtiStringCalculatorTest
    {
            [Test]
            public void If_Add_two_number_which_separated_by_coma_the_result_is_the_sum_of_the_two_number()
            {
                var calculator = new LajtiStringCalculator();
 
                Assert.That(calculator.Add("1,2"), Is.EqualTo(3));
            }
            [Test]
            public void If_Add_more_than_two_number_which_separated_by_coma_the_result_equal_to_exeption()
            {
                var calculator = new LajtiStringCalculator();
                Assert.Throws<InvalidOperationException>(() => calculator.Add("1,2,3"));
            }
            
            [Test]
            public void If_the_input_string_contains_two_invalid_caracter_stacks_separated_by_coma_the_result_equal_to_exeption()
            {
                var calculator = new LajtiStringCalculator();
                Assert.Throws<InvalidOperationException>(() => calculator.Add("23,dsadf"));
            }

            [Test]
            public void If_the_input_string_is_empty_result_equal_to_exeption()
            {
                var calculator = new LajtiStringCalculator();
                Assert.Throws<InvalidOperationException>(() => calculator.Add(""));
            }

            [Test]
            public void If_the_input_string_is_null_result_equal_to_exeption()
            {
                var calculator = new LajtiStringCalculator();
                Assert.Throws<InvalidOperationException>(() => calculator.Add(null));
            }
            
            [Test]
            public void If_the_input_only_one_string_is_null_result_equal_to_exeption()
            {
                var calculator = new LajtiStringCalculator();
                Assert.Throws<InvalidOperationException>(() => calculator.Add("1,"));
            }

    }
    
}
