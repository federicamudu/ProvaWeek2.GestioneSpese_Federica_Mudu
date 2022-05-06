using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2.GestioneSpese.Presentation.Chain
{
    public interface IHandler
    {
        IHandler SetNext(IHandler next);
        string Handle(Spesa request);
    }
}
