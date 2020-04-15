using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoConjuto
{
   public class Clase_Ana
    {

        
       
        public void menu()
        {
            int nmenu = 0;

            Console.WriteLine("Pulsa 1 para añadir dato. \nPulsa 2 para mostar los datos \nPulsa 3 para la búsqueda parcial.\n Pulsa 4 para buscar datos a partir de un número específico.\n Pulsa 5 para salir" );
            nmenu = Convert.ToInt32(Console.ReadLine());
            while (nmenu !=5)
            {
                switch (nmenu)
                {
                    case 1:
                       
                        

                        break;

                    case 2:

                        break;

                    case 3:
                        break;

                    case 4:
                        break;



                }
            }

            if(nmenu == 5)
            {
                Console.WriteLine("Suscríbete y dame like, Cristian. :)");
            }
           
        }
           
            
    }
}
