using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace maquina
{
   public class animacion
    {
        estilo_maquina esma = new estilo_maquina();
        public void espera()
        {
            Console.WriteLine("——");
            Console.WriteLine("");
            Console.WriteLine("|");
        }
        public void caida_soda()
        {

            for (int i = 0; i < 5; i++)
            {

            }

            Console.Clear();
            esma.estilo();
            Console.SetCursorPosition(15, 25);
            Console.WriteLine("██");
            Thread.Sleep(1000); 
            Console.Clear();
            Console.SetCursorPosition(15, 26);
            Console.WriteLine("██");
            Thread.Sleep(1000);
            Console.Clear();
            Console.SetCursorPosition(15, 27);
            Console.WriteLine("██");
            Thread.Sleep(1000);
            Console.Clear();
            Console.SetCursorPosition(15, 28);
            Console.WriteLine("██");
            Thread.Sleep(1000);
            Console.Clear();
            Console.SetCursorPosition(15, 29);
            Thread.Sleep(1000);
            Console.WriteLine("██");
            Thread.Sleep(1000);
            Console.ReadKey();
            
        }
        }

       
    }

