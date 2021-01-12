using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic
{
    public class ChildPassenger : RegularPassenger
    {
        public ChildPassenger(int deathChance, int speed, int w) : base(deathChance, speed, w)
        {
        }
        public override event Emulation.PassengerToBus GoInsideBus;
        static AutoResetEvent waitHandler = new AutoResetEvent(true);
        public override int Weight => base.Weight/2;

        public override bool IsDied { get => base.IsDied; set => base.IsDied = value; }
        public override int DeathChance => 0;

        public override int Speed => base.Speed*2;

        public override void GoInside()
        {
            Wait();
            GoInsideBus?.Invoke(this);
        }
    }
}
