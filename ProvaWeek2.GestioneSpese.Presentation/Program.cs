using ProvaWeek2.GestioneSpese.Presentation;
using ProvaWeek2.GestioneSpese.Presentation.Chain;
using ProvaWeek2.GestioneSpese.Presentation.Factory;

Console.WriteLine("================Benvenuto nell'app Gestione spesa==================");
List<Spesa> listaSpesa = GestoreFile.GetAll();
IEnumerable<Spesa> listaSpeseApprovate;
IEnumerable<Spesa> listaSpeseNonApprovate;

VisualizzaElenco();

#region Chain
IHandler manager = new ManagerHandler();
IHandler operationalManager = new OperationalManagerHandler();
IHandler ceo = new CeoHandler();

manager.SetNext(operationalManager).SetNext(ceo);
foreach (var item in listaSpesa)
{
    if (manager.Handle(item) == null)
    {
        item.LivelloApprovazione = null;
        item.Approvata = false;
        Console.WriteLine("Spesa non approvata! Il tuo importo è maggiore di 2500 euro");
        Console.WriteLine("__________________________________________________________________");
    }
    else
    {        
        item.LivelloApprovazione = manager.Handle(item);
        item.Approvata = true;
        Console.WriteLine($"Spesa approvata, livello di approvazione {manager.Handle(item)}");
        Console.WriteLine("__________________________________________________________________");
    }
}
#endregion
#region Factory
FactoryRimborso factory = new FactoryRimborso();
listaSpeseApprovate = listaSpesa.Where(item => item.Approvata == true);
listaSpeseNonApprovate = listaSpesa.Where(item => item.Approvata == false);
foreach (var item in listaSpeseApprovate)
{
    string categoria = item.Categoria;
    IImportoRimborsato tipoRimborso = factory.GetImporto(categoria);
    item.ImportoRimborsato = tipoRimborso.CalcolaRimborso(item);
}
#endregion
#region ScritturaFile
try
{
    StreamWriter sw = File.CreateText(@"C:\Users\federica.mudu\source\repos\ProvaWeek2.GestioneSpese\ProvaWeek2.GestioneSpese.Presentation\spese_elaborate.txt");
    foreach (var item in listaSpeseApprovate)
    {
        sw.WriteLine(item.GetInfoApprovazione());
    }
    foreach (var item in listaSpeseNonApprovate)
    {
        sw.WriteLine(item.GetInfoApprovazione());
    }
    sw.Close();
}
catch (IOException IO)
{
    Console.WriteLine($"I/O Error: {IO.Message}");
}
catch (Exception E)
{
    Console.WriteLine($"Errore generico: {E.Message}");
}
#endregion









void VisualizzaElenco()
{
    var listaSpese = GestoreFile.GetAll();
    if(listaSpese == null)
    {
        Console.WriteLine("Lista Vuota");
    }
    else
    {
        Console.WriteLine("Ecco la lista");
        foreach (var item in listaSpese)
        {
            Console.WriteLine(item.GetInfo());
            Console.WriteLine("*******************");
        }
    }
}


