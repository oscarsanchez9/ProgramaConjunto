using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConjuto
{
    class Clase_Oscar
    {
        public void mostrardatos(ClaseRaul.Fichas[] TipoFichas, int Contador)
        {
            for (int i = 0; i < Contador; i++)
            {
                Console.WriteLine("Los datos de la ficha {0} son :", i + 1);
                Console.WriteLine("Nombre {0}", TipoFichas[i].Nombre);
                Console.WriteLine("Tamaño {0}", TipoFichas[i].Tamanyo);
                Console.WriteLine("Luz {0}", TipoFichas[i].Luz);

            }


        }
    }
}
