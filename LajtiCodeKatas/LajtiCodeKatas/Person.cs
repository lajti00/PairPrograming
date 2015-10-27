using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LajtiCodeKatas
{
    public class Person
    {
        public Person()
        {
            Age = 18;
        }

        public Person(int age)
        {
            Age = age;
        }



        //property
        public int Age
        {
            get { return _age; }
            set
            {
                if(value < 0)
                    throw new ArgumentOutOfRangeException("Negative age doesnt make sense.");
                _age = value;
                OnAgeChanged();
            }
        }

        public string Name { get; set; }

        //field:
        private int _age;

        //method
        public void DoSomething()
        {
            Console.WriteLine("hello world.");
        }

        //event:
        public event EventHandler AgeChanged;


        protected virtual void OnAgeChanged()
        {
            var handler = AgeChanged;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}
