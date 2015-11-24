using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LajtiCodeKatas;
using NUnit.Framework;

namespace LajtiCodeKatasUnitTests
{
    class PriceCalculatorTest
    {
        [Test]
        public void IfIcreateItemListItIsEmpty()
        {
            var priceCalc = new PriceCalculator();
            Assert.That(priceCalc.IsEmpty, Is.True);
        }

        [Test]
        public void IfIcreatePushAnItemToPriveCalcItDoesNotEmptyAnimore()
        {
            var priceCalc = new PriceCalculator();
            priceCalc.Push("Apple", "bag", 1, 0);
            Assert.That(priceCalc.IsEmpty, Is.False);
        }

        [Test]
        public void IfIcreatePushAnItemToPriceCalcTheCountResultingTheNumberOfAddedItem()
        {
            var priceCalc = new PriceCalculator();
            priceCalc.Push("Beans", "can", 0.65, 0);
            priceCalc.Push("Bread", "loaf", 0.80, 0);
            priceCalc.Push("Milk", "bottle", 1.30, 0);
            priceCalc.Push("Apple", "bag", 1, 0);
            Assert.That(priceCalc.Count, Is.EqualTo(4));
        }
        [Test]
        public void IfIPushAnItemToPriceCalcWhichIsAlreadyPushedThePushReturnWithExeption()
        {
            var priceCalc = new PriceCalculator();
            priceCalc.Push("Beans", "can", 0.65, 0);
            priceCalc.Push("Bread", "loaf", 0.80, 0);
            priceCalc.Push("Milk", "bottle", 1.30, 0);
            priceCalc.Push("Apple", "bag", 1, 0);
            Assert.Throws<InvalidOperationException>(() => priceCalc.Push("Apple", "bag", 2, 0));
        }
        [Test]
        public void IfIcreatePushAnItemToPriceCalcTheListItemsWillListThem()
        {
            var priceCalc = new PriceCalculator();
            priceCalc.Push("Beans", "can", 0.65, 0);
            priceCalc.Push("Bread", "loaf", 0.80, 0);
            priceCalc.Push("Milk", "bottle", 1.30, 0);
            priceCalc.Push("Apple", "bag", 1, 0);
            priceCalc.ListItems();
        }
        [Test]
        public void IfsearcheAnItemTheSearchItemReturnTheCorrectIndex()
        {
            var priceCalc = new PriceCalculator();
            priceCalc.Push("Beans", "can", 0.65, 0);
            priceCalc.Push("Bread", "loaf", 0.80, 0);
            priceCalc.Push("Milk", "bottle", 1.30, 0);
            priceCalc.Push("Apple", "bag", 1, 0);
            Assert.That(priceCalc.searchItem("Milk"), Is.EqualTo(2));
        }
        [Test]
        public void IfsearcheAnItemWhickIsNotElementOfListTheSearchItemReturnExeption()
        {
            var priceCalc = new PriceCalculator();
            priceCalc.Push("Beans", "can", 0.65, 0);
            priceCalc.Push("Bread", "loaf", 0.80, 0);
            priceCalc.Push("Milk", "bottle", 1.30, 0);
            priceCalc.Push("Apple", "bag", 1, 0);
            Assert.Throws<InvalidOperationException>(() => priceCalc.searchItem("Milkk"));
        }
        [Test]
        public void IfWeUseThePercentageOfferThePriceOfTheDeffinedItemWillChange()
        {
            var priceCalc = new PriceCalculator();
            DateTime startDate = new DateTime(2015, 11, 2, 0, 0, 0);
            DateTime endDate = new DateTime(2015, 11, 30, 0, 0, 0);

            priceCalc.Push("Beans", "can", 0.65, 0);
            priceCalc.Push("Bread", "loaf", 0.80, 0);
            priceCalc.Push("Milk", "bottle", 1.30, 0);
            priceCalc.Push("Apple", "bag", 1, 0);
            priceCalc.ListItems();
            string[] wish = { "Apple", "1" };
            priceCalc.PercentageOffer(startDate, endDate, "Apple", 10, wish);
            Console.WriteLine("AfterOffer");
            priceCalc.ListItems();
            Assert.That(priceCalc._priceList[3], Is.EqualTo(0.9));
        }
        public void IfIModifyAnItemToPriceCalcWhichIsNotPushedBeforeTheModifyReturnWithExeption()
        {
            var priceCalc = new PriceCalculator();
            priceCalc.Push("Beans", "can", 0.65, 0);
            priceCalc.Push("Bread", "loaf", 0.80, 0);
            priceCalc.Push("Milk", "bottle", 1.30, 0);
            
            Assert.Throws<InvalidOperationException>(() => priceCalc.Modify("Apple", "bag", 2, 0));
        }
        [Test]
        public void IfIModifyAnItemToPriceCalcTheWaluesChange()
        {
            var priceCalc = new PriceCalculator();
            priceCalc.Push("Beans", "can", 0.65, 0);
            priceCalc.Push("Bread", "loaf", 0.80, 0);
            priceCalc.Push("Milk", "bottle", 1.30, 0);
            priceCalc.Push("Apple", "bag", 1, 0);
            priceCalc.Modify("Apple", "bag", 10, 0);
            Assert.That(priceCalc._priceList[3], Is.EqualTo(10));

        }
        [Test]
        public void Ifge()
        {
            var priceCalc = new PriceCalculator();
            priceCalc.Push("Beans", "can", 0.65, 0);
            priceCalc.Push("Bread", "loaf", 0.80, 0);
            priceCalc.Push("Milk", "bottle", 1.30, 0);
            priceCalc.Push("Apple", "bag", 1, 0);
            priceCalc.Modify("Apple", "bag", 10, 0);

            priceCalc.Calculator("Apple,2,Milk,3,Beans,2,Bread,1");

            //Assert.That(priceCalc._priceList[3], Is.EqualTo(10));

        }

    }
}
