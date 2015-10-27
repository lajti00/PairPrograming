using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LajtiCodeKatas;
using NUnit.Framework;

namespace LajtiCodeKatasUnitTests
{
    class SimpleClassTest
    {
        [Test]
        public void Name()
        {
            Person person = new Person();

            person.Age = 12;
            person.Name = "Lajti";

            var age = person.Age;


            person.DoSomething();
        }

        [Test]
        public void Default_Age()
        {
            var simpleclass = new Person();

            Assert.That(simpleclass.Age, Is.EqualTo(18));
        }

        [Test]
        public void CreatePerson()
        {
            var person = new Person(66);

            Assert.That(person.Age , Is.EqualTo(66));
        }

        [Test]
        public void AgeChanged()
        {
            var person = new Person(66);

            
            //lambda expression:  nyil =>
            person.AgeChanged += (sender, args) => Console.WriteLine("Age has chaned!");

            person.Age = 112;

        }
    }
}
