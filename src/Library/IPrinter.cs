
// Se Crea el Tipo IPrinter para convertirla en Polimorfica, El Metodo PrintTicket es implementado luego
//por dos Clases : FilePrinter y ConsolePrinter. 
//Estas utilizan el metodo PrintTicket para realizar diferentes acciones (Imprime en pantalla o Imprime a archivo).

namespace Full_GRASP_And_SOLID.Library
{
   public interface IPrinter
{
    void PrintTicket(Recipe receta);
}
}