using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2.GestioneSpese.Presentation.Factory
{
    public interface IImportoRimborsato
    {
        double CalcolaRimborso(Spesa s);
    }
}
