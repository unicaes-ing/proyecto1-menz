using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquina
{
    class Program
    {

        public static void Main(string[] args)
        {
            modo_compra mc/*mc= modo compra*/ = new modo_compra();
            modo_administrador modad = new modo_administrador();
            estilo_maquina esma = new estilo_maquina();

            int op, pass, pass1;
            pass = 1234;
            esma.estilo();
        regreso:
            Console.Clear();
            esma.estilo();
            Console.BufferHeight = 45;

            Console.WindowHeight = 40;
            Console.WindowWidth = 80;
            Console.SetCursorPosition(9, 6);
            Console.WriteLine("¡¡Hola Bienvenido!!");
            Console.WriteLine();
            Console.SetCursorPosition(9, 7);
            Console.WriteLine("Que desea hacer??");
            Console.WriteLine();
            Console.SetCursorPosition(9, 8);
            Console.WriteLine("1-)Modo Administrador");
            Console.SetCursorPosition(9, 9);
            Console.WriteLine("2-)Realizar pedido");
            Console.WriteLine();
            do
            {
                Console.SetCursorPosition(9, 13);
                Console.Write("Ingrese su opcion: ");

                op = Convert.ToInt32(Console.ReadLine());
                switch (op)

                {
                    case 1:

                        Console.Clear();
                        esma.estilo();
                        Console.SetCursorPosition(9, 6);
                        Console.WriteLine("Ingrese su contraseña");
                        Console.SetCursorPosition(9, 8);
                        Console.Write("Contraseña: ");
                        pass1 = Convert.ToInt32(Console.ReadLine());

                        if (pass == pass1)
                        {
                            Console.Clear();
                            esma.estilo();
                            Console.SetCursorPosition(9, 6);
                            Console.WriteLine("¡¡Bienvenido al modo administrador!!");
                            modad.modadmin();

                        }

                        else
                        {
                            Console.Clear();
                            esma.estilo();
                            Console.SetCursorPosition(9, 7);
                            Console.WriteLine("Contraseña Incorrecta!!!!");
                            Console.SetCursorPosition(9, 8);
                            Console.WriteLine("Ingresela de nuevo");
                            Console.SetCursorPosition(9, 10);
                            Console.WriteLine("Presiona cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            goto case 1;
                        }

                        break;

                    case 2:
                        mc.modcompra();

                        break;

                    default:
                        Console.Clear();
                        esma.estilo();
                        Console.SetCursorPosition(9, 7);
                        Console.WriteLine("Ninguna de las opciones es correcta");
                        Console.SetCursorPosition(9, 9);
                        Console.WriteLine("Elija entre:");
                        Console.SetCursorPosition(9, 11);
                        Console.WriteLine("1-)Modo Administrador");
                        Console.SetCursorPosition(9, 12);
                        Console.WriteLine("2-)Realizar pedido");
                        break;



                }
            } while (op > 3 || op <= 0);
            if (op == 3)
            {
                Console.Clear();
                esma.estilo();
                Console.SetCursorPosition(9, 7);
                Console.WriteLine("Ingrese 1 para volver al Inicio");
                Console.SetCursorPosition(9, 8);
                Console.Write("Ingrese su contraseña:");

            repetir:
                pass1 = Convert.ToInt32(Console.ReadLine());
                if (pass == pass1)
                {
                    Console.Clear();
                    esma.estilo();
                    Console.SetCursorPosition(9, 8);
                    Console.WriteLine("Presione <Enter> para apagar la maquina");
                }
                else
                    if (pass1 == 1)
                {
                    goto regreso;
                }
                else
                {
                    Console.SetCursorPosition(9, 8);
                    Console.WriteLine("Clave Incorrecta!!");
                    Console.Write("contraseña:");
                    goto repetir;
                }

            }
            else
            {
                goto regreso;
            }
            Console.ReadKey();
        
    }
    }
}
