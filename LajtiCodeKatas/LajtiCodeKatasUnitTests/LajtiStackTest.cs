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
    public class LajtiStackTest
    {
        [Test]
        public void TheStackIsEmptyAfterCreation()
        {
            var stack = new LajtiStack();

            Assert.That(stack.IsEmpty, Is.True);
        }

        [Test]
        public void WhenAnItemIsAddedToTheStackThenTheNumberOfItemsIsOneAndtheStackIsNotEmptyAnyMore()
        {
            var stack = new LajtiStack();
            stack.Push(123);
            Assert.That(stack.IsEmpty, Is.False);
        }

        [Test]
        public void when_OneItem_Added_I_Can_Popp_It()
        {
            var stack = new LajtiStack();
            stack.Push(123);
            var result = stack.Pop();
            Assert.That(result, Is.EqualTo(123));
        }

        [Test]
        public void When_put_two_items_to_the_stack_then_cout()
        {
            var stack = new LajtiStack();
            stack.Push(123);
            stack.Push(456);
            var result = stack.Pop();
            Assert.That(result, Is.EqualTo(456));
        }


        [Test]
        public void when_the_stack_is_epty_then_the_pop_equal_to_exeption()
        {
            var stack = new LajtiStack();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void whent_the_stack_notepty_the_IsEmpty_is_false()
        {
            var stack = new LajtiStack();
            stack.Push(456);
            Assert.That(stack.IsEmpty, Is.False);
        }

        [Test]
        public void if_the_stack_lenght_is_one_and_pop_that_the_isEmpty_is_true()
        {
            var stack = new LajtiStack();
            stack.Push(456);
            stack.Pop();
            Assert.That(stack.IsEmpty, Is.True);
        }


        [Test]
        public void if_pop_the_last_elemet_of_stack_the_stack_does_not_contain_it_anymore()
        {
            var stack = new LajtiStack();
            stack.Push(456);
            stack.Push(999);
            var result1 = stack.Pop();
            var result2 = stack.Pop();
            Assert.That(result2, Is.EqualTo(456));
        }

        [Test]
        public void if_peak_the_last_elemet_of_stack_the_stack_still_contain_it()
        {
            var stack = new LajtiStack();
            stack.Push(456);
            stack.Push(999);
            var result1 = stack.Peek();
            var result2 = stack.Peek();
            Assert.That(result1, Is.EqualTo(999));
            Assert.That(result2, Is.EqualTo(999));
        }

        [Test]
        public void when_the_stack_is_epty_then_the_peek_equal_to_exeption()
        {
            var stack = new LajtiStack();
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Test]
        public void If_the_stack_epty_the_cout_return_zero()
        {
            var stack = new LajtiStack();

            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void If_the_stack_is_not_epty_the_cout_return_nonzero()
        {
            var stack = new LajtiStack();
            stack.Push(1);
            Assert.That(stack.Count, Is.EqualTo(1));
            stack.Push(2);
            Assert.That(stack.Count, Is.EqualTo(2));
        }
    }
}
