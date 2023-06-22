using Capa_Modelo.Cola;

namespace Capa_Logica.Cola
{
    public class Orquestador_Cola
    {
        private NodoInt_Cola cabeza;
        private NodoInt_Cola final;

        private bool Cabeza_No_Nula()
        {

            return cabeza != null ? true : false;

        }
        public void Enqueue(int _valor) {

            if (Cabeza_No_Nula())
            {
                //Nodo de referencia
                NodoInt_Cola nodoActual = final;

                //Creación del nodo nuevo
                NodoInt_Cola nodoNuevo = new NodoInt_Cola(_valor);

                //Agregar  referencia hacia adelante
                nodoActual.Siguiente = nodoNuevo;

                //Se define el nuevo final
                final = nodoNuevo;
            }
            else
            {
                NodoInt_Cola nodoNuevo = new NodoInt_Cola(_valor);
                cabeza = nodoNuevo;
                final = nodoNuevo;
            }
        }

        public NodoInt_Cola Dequeue() {

            NodoInt_Cola nodoDequeue = null;

            if (Cabeza_No_Nula())
            {
                //Nodo de referencia
                NodoInt_Cola nodoActual = cabeza;

                cabeza = nodoActual.Siguiente;

                nodoDequeue= nodoActual;
            }

            return nodoDequeue;
        }

        public void Imprimir_Cola()
        {            
            if (Cabeza_No_Nula())
            {
                NodoInt_Cola nodoActual = cabeza;

                string cola = "";

                while (nodoActual != null)
                {
                    int valorActual = nodoActual.Valor;
                    cola = cola +" " + valorActual.ToString();
                    nodoActual = nodoActual.Siguiente;
                }
                Console.WriteLine("*-*-*-*Empieza Cola*-*-*-*");
                Console.WriteLine(cola);
                Console.WriteLine("*-*-*-*Termina Cola*-*-*-*");
            }           
        }
    }
}
