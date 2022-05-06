using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2.GestioneSpese.Presentation.Chain
{
    public class ManagerHandler : AbstractHandler
    {
        public override string Handle(Spesa request)
        {
            if(request.Importo <= 400)
            {
                return "Manager";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
