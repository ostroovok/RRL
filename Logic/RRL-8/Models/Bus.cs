using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic
{
    public class Bus
    {
        public Coordinates BaseCoordinates { get; set; }
        public Coordinates TargetCoordinates { get; set; }
        public bool BusIsOverload { get; set; }
        public Random Random { get; set; }
        public Queue<BusStop> BusStops { get; } = new Queue<BusStop>();

        public event Emulation.MethodContainer OnActionWriting;
        public Bus(Coordinates baseCoordinates, Coordinates targetCoordinates)
        {
            BusStops = new Queue<BusStop>();
            BaseCoordinates = baseCoordinates ?? throw new ArgumentNullException(nameof(baseCoordinates));
            TargetCoordinates = targetCoordinates ?? throw new ArgumentNullException(nameof(targetCoordinates));
            Random = new Random();
            BusIsOverload = false;
        }
        public virtual BusStop NextTo()
        {
            if (BusStops.Count > 0)
            {
                Console.WriteLine(BusStops.Count);
                return BusStops.Dequeue(); 
            }
            else
            {
                return null;
            }
        }
        public void Start()
        {
            while (true)
            {
                if (BusStops.Count == 0)
                {
                    GoTo(BaseCoordinates);
                }
                else if(!BusIsOverload)
                {
                    BusStop bs = NextTo();
                    while (!TargetCoordinates.IsOn(bs.MyCoordinates))
                    {
                        GoTo(bs.MyCoordinates);
                    }
                    StartLanding(bs);
                    while (!TargetCoordinates.IsOn(BaseCoordinates))
                    {
                        GoTo(BaseCoordinates);
                    }
                }
            }
        }
        private void GoTo(Coordinates coordinates)
        {
            Thread.Sleep(100);
            if (!TargetCoordinates.IsOn(coordinates))
            {
                TargetCoordinates.MoveTo(coordinates);
            }
        }
        public bool IsWaiting()
        {
            return TargetCoordinates.IsOn(BaseCoordinates);
        }
        public void GoBase()
        {
            while (!TargetCoordinates.IsOn(BaseCoordinates))
            {
                GoTo(BaseCoordinates);
            }
            BusIsOverload = false;
        }
        public void Overload()
        {
            BusIsOverload = true;
            Thread.Sleep(1000);
            OnActionWritingFunction("Bus is OVERLOAD");
            GoBase();
        }
        public void StartLanding(BusStop bs) 
        {
            bs.GoInside();
        }
        public void NeedLanding(BusStop bs) //------ 1
        {
            BusStops.Enqueue(bs);
        }
        public virtual void OnActionWritingFunction(string message)
        {
            OnActionWriting?.Invoke(message);
        }
    }
}
