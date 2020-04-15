using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConjuto
{
    public class ClaseRaul
    {
       public  struct Fichas
        {
            public string Nombre;
            public int Tamanyo;
            public string Luz;

        }
        public int TamanyoBuscar;
        public int Contador=0;
        public Fichas[] TipoFichas = new Fichas[10];
        public void AddDato()
        {
            if (Contador<10)
            {
            Console.WriteLine("Introduce el nombre.");
            TipoFichas[Contador].Nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduce el tamaño.");
            TipoFichas[Contador].Tamanyo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el tipo de luz.");
            TipoFichas[Contador].Luz = Convert.ToString(Console.ReadLine());
            Contador++;

            }
            else
            {
                Console.WriteLine("No queda espacio de almacenamiento.");
            }
            
        }
        public void MostrarAPartirDe()
        {
            Console.WriteLine("¿A partir de que tamaño quieres buscar?");
            TamanyoBuscar = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Contador; i++)
            {
                if (TipoFichas[i].Tamanyo >= TamanyoBuscar)
                {
                    Console.WriteLine("Nombre:{0}. Tamaño:{1}. Luz:{2}.", TipoFichas[i].Nombre, TipoFichas[i].Tamanyo, TipoFichas[i].Luz);
                }
                
            }
        }




    }
}
