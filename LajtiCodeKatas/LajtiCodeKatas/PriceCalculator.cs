using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LajtiCodeKatas
{
    public class PriceCalculator
    {
        private readonly List<string> _itemList = new List<string>();
        public readonly List<double> _priceList = new List<double>();
        private readonly List<string> _unitList = new List<string>();
        // no offer: 0; percentage offer: 1; dependence offer: 2;
        private readonly List<int> _offerList = new List<int>();

        public bool IsEmpty
        {
            get { return _itemList.Count == 0 & _priceList.Count == 0 & _unitList.Count == 0 & _offerList.Count == 0; }
        }
        public void Push(string item, string unit, double price, int offer)
        {
            int index = -1;
            for (int i = 0; i < Count; i++)
            {
                if (_itemList[i] == item)
                    index = i;
            }
            if (index != -1) throw new InvalidOperationException("The list already contains the" + item + "+item! Please use Modify!");

            _itemList.Add(item);
            _unitList.Add(unit);
            _priceList.Add(price);
            _offerList.Add(offer);
        }
        public void Modify(string item, string unit, double price, int offer)
        {

            var index = searchItem(item);
            _unitList[index] = unit;
            _priceList[index] = price;
            _offerList[index] = offer;
        }
        public int Count
        {
            get { return _itemList.Count; }
        }
        public void ListItems()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_itemList[i].ToString()+ "\t"+ _priceList[i].ToString()+"\t" + _unitList[i].ToString());
            }
        }
        public int searchItem(string item)
        {
            int index = -1;
            for (int i = 0; i < Count; i++)
            {
                if (_itemList[i] == item)
                {
                    index = i;
                }
            }
            if(index == -1) throw new InvalidOperationException("The list does not contain the"+ item +" item!!!");
            return index;
        }
        public void PercentageOffer(DateTime startTime, DateTime endTime, string item, double percentageDiscount, string[] wishesArray)
        {
            if (startTime < System.DateTime.Now & endTime > System.DateTime.Now)
            {
                for(int j = 0; j < wishesArray.Length / 2; j++)
                {
                    if(wishesArray[j * 2] == item)
                    {
                        var i = searchItem(item);
                        _priceList[i] = (1 - percentageDiscount / 100) * _priceList[i];
                        Console.WriteLine(_itemList[i] + " has " + percentageDiscount.ToString() + "% discount ");
                        _offerList[i] = 1;
                    }
                }


            }

        }
        public void DependenceOffer(DateTime startTime, DateTime endTime, string item, string itemDependence, int dependenceCount, double percentageDiscount, string[] wishesArray)
        {
            if (startTime < System.DateTime.Now & endTime > System.DateTime.Now)
            {
                bool dep1 = false;
                bool dep2 = false;
                for (int j = 0; j < wishesArray.Length / 2; j++)
                {
                    if (wishesArray[j * 2] == item) {dep1 = true;}
                    if (wishesArray[j * 2] == itemDependence & Convert.ToInt32(wishesArray[j * 2+1])>= dependenceCount) { dep2 = true; }

                }

                if (dep1  & dep2 )
                {
                    var i = searchItem(item);
                    _priceList[i] = (1 - percentageDiscount / 100) * _priceList[i];
                    Console.WriteLine(_itemList[i] + " has " + percentageDiscount.ToString() + "% discount ");
                    _offerList[i] = 1;

                } 
            }

        }
        public void Calculator(string wishes)
        {
            //wishes "item,count,item,count ...."
            var wishesArray = wishes.Split(',');
            //offers
            DateTime startDate = new DateTime(2015, 11, 2, 0, 0, 0);
            DateTime endDate = new DateTime(2015, 11, 30, 0, 0, 0);
            PercentageOffer(startDate, endDate, "Apple", 10, wishesArray);
            DateTime startDate2 = new DateTime(2015, 11, 2, 0, 0, 0);
            DateTime endDate2 = new DateTime(2015, 11, 30, 0, 0, 0);
            DependenceOffer(startDate, endDate,"Bread", "Beans",2, 50, wishesArray);

            int offer = 0;
            for (int i = 0; i < wishesArray.Length/2; i++)
            {
                var item = searchItem(wishesArray[i * 2]);
                var count = Convert.ToInt32(wishesArray[i * 2 + 1]);
                double price = _priceList[item] * count;
                Console.WriteLine(_itemList[item] + "\t" + count.ToString() + _unitList[item] + "\t" + "subtotal" + "\t" + price.ToString());
                offer += _offerList[item];
            }
            if (offer == 0) { Console.WriteLine("(No offers available)"); }
        }

        //TODO:  Delete item, offer list to bool 

    }
}
