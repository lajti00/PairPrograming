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

        public bool IsEmpty
        {
            get { return _itemList.Count == 0 & _priceList.Count == 0 & _unitList.Count == 0; }
        }
        public void Push(string item, string unit, double price)
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
            if(index == -1) throw new InvalidOperationException("The list does not contain the"+ item +"+item!!!");
            return index;
        }
        public void PercentageOffer(DateTime startTime, DateTime endTime, string item, double percentageDiscount)
        {
            if (startTime < System.DateTime.Now & endTime > System.DateTime.Now)
            {
                var i = searchItem(item);
                _priceList[i] = (1-percentageDiscount / 100) * _priceList[i];
            }

        }


        //TODO: Dependence offer, Delete item, Modify item, 

    }
}
