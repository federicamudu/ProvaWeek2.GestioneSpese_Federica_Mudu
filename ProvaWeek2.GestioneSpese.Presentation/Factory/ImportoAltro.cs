using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2.GestioneSpese.Presentation.Factory
{
    public class ImportoAltro : IImportoRimborsato
    {
        public double CalcolaRimborso(Spesa s)
        {
            return (s.Importo * 10) / 100;
        }
    }
}
