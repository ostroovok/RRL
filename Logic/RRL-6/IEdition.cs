using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IEdition
    {
        string EditionName { get; set; }
        string Publication();
        string RemoveFromPublication();
        string GetInfo();
    }
}
