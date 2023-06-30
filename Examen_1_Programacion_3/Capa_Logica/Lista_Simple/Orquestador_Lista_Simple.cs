﻿using Capa_Modelo.LS;

namespace Capa_Logica.Lista_Simple
{
    public class Orquestador_Lista_Simple
    {

        private NodoInt_LS cabeza;
        private int length=0;

        private bool Cabeza_No_Nula()
        {

            if (cabeza != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Agregar_NodoInt_LS(int valor)
        {

            NodoInt_LS nodoNuevo = new NodoInt_LS(valor);

            if (!Cabeza_No_Nula())
            {
                cabeza = nodoNuevo;
                length++;
            }
            else
            {
                NodoInt_LS nodoActual = cabeza;

                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                }
                length++;
                nodoActual.Siguiente = nodoNuevo;
            }
        }

        public void Mostrar_Lista_Simple()
        {
           
            Console.WriteLine("*-*-*-*Empieza Lista*-*-*-*");
            if (Cabeza_No_Nula())
            {
                NodoInt_LS nodoActual = cabeza;

                while (nodoActual != null)
                {
                    int valorActual = nodoActual.Valor;
                    Console.WriteLine(valorActual.ToString());
                    nodoActual = nodoActual.Siguiente;
                }               
            }
            Console.WriteLine("*-*-*-*Termina Lista*-*-*-*");
        }

        /// <summary>
        /// Debe buscar el elemento máximo de la lista y retornarlo
        /// </summary>
        /// <returns></returns>
        public int Busque_Numero_Maximo_Lista() {

            int maximo = 0; 
            if (Cabeza_No_Nula())
            {
                NodoInt_LS nodoActual = cabeza;
                maximo = nodoActual.Valor;

                while (nodoActual != null) {

                    if (nodoActual.Valor>maximo)
                    {
                        maximo = nodoActual.Valor; 
                    }

                    nodoActual= nodoActual.Siguiente;
                }
            }
            return maximo;
        }

        /// <summary>
        /// Debe buscar el elemento mínimo de la lista y retornarlo
        /// </summary>
        /// <returns></returns>
        public int Busque_Numero_Minimo_Lista() {

            int minimo = 0;
            if (Cabeza_No_Nula())
            {
                NodoInt_LS nodoActual = cabeza;
                minimo = nodoActual.Valor;

                while (nodoActual != null)
                {

                    if (nodoActual.Valor < minimo)
                    {
                        minimo = nodoActual.Valor;
                    }

                    nodoActual = nodoActual.Siguiente;
                }
            }
            return minimo;
        }

        /// <summary>
        /// Debe sumar todos los elementos de la lista y retornarlos
        /// </summary>
        /// <returns></returns>
        public int Sume_Elementos_Lista() {

            int suma = 0;
            if (Cabeza_No_Nula())
            {
                NodoInt_LS nodoActual = cabeza;

                while (nodoActual != null)
                {
                    suma = suma+nodoActual.Valor;
                    nodoActual = nodoActual.Siguiente;
                }
            }

            return suma;        
        }

        /// <summary>
        /// Verifique si todos los elementos de la lista son pares
        /// </summary>
        /// <returns></returns>
        public bool Verifique_Todos_Elementos_Pares() {

            bool todosPares = true;

            if (Cabeza_No_Nula())
            {
                NodoInt_LS nodoActual = cabeza;

                while (nodoActual != null)
                {
                    if (nodoActual.Valor%2!=0)
                    {
                        todosPares = false;
                    }
                    nodoActual = nodoActual.Siguiente;
                }
            }
            return todosPares;
        }

        public double valorRef_Promedio(int _valorRef)
        {
            double promedio=0;
            double sumaElem=0;
            int count=0;
            if (Cabeza_No_Nula())
            {
                NodoInt_LS nodoActual = cabeza;

                while (nodoActual != null)
                {
                    if (_valorRef <= nodoActual.Valor)
                    {
                        sumaElem += nodoActual.Valor;
                        count++;
                    }
                    nodoActual = nodoActual.Siguiente;
                }
                promedio = sumaElem / count;
            }
            return promedio;
        }

        public void Eliminar_Varios_nodos(int _valornodo, int _cantNodos)
        {
            Eliminar_recursivo(_valornodo, _cantNodos);
        }

        public void Eliminar_recursivo(int _valornodo, int _cantNodos)
        {
            NodoInt_LS nodoActual =cabeza;
            if (_cantNodos == 0)
            {

            }
            else
            {
                while (nodoActual.Valor != _valornodo)
                {
                    nodoActual = nodoActual.Siguiente;
                }
                if (nodoActual.Siguiente.Siguiente == null)
                {
                    nodoActual.Siguiente = null;
                }
                else
                {
                    NodoInt_LS aux = nodoActual.Siguiente;
                    nodoActual.Siguiente = aux.Siguiente;
                    aux.Siguiente = null;
                    aux = null;

                    _cantNodos--;
                    Eliminar_recursivo(_valornodo, _cantNodos);
                }
            }
        }

    }
}
