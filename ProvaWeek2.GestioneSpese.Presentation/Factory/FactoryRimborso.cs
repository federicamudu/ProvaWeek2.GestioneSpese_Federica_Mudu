using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2.GestioneSpese.Presentation.Factory
{
    public class FactoryRimborso
    {
        public IImportoRimborsato GetImporto(string categoria)
        {
            IImportoRimborsato rimborso = null;

            switch (categoria)
            {
                case "Viaggio":
                    rimborso = new ImportoViaggio();
                    break;
                case "Alloggio":
                    rimborso = new ImportoAlloggio();
                    break;
                case "Vitto":
                    rimborso = new ImportoVitto();
                    break;
                case "Altro":
                    rimborso = new ImportoAltro();
                    break;
                default:
                    Console.WriteLine("Categoria non valida!");
                    break;
            }
            return rimborso;
        }
    }
}
