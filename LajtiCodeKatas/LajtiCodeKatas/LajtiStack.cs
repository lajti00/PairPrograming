using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LajtiCodeKatas
{
    public class LajtiStack
    {
        public bool IsEmpty
        {
            get { return _container.Count == 0; }
        }

        private readonly List<int> _container = new List<int>();

        public void Push(int item)
        {
            _container.Add(item);
        }

        public int Pop()
        {
            if (IsEmpty) throw new InvalidOperationException("You can not pop from an empty stack.");
            var last = _container[Count - 1];
            _container.Remove(last);
            return last;
        }

        public int Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("You can not peek from an empty stack.");
            var last = _container[Count - 1];
            return last;
        }

        public int Count
        {
            get { return _container.Count; }
        }


    }
}
