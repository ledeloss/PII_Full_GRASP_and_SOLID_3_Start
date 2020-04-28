using System.IO;

// Se Crea Clase ConsolePrinter  que implementa el Tipo IPrinter para hacerla Polimorfica
namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void PrintTicket( Recipe receta)
        {

        File.WriteAllText("Receta.txt", receta.GetTextToPrint());

        }
        
    }
}
