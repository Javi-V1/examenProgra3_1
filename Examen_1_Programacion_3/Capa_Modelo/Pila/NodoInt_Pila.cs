using Capa_Modelo.Nodo;

namespace Capa_Modelo.Pila
{
    public class NodoInt_Pila : Nodo<int, NodoInt_Pila>
    {
        public override int Valor { get; set; }
        public override NodoInt_Pila Siguiente { get; set; }

        public NodoInt_Pila(int _valor)
        {
            Valor = _valor;
            Siguiente = null;
        }
    }
}
