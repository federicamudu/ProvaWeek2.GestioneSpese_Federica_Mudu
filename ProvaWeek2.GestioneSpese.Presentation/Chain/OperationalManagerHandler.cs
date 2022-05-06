using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2.GestioneSpese.Presentation.Chain
{
    public class OperationalManagerHandler : AbstractHandler
    {
        public override string Handle(Spesa request)
        {
            if(request.Importo >= 401 && request.Importo <= 1000)
            {
                return "Operational Manager";
            }
            else
            {
                return base.Handle(request);
            }            
        }
    }
}
