using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LajtiCodeKatas
{

    public interface IMeasureDevice
    {
        void Start();
        void Stop();
        double[] LifeTimes { get;}
    }

    public class UPCDDevice : IMeasureDevice
    {

        public void Start()
        {
            Console.WriteLine("start measurement");
        }

        public void Stop()
        {
            Console.WriteLine("Stop measurement.");
        }

        public double[] LifeTimes
        {
            get { return new double[] {1, 2, 3}; }
        }

        public string Positions { get; set; }
    }

    public class UPCDHighPrecision : IMeasureDevice
    {

        public void Start()
        {
            Console.WriteLine("start measurement");
        }

        public void Stop()
        {
            Console.WriteLine("Stop measurement.");
        }

        public double[] LifeTimes
        {
            get { return new double[] { 1.1, 2.2, 3.3 }; }
        }
    }

    class SPVDevice : IMeasureDevice
    {

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public double[] LifeTimes
        {
            get { throw new NotImplementedException(); }
        }
    }
}
