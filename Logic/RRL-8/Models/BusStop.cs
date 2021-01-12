using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic
{
    public class BusStop  
    {
        public event Emulation.MethodContainer OnActionWriting;
        public event Emulation.NeedLanding OnLanding;
        public event Emulation.BusOverload Overload;

        public bool Landing { get; set; }
        public bool IsNeedLanding { get; set; }
        public int OverloadChance { get; set; }
        public List<IPassenger> Passengers { get; set; }
        public Coordinates MyCoordinates { get; set; }
        public Random Random { get; set; }
        private readonly int _maxPlaces = 10;
        private readonly int _weight;

        public BusStop(Coordinates myCoordinates, int weight)
        {
            Passengers = new List<IPassenger>();
            MyCoordinates = myCoordinates;
            _weight = weight;
            Random = new Random();
            
        }
        public void Start()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (Passengers.Count < _maxPlaces && !Landing)
                {
                    IsNeedLanding = false;
                    PlusPassenger();
                }
                else if (!Landing)
                {
                    NeedLanding();
                    CountOverloadChance();
                } 
            }
        }
        public bool NeedLanding()
        {
            if (!IsNeedLanding)
            {
                IsNeedLanding = true;
                OnLanding?.Invoke(this);
                OnActionWritingFunction("Need landing");
                return true;
            }
            else
                return false;
        }
        private void CountOverloadChance()
        {
            foreach (var v in Passengers)
            {
                OverloadChance += v.Weight;
            }
            if(Passengers.Count > 0)
                OverloadChance /= Passengers.Count;
        }
        public void TryToRegen(IPassenger p)
        {
            lock (p)
            {
                while (p.IsDied) 
                {
                    p.NewLife();
                }
            }
        }
        private void PlusPassenger()
        {
            IPassenger p = RandomPassenger();
                
            if (p != null)
            {
                p.GoInsideBus += RemovePassengers;
                p.OnDeathPassenger += TryToRegen;
                Passengers.Add(p);
            }    
        }
        private IPassenger RandomPassenger()
        {
            int chance = Random.Next(101);
            if (chance > 65)
                return new ChildPassenger(Random.Next(101), Random.Next(75, 101), _weight);
            else if(chance > 50)
                return new BigPassenger(Random.Next(101), Random.Next(50, 75), _weight);
            else if(chance > 30)
                return new RegularPassenger(Random.Next(101), Random.Next(50, 101), _weight);
            return null;
        }
        public void GoInside() 
        {
            Landing = true;
            
            while (Landing)
            {
                if (IsOverloadChance())
                {
                    Landing = false;
                    OnActionWritingFunction("Landing interrupted");
                    Overload?.Invoke();
                    return;
                }

                if (Passengers.Count > 0)
                {
                    IPassenger p = LandingPassengers().Last();
                    lock(p)
                        p.GoInside();
                }
                else
                    Landing = false;
            }
            IsNeedLanding = false;
            OnActionWritingFunction("Landing is over");
        }
        private IEnumerable<IPassenger> LandingPassengers()
        {
            foreach (var v in Passengers)
            {
                yield return v;
            }
        }
        private void RemovePassengers(IPassenger p)
        {
            p.TimerStop();
            Passengers.Remove(p);
        }
        public bool IsOverloadChance()
        {
            int x = Random.Next(0, 100);
            if (x < OverloadChance)
            {
                return true;
            }
            return false;
        }
        public virtual void OnActionWritingFunction(string message)
        {
            OnActionWriting?.Invoke(message);
        }
    }
}