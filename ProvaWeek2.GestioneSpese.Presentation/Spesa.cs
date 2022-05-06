using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2.GestioneSpese.Presentation
{
    public class Spesa
    {
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public double Importo { get; set; }
        public bool Approvata { get; set; }
        public string LivelloApprovazione { get; set; }
        public double ImportoRimborsato { get; set; }

        public string GetInfo()
        {
            return $"Data: {Data.ToShortDateString()};\nCategoria: {Categoria};\nDescrizione: {Descrizione};\nImporto: {Importo} euro";
        }
        public string GetInfoApprovazione()
        {
            if (Approvata)
            {
                return $"{Data.ToShortDateString()};{Categoria};{Descrizione};APPROVATA;{LivelloApprovazione};{ImportoRimborsato}";
            }
            else
            {
                return $"{Data.ToShortDateString()};{Categoria};{Descrizione};RESPINTA;-;-";
            }
        }
    }
}
