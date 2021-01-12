using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic
{
    public class RegularPassenger : IPassenger
    {
        public virtual int Weight { get; }
        public virtual bool IsDied { get; set; }
        public virtual int DeathChance { get; }
        public virtual int Speed { get; }

        private Random _random;
        private int _timerClick = 0;
        private Timer _tmr;
        public virtual event Emulation.PassengerToBus GoInsideBus;
        public virtual event Emulation.DeathPassenger OnDeathPassenger;
        public RegularPassenger(int deathChance, int speed, int w)
        {
            if (deathChance > 100 || deathChance < 0)
                throw new ArgumentOutOfRangeException();
            Weight = w;
            _random = new Random();
            DeathChance = deathChance;
            Speed = speed;
            TimerStart();
        }
        public void TmClick(object o)
        {
            _timerClick++;
            if (_timerClick > 10)
            {
                if (IsDeath())
                {
                    IsDied = true;
                    OnDeathPassenger?.Invoke(this);
                }
            } 
        }
        public void TimerStop()
        {
            _tmr.Dispose();
        }
        private void TimerStart()
        {
            TimerCallback tm = new TimerCallback(TmClick);
            _tmr = new Timer(tm, 1, 0, 1000);
        }
        public bool IsDeath()
        {
            int x = _random.Next(0, 100);
            if (x < DeathChance)
                return true;
            return false;
        }
        public void NewLife()
        {
            _timerClick = 5;
            int x = _random.Next(0, 100);
            if (x > 75)
                IsDied = false;
            Thread.Sleep(1000);
        }
        public virtual void GoInside()
        { 
            Wait();
            _tmr.Dispose();
            GoInsideBus?.Invoke(this);
        }
        public void Wait()
        {
            Thread.Sleep(10000/Speed*Weight);
        }
    }
}
