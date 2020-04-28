using System.IO;
using System;
// Se Crea Clase ConsolePrinter  que implementa el Tipo IPrinter para hacerla Polimorfica
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintTicket( Recipe receta)
        {

        Console.WriteLine(receta.GetTextToPrint());

        }
        
    }
}
