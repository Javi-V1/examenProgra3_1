using Capa_Logica.Cola;
using Capa_Logica.Lista_Doble;
using Capa_Logica.Lista_Simple;

Orquestador_Lista_Simple orquestador_LS = new Orquestador_Lista_Simple();
Orquestador_Lista_Doble orquestador_LD = new Orquestador_Lista_Doble();
Orquestador_Cola orquestador_Cola   = new Orquestador_Cola();



//LISTA SIMPLE

orquestador_LS.Agregar_NodoInt_LS(1);
orquestador_LS.Agregar_NodoInt_LS(5);
orquestador_LS.Agregar_NodoInt_LS(3);
orquestador_LS.Agregar_NodoInt_LS(4);
orquestador_LS.Agregar_NodoInt_LS(6);
orquestador_LS.Agregar_NodoInt_LS(2);
orquestador_LS.Mostrar_Lista_Simple();

///Ejercicio 1 Examen
//Console.Write("El promedio es: " + orquestador_LS.valorRef_Promedio(4));

///Ejercicio 2 Examen
orquestador_LS.Eliminar_Varios_nodos(6,0);
orquestador_LS.Mostrar_Lista_Simple();



//LISTA DOBLE

orquestador_LD.Agregue_NodoInt_LD_Final(1);
orquestador_LD.Agregue_NodoInt_LD_Final(4);
orquestador_LD.Agregue_NodoInt_LD_Final(2);
orquestador_LD.Agregue_NodoInt_LD_Final(7);
orquestador_LD.Agregue_NodoInt_LD_Final(3);
orquestador_LD.Agregue_NodoInt_LD_Final(5);
//orquestador_LD.Muestre_Lista_Inicio_Fin();

///Ejercicio 4 examen
//orquestador_LD.Intercambio_valor();
//orquestador_LD.Muestre_Lista_Inicio_Fin();


//COLA

orquestador_Cola.Enqueue(1);
orquestador_Cola.Enqueue(2);
orquestador_Cola.Enqueue(3);
orquestador_Cola.Enqueue(4);

///Ejercicio 3 Examen
//orquestador_Cola.Suma_Elementos();


