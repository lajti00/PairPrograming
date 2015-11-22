using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LajtiCodeKatas;
using NUnit.Framework;

namespace LajtiCodeKatasUnitTests
{
    class SampleInterfaceTest
    {
        [Test]
        public void UPCDHighPrecisionTest()
        {
            IMeasureDevice device = new UPCDHighPrecision();

            device.Start();

            var result = device.LifeTimes;

            foreach (var lifetime in result)
            {
                Console.WriteLine(lifetime);
            }

            device.Stop();

        }

        [Test]
        public void UPCDDeviceTest()
        {
            IMeasureDevice device = new UPCDDevice();

            device.Start();

            var result = device.LifeTimes;

            foreach (var lifetime in result)
            {
                Console.WriteLine(lifetime);
            }

            device.Stop();

        }
    }
}
