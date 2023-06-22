using Capa_Logica.Cola;
using Capa_Logica.Lista_Doble;
using Capa_Logica.Lista_Simple;

Orquestador_Lista_Simple orquestador_LS = new Orquestador_Lista_Simple();
Orquestador_Lista_Doble orquestador_LD = new Orquestador_Lista_Doble();
Orquestador_Cola orquestador_Cola   = new Orquestador_Cola();

orquestador_Cola.Enqueue(1);
orquestador_Cola.Enqueue(2);
orquestador_Cola.Enqueue(3);
orquestador_Cola.Enqueue(4);
orquestador_Cola.Imprimir_Cola();
orquestador_Cola.Enqueue(orquestador_Cola.Dequeue().Valor);
orquestador_Cola.Enqueue(orquestador_Cola.Dequeue().Valor);
orquestador_Cola.Enqueue(orquestador_Cola.Dequeue().Valor);
orquestador_Cola.Imprimir_Cola();