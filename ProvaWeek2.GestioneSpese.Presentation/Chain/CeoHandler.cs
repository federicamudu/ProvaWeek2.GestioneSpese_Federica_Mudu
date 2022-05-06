using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2.GestioneSpese.Presentation.Chain
{
    public class CeoHandler : AbstractHandler
    {
        public override string Handle(Spesa request)
        {
            if(request.Importo >= 1001 && request.Importo <= 2500)
            {
                return "CEO";
            }
            else
            {
                return base.Handle(request);
            }            
        }
    }
}
