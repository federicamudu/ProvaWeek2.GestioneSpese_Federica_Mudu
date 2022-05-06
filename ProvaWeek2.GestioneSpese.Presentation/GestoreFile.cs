using ProvaWeek2.GestioneSpese.Presentation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek2.GestioneSpese.Presentation
{
    public class GestoreFile
    {
        static string path = @"C:\Users\federica.mudu\source\repos\ProvaWeek2.GestioneSpese\ProvaWeek2.GestioneSpese.Presentation\spese.txt";

        public static List<Spesa> GetAll()
        {
            List<Spesa> spese = new List<Spesa>();
            using (StreamReader sr = new StreamReader(path))
            {
                string contenutoFile = sr.ReadToEnd();

                if (string.IsNullOrEmpty(contenutoFile))//(contenutoFile==null || contenutoFile == "")
                {
                    return spese;
                }
                else
                {
                    var righeDelFile = contenutoFile.Split("\r\n");
                    for (int i = 0; i < righeDelFile.Length - 1; i++)
                    {
                        var campiDellaRiga = righeDelFile[i].Split(";");
                        Spesa s = new Spesa();
                        s.Data = DateTime.Parse(campiDellaRiga[0]);
                        s.Categoria = campiDellaRiga[1];
                        s.Descrizione = campiDellaRiga[2];
                        s.Importo = double.Parse(campiDellaRiga[3]);
                        spese.Add(s);
                    }
                }
                return spese;
            }
        }

        
    }
}
