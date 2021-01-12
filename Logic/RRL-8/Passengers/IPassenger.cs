using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IPassenger
    {
        event Emulation.PassengerToBus GoInsideBus;
        event Emulation.DeathPassenger OnDeathPassenger;
        int Weight { get; }
        int DeathChance { get; }
        bool IsDied { get; set; }
        int Speed { get; }
        void TimerStop();
        void Wait();
        void GoInside();
        bool IsDeath();
        void NewLife();
    }
}
