using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace Logic
{
    public class Emulation
    {
        public delegate void MethodContainer(string message);
        public delegate void NeedLanding(BusStop bs);
        public delegate void DeathPassenger(IPassenger p);
        public delegate void BusOverload();
        public delegate void PassengerToBus(IPassenger p);
        public List<BusStop> BusStops { get; } = new List<BusStop>();
        public List<Bus> Buses { get; } = new List<Bus>();
        public Bus Bus { get; }
        
        private List<Thread> _threads = new List<Thread>();
        private Random _random;

        public Emulation(Bus bus, List<BusStop> busStops)
        {
            _random = new Random();
            Bus = bus;
            BusStops = busStops;
        }
        public void Start()
        {
            foreach (var v in BusStops)
            {
                v.OnActionWriting += EchoFunc;
                Bus.OnActionWriting += EchoFunc;
                v.OnActionWriting += EchoFunc;
                v.OnLanding += Bus.NeedLanding;
                v.Random = _random;
                v.Overload += Bus.Overload;

                Thread busStopThread = new Thread(v.Start);

                busStopThread.Start();
                _threads.Add(busStopThread); 
            }
            Thread busThread = new Thread(Bus.Start);
            busThread.Name = "Автобус";
            busThread.Start();
            _threads.Add(busThread);
        }

        public void EchoFunc(string message)
        {
            Console.WriteLine(message);
        }

        public void Stop()
        {
            foreach (var thread in _threads)
            {
                thread.Abort();
            }
        }
    }
}